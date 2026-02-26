using System.Reactive.Linq;
using System.Reactive.Subjects;
using Laderoboter.Core.Events;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Reaktiver Monitor für Robot-Register mit intelligentem Change-Detection.
/// Verwendet IObservable<T> für elegante Event-Streams statt klassischer Timer.
/// </summary>
public interface IRobotMonitor : IDisposable
{
    /// <summary>Stream aller Register-Änderungen</summary>
    IObservable<RegisterChange> RegisterChanges { get; }

    /// <summary>Stream der Palette 1 Änderungen</summary>
    IObservable<PaletteSnapshot> Palette1Changes { get; }

    /// <summary>Stream der Palette 2 Änderungen</summary>
    IObservable<PaletteSnapshot> Palette2Changes { get; }

    /// <summary>Stream des Robot-Status</summary>
    IObservable<RobotStatus> StatusChanges { get; }

    /// <summary>Stream von Fehlern</summary>
    IObservable<MonitorError> Errors { get; }

    /// <summary>Ist das Monitoring aktiv?</summary>
    bool IsMonitoring { get; }

    /// <summary>Startet das Monitoring</summary>
    void Start();

    /// <summary>Stoppt das Monitoring</summary>
    void Stop();
}

/// <summary>
/// Repräsentiert eine einzelne Register-Änderung
/// </summary>
public record RegisterChange(
    int Address,
    int OldValue,
    int NewValue,
    DateTime Timestamp,
    RegisterType Type = RegisterType.Numeric
);

/// <summary>
/// Snapshot einer Palette mit allen Workpiece-Zuständen
/// </summary>
public record PaletteSnapshot(
    int PaletteNumber,
    IReadOnlyList<WorkpieceState> States,
    IReadOnlyList<int> SequenceNumbers,
    int Mode,
    bool IsActive,
    DateTime Timestamp
);

/// <summary>
/// Fehler während des Monitorings
/// </summary>
public record MonitorError(
    string Code,
    string Message,
    Exception? Exception,
    DateTime Timestamp
);

public enum RegisterType
{
    Numeric,
    DigitalInput,
    DigitalOutput
}

/// <summary>
/// Implementierung des reaktiven Robot-Monitors
/// </summary>
public class RobotMonitor : IRobotMonitor
{
    private readonly IRobotService _robotService;
    private readonly ISettingsService _settings;

    // Subjects für die verschiedenen Streams
    private readonly Subject<RegisterChange> _registerChanges = new();
    private readonly Subject<PaletteSnapshot> _palette1Changes = new();
    private readonly Subject<PaletteSnapshot> _palette2Changes = new();
    private readonly Subject<RobotStatus> _statusChanges = new();
    private readonly Subject<MonitorError> _errors = new();

    // State tracking
    private readonly Dictionary<int, int> _registerCache = new();
    private readonly object _lockObject = new();

    private PaletteSnapshot? _lastPalette1;
    private PaletteSnapshot? _lastPalette2;
    private RobotStatus? _lastStatus;

    private IDisposable? _monitorSubscription;
    private CancellationTokenSource? _cancellationTokenSource;
    private bool _disposed;
    private volatile bool _isStopping;

    // Register-Layout:
    // - 50-57:   Palette 1 Workpiece States (Position 1-8) - wenn Programm läuft
    // - 58-65:   Palette 2 Workpiece States (Position 1-8) - wenn Programm läuft
    // - 150-157: Palette 1 Workpiece States (Position 1-8) - wenn Programm NICHT läuft
    // - 158-165: Palette 2 Workpiece States (Position 1-8) - wenn Programm NICHT läuft

    // Statische Register-Gruppen (immer abfragen)
    private static readonly RegisterGroup[] StaticRegisterGroups =
    [
        // Wichtige Register: Sequenz, Mode
        new RegisterGroup("Sequence", 101, 16, TimeSpan.FromMilliseconds(300)),
        new RegisterGroup("Mode1", 48, 1, TimeSpan.FromMilliseconds(500)),
        new RegisterGroup("Mode2", 148, 1, TimeSpan.FromMilliseconds(500)),

        // Status-Register: Türen, AutoStop
        new RegisterGroup("Door", 87, 1, TimeSpan.FromMilliseconds(500)),
        new RegisterGroup("Load", 88, 1, TimeSpan.FromMilliseconds(500)),
        new RegisterGroup("AutoStop1", 86, 1, TimeSpan.FromMilliseconds(500)),
        new RegisterGroup("AutoStop2", 186, 1, TimeSpan.FromMilliseconds(500))
    ];

    // Dynamische Palette-Gruppen (abhängig von Programm-Status)
    private static readonly RegisterGroup PaletteRuntimeGroup = new("PaletteRuntime", 50, 16, TimeSpan.FromMilliseconds(200));
    private static readonly RegisterGroup PaletteIdleGroup = new("PaletteIdle", 150, 16, TimeSpan.FromMilliseconds(200));

    public RobotMonitor(IRobotService robotService, ISettingsService settings)
    {
        _robotService = robotService;
        _settings = settings;
    }

    public IObservable<RegisterChange> RegisterChanges => _registerChanges.AsObservable();
    public IObservable<PaletteSnapshot> Palette1Changes => _palette1Changes.AsObservable();
    public IObservable<PaletteSnapshot> Palette2Changes => _palette2Changes.AsObservable();
    public IObservable<RobotStatus> StatusChanges => _statusChanges.AsObservable();
    public IObservable<MonitorError> Errors => _errors.AsObservable();

    public bool IsMonitoring => _monitorSubscription != null;

    public void Start()
    {
        lock (_lockObject)
        {
            if (_monitorSubscription != null) return;
            if (!_robotService.IsConnected) return;
            if (_isStopping) return;

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            // Sequentielles Polling: Ein Stream der alle Register nacheinander abfragt
            // Palette-Register werden basierend auf Programm-Status gewählt (50-65 ODER 150-165, nie beide)
            _monitorSubscription = Observable.Interval(TimeSpan.FromMilliseconds(200))
                .TakeWhile(_ => !token.IsCancellationRequested)
                .SelectMany(_ => PollAllRegistersSequentiallyAsync(token))
                .Catch<IEnumerable<RegisterChange>, OperationCanceledException>(_ =>
                    Observable.Empty<IEnumerable<RegisterChange>>())
                .Catch<IEnumerable<RegisterChange>, Exception>(ex =>
                {
                    if (!token.IsCancellationRequested)
                    {
                        _errors.OnNext(new MonitorError(
                            "POLL_ERROR",
                            $"Error polling registers: {ex.Message}",
                            ex,
                            DateTime.UtcNow
                        ));
                    }
                    return Observable.Empty<IEnumerable<RegisterChange>>();
                })
                .SelectMany(changes => changes)
                .Where(change => change.OldValue != change.NewValue)
                .Subscribe(
                    change =>
                    {
                        if (!token.IsCancellationRequested)
                        {
                            _registerChanges.OnNext(change);
                            ProcessRegisterChange(change);
                        }
                    },
                    error =>
                    {
                        if (!token.IsCancellationRequested)
                        {
                            _errors.OnNext(new MonitorError(
                                "STREAM_ERROR",
                                error.Message,
                                error,
                                DateTime.UtcNow
                            ));
                        }
                    }
                );
        }
    }

    private async Task<IEnumerable<RegisterChange>> PollAllRegistersSequentiallyAsync(CancellationToken cancellationToken = default)
    {
        if (!_robotService.IsConnected || cancellationToken.IsCancellationRequested)
            return Enumerable.Empty<RegisterChange>();

        var allChanges = new List<RegisterChange>();

        // 1. Palette-Register basierend auf Programm-Status (NUR EINE Gruppe)
        var paletteGroup = _robotService.Status.IsRunning ? PaletteRuntimeGroup : PaletteIdleGroup;
        var paletteChanges = await PollRegisterGroupAsync(paletteGroup, cancellationToken);
        if (cancellationToken.IsCancellationRequested) return allChanges;
        allChanges.AddRange(paletteChanges);

        // 2. Statische Register-Gruppen sequentiell abfragen
        foreach (var group in StaticRegisterGroups)
        {
            if (cancellationToken.IsCancellationRequested) break;
            var changes = await PollRegisterGroupAsync(group, cancellationToken);
            allChanges.AddRange(changes);
        }

        return allChanges;
    }

    public void Stop()
    {
        lock (_lockObject)
        {
            _isStopping = true;

            // Cancel ongoing operations first
            _cancellationTokenSource?.Cancel();

            // Then dispose the subscription
            _monitorSubscription?.Dispose();
            _monitorSubscription = null;

            // Dispose the cancellation token source
            _cancellationTokenSource?.Dispose();
            _cancellationTokenSource = null;

            _isStopping = false;
        }
    }

    private async Task<IEnumerable<RegisterChange>> PollRegisterGroupAsync(RegisterGroup group, CancellationToken cancellationToken = default)
    {
        if (!_robotService.IsConnected || cancellationToken.IsCancellationRequested)
            return Enumerable.Empty<RegisterChange>();

        var changes = new List<RegisterChange>();

        try
        {
            var values = await _robotService.ReadRegistersAsync(group.StartAddress, group.Count);

            if (values == null || cancellationToken.IsCancellationRequested) return changes;

            var timestamp = DateTime.UtcNow;

            for (int i = 0; i < values.Length; i++)
            {
                var address = group.StartAddress + i;
                var newValue = values[i];
                var oldValue = _registerCache.GetValueOrDefault(address, -1);

                if (oldValue != newValue)
                {
                    changes.Add(new RegisterChange(address, oldValue, newValue, timestamp));
                    _registerCache[address] = newValue;
                }
            }
        }
        catch (OperationCanceledException)
        {
            // Expected when stopping
        }

        return changes;
    }

    private void ProcessRegisterChange(RegisterChange change)
    {
        bool programRunning = _robotService.Status.IsRunning;

        // Palette 1 Register (50-57 wenn läuft, 150-157 wenn nicht läuft)
        if ((programRunning && change.Address is >= 50 and <= 57) ||
            (!programRunning && change.Address is >= 150 and <= 157))
        {
            EmitPalette1Snapshot();
        }
        // Palette 2 Register (58-65 wenn läuft, 158-165 wenn nicht läuft)
        else if ((programRunning && change.Address is >= 58 and <= 65) ||
                 (!programRunning && change.Address is >= 158 and <= 165))
        {
            EmitPalette2Snapshot();
        }
        // Sequence Register (101-116)
        else if (change.Address is >= 101 and <= 116)
        {
            // Sequence betrifft beide Paletten
            EmitPalette1Snapshot();
            EmitPalette2Snapshot();
        }
        // Mode Register
        else if (change.Address == 48)
        {
            EmitPalette1Snapshot();
        }
        else if (change.Address == 148)
        {
            EmitPalette2Snapshot();
        }
        // Status Register
        else if (change.Address is 86 or 87 or 88 or 186)
        {
            EmitStatusChange();
        }
    }

    private void EmitPalette1Snapshot()
    {
        // Prüfe ob Programm läuft (basierend auf RobotService Status)
        bool programRunning = _robotService.Status.IsRunning;

        // Wähle die richtigen Register basierend auf Programm-Status
        // Runtime: 50-57, Idle: 150-157
        int baseAddress = programRunning ? 50 : 150;

        var states = Enumerable.Range(baseAddress, 8)
            .Select(addr => (WorkpieceState)_registerCache.GetValueOrDefault(addr, 0))
            .ToList();

        var sequences = Enumerable.Range(101, 8)
            .Select(addr => _registerCache.GetValueOrDefault(addr, 0))
            .ToList();

        var mode = _registerCache.GetValueOrDefault(48, 0);

        var snapshot = new PaletteSnapshot(
            1, states, sequences, mode, mode == 1, DateTime.UtcNow
        );

        // Nur emittieren wenn sich etwas geändert hat
        if (!SnapshotsEqual(_lastPalette1, snapshot))
        {
            _lastPalette1 = snapshot;
            _palette1Changes.OnNext(snapshot);
        }
    }

    private void EmitPalette2Snapshot()
    {
        // Prüfe ob Programm läuft (basierend auf RobotService Status)
        bool programRunning = _robotService.Status.IsRunning;

        // Wähle die richtigen Register basierend auf Programm-Status
        // Runtime: 58-65, Idle: 158-165
        int baseAddress = programRunning ? 58 : 158;

        var states = Enumerable.Range(baseAddress, 8)
            .Select(addr => (WorkpieceState)_registerCache.GetValueOrDefault(addr, 0))
            .ToList();

        var sequences = Enumerable.Range(109, 8)
            .Select(addr => _registerCache.GetValueOrDefault(addr, 0))
            .ToList();

        var mode = _registerCache.GetValueOrDefault(148, 0);

        var snapshot = new PaletteSnapshot(
            2, states, sequences, mode, mode == 1, DateTime.UtcNow
        );

        if (!SnapshotsEqual(_lastPalette2, snapshot))
        {
            _lastPalette2 = snapshot;
            _palette2Changes.OnNext(snapshot);
        }
    }

    private void EmitStatusChange()
    {
        var status = new RobotStatus
        {
            IsConnected = _robotService.IsConnected,
            AutoStopActive = _registerCache.GetValueOrDefault(86, 0) == 1 ||
                            _registerCache.GetValueOrDefault(186, 0) == 1,
            MaintenanceDoorOpen = _registerCache.GetValueOrDefault(87, 0) == 1,
            LastUpdated = DateTime.UtcNow
        };

        if (_lastStatus == null || !StatusEquals(_lastStatus, status))
        {
            _lastStatus = status;
            _statusChanges.OnNext(status);
        }
    }

    private static bool SnapshotsEqual(PaletteSnapshot? a, PaletteSnapshot? b)
    {
        if (a == null || b == null) return false;
        return a.Mode == b.Mode &&
               a.IsActive == b.IsActive &&
               a.States.SequenceEqual(b.States) &&
               a.SequenceNumbers.SequenceEqual(b.SequenceNumbers);
    }

    private static bool StatusEquals(RobotStatus a, RobotStatus b)
    {
        return a.IsConnected == b.IsConnected &&
               a.AutoStopActive == b.AutoStopActive &&
               a.MaintenanceDoorOpen == b.MaintenanceDoorOpen;
    }

    public void Dispose()
    {
        if (_disposed) return;

        Stop();

        _registerChanges.Dispose();
        _palette1Changes.Dispose();
        _palette2Changes.Dispose();
        _statusChanges.Dispose();
        _errors.Dispose();

        _disposed = true;
    }
}

/// <summary>
/// Definiert eine Gruppe von Registern mit eigenem Poll-Intervall
/// </summary>
internal record RegisterGroup(
    string Name,
    int StartAddress,
    int Count,
    TimeSpan Interval
);
