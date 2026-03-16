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

    /// <summary>Stream der Regal Änderungen (7x4 Grid, 28 Positionen)</summary>
    IObservable<ShelfSnapshot> ShelfChanges { get; }

    /// <summary>Stream des Robot-Status</summary>
    IObservable<RobotStatus> StatusChanges { get; }

    /// <summary>Stream von Fehlern</summary>
    IObservable<MonitorError> Errors { get; }

    /// <summary>Ist das Monitoring aktiv?</summary>
    bool IsMonitoring { get; }

    /// <summary>Aktuelle Ansicht (Palette oder Shelf) - bestimmt welche Register gepollt werden</summary>
    MonitorView CurrentView { get; set; }

    /// <summary>Startet das Monitoring</summary>
    void Start();

    /// <summary>Stoppt das Monitoring</summary>
    void Stop();
}

/// <summary>
/// Bestimmt welche Register-Gruppe gepollt wird
/// </summary>
public enum MonitorView
{
    /// <summary>Palette 1 & 2 Register (R50-65 / R150-165)</summary>
    Palette,
    /// <summary>Regal Register (R66-93 / R166-193)</summary>
    Shelf
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
/// Snapshot des Regals mit allen 28 Workpiece-Zuständen (7x4 Grid)
/// Register: R66-R93 (Runtime) oder R166-R193 (Idle)
/// Position-Mapping: Regal_1_1 = R66/R166, Regal_7_4 = R93/R193
/// </summary>
public record ShelfSnapshot(
    IReadOnlyList<WorkpieceState> States,
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
    private readonly IRegisterCacheService _registerCache;
    private readonly ISettingsService _settings;

    // Subjects für die verschiedenen Streams
    private readonly Subject<RegisterChange> _registerChanges = new();
    private readonly Subject<PaletteSnapshot> _palette1Changes = new();
    private readonly Subject<PaletteSnapshot> _palette2Changes = new();
    private readonly Subject<ShelfSnapshot> _shelfChanges = new();
    private readonly Subject<RobotStatus> _statusChanges = new();
    private readonly Subject<MonitorError> _errors = new();

    // State tracking (local cache for snapshot comparison)
    private readonly Dictionary<int, int> _localCache = new();
    private readonly object _lockObject = new();

    private PaletteSnapshot? _lastPalette1;
    private PaletteSnapshot? _lastPalette2;
    private ShelfSnapshot? _lastShelf;
    private RobotStatus? _lastStatus;

    private bool _disposed;
    private bool _isMonitoring;

    // Aktuelle View - bestimmt welche Register relevant sind
    private MonitorView _currentView = MonitorView.Palette;

    public RobotMonitor(IRobotService robotService, IRegisterCacheService registerCache, ISettingsService settings)
    {
        _robotService = robotService;
        _registerCache = registerCache;
        _settings = settings;
    }

    public IObservable<RegisterChange> RegisterChanges => _registerChanges.AsObservable();
    public IObservable<PaletteSnapshot> Palette1Changes => _palette1Changes.AsObservable();
    public IObservable<PaletteSnapshot> Palette2Changes => _palette2Changes.AsObservable();
    public IObservable<ShelfSnapshot> ShelfChanges => _shelfChanges.AsObservable();
    public IObservable<RobotStatus> StatusChanges => _statusChanges.AsObservable();
    public IObservable<MonitorError> Errors => _errors.AsObservable();

    public bool IsMonitoring => _isMonitoring;

    public MonitorView CurrentView
    {
        get => _currentView;
        set => _currentView = value;
    }

    public void Start()
    {
        lock (_lockObject)
        {
            if (_isMonitoring) return;

            _isMonitoring = true;

            // Subscribe to cache events instead of polling
            _registerCache.RegisterChanged += OnRegisterChanged;
            _registerCache.CacheUpdated += OnCacheUpdated;
        }
    }

    public void Stop()
    {
        lock (_lockObject)
        {
            if (!_isMonitoring) return;

            _isMonitoring = false;

            // Unsubscribe from cache events
            _registerCache.RegisterChanged -= OnRegisterChanged;
            _registerCache.CacheUpdated -= OnCacheUpdated;
        }
    }

    private void OnRegisterChanged(object? sender, RegisterChangedEventArgs e)
    {
        if (!_isMonitoring) return;

        // Update local cache for snapshot comparison
        _localCache[e.Address] = e.NewValue;

        // Emit register change
        var change = new RegisterChange(
            e.Address,
            e.OldValue ?? -1,
            e.NewValue,
            DateTime.UtcNow
        );

        _registerChanges.OnNext(change);
        ProcessRegisterChange(change);
    }

    private void OnCacheUpdated(object? sender, RegistersCacheUpdatedEventArgs e)
    {
        if (!_isMonitoring) return;

        // Refresh local cache from central cache for all registers
        // This ensures snapshots use the latest values
        for (int addr = 1; addr <= 200; addr++)
        {
            var value = _registerCache.GetRegister(addr);
            if (value.HasValue)
            {
                _localCache[addr] = value.Value;
            }
        }
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
        // Regal Register (66-93 wenn läuft, 166-193 wenn nicht läuft)
        else if ((programRunning && change.Address is >= 66 and <= 93) ||
                 (!programRunning && change.Address is >= 166 and <= 193))
        {
            EmitShelfSnapshot();
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
            .Select(addr => (WorkpieceState)_localCache.GetValueOrDefault(addr, 0))
            .ToList();

        var sequences = Enumerable.Range(101, 8)
            .Select(addr => _localCache.GetValueOrDefault(addr, 0))
            .ToList();

        var mode = _localCache.GetValueOrDefault(48, 0);

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
            .Select(addr => (WorkpieceState)_localCache.GetValueOrDefault(addr, 0))
            .ToList();

        var sequences = Enumerable.Range(109, 8)
            .Select(addr => _localCache.GetValueOrDefault(addr, 0))
            .ToList();

        var mode = _localCache.GetValueOrDefault(148, 0);

        var snapshot = new PaletteSnapshot(
            2, states, sequences, mode, mode == 1, DateTime.UtcNow
        );

        if (!SnapshotsEqual(_lastPalette2, snapshot))
        {
            _lastPalette2 = snapshot;
            _palette2Changes.OnNext(snapshot);
        }
    }

    private void EmitShelfSnapshot()
    {
        // Prüfe ob Programm läuft (basierend auf RobotService Status)
        bool programRunning = _robotService.Status.IsRunning;

        // Wähle die richtigen Register basierend auf Programm-Status
        // Runtime: 66-93 (28 Register), Idle: 166-193 (28 Register)
        int baseAddress = programRunning ? 66 : 166;

        var states = Enumerable.Range(baseAddress, 28)
            .Select(addr => (WorkpieceState)_localCache.GetValueOrDefault(addr, 0))
            .ToList();

        // Regal hat aktuell kein separates Mode-Register - verwende Standard
        var mode = 0;

        var snapshot = new ShelfSnapshot(
            states, mode, mode == 1, DateTime.UtcNow
        );

        if (!ShelfSnapshotsEqual(_lastShelf, snapshot))
        {
            _lastShelf = snapshot;
            _shelfChanges.OnNext(snapshot);
        }
    }

    private static bool ShelfSnapshotsEqual(ShelfSnapshot? a, ShelfSnapshot? b)
    {
        if (a == null || b == null) return false;
        return a.Mode == b.Mode &&
               a.IsActive == b.IsActive &&
               a.States.SequenceEqual(b.States);
    }

    private void EmitStatusChange()
    {
        var status = new RobotStatus
        {
            IsConnected = _robotService.IsConnected,
            AutoStopActive = _localCache.GetValueOrDefault(86, 0) == 1 ||
                            _localCache.GetValueOrDefault(186, 0) == 1,
            MaintenanceDoorOpen = _localCache.GetValueOrDefault(87, 0) == 1,
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
        _shelfChanges.Dispose();
        _statusChanges.Dispose();
        _errors.Dispose();

        _disposed = true;
    }
}
