using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service for managing robot alarm state and notifications
/// </summary>
public class RobotAlarmService : IRobotAlarmService, IDisposable
{
    private readonly IRobotService _robotService;
    private readonly List<RobotAlarm> _currentAlarms = [];
    private System.Threading.Timer? _refreshTimer;
    private readonly object _refreshLock = new();
    private RobotAlarmState _currentState = RobotAlarmState.None;
    private HashSet<string> _knownAlarmKeys = [];
    private bool _disposed;
    private bool _timerStarted;

    // FTP-Abfragen starten nach SNPX um Überlastung zu vermeiden
    private const int INITIAL_DELAY_AFTER_CONNECT_MS = 2500; // Nach RegisterCacheService (1500ms)
    private const int REFRESH_INTERVAL_MS = 2000;

    public RobotAlarmService(IRobotService robotService)
    {
        _robotService = robotService;
        _robotService.StatusChanged += OnRobotStatusChanged;
        // Timer startet erst bei Connect
    }

    private void RefreshTimerCallback(object? state)
    {
        if (_disposed || !_robotService.IsConnected)
            return;

        if (!Monitor.TryEnter(_refreshLock))
            return;

        try
        {
            // Fire and forget - RefreshAlarmsAsync handles its own errors
            _ = RefreshAlarmsAsync();
        }
        finally
        {
            Monitor.Exit(_refreshLock);
        }
    }

    public RobotAlarmState CurrentState => _currentState;

    public IReadOnlyList<RobotAlarm> CurrentAlarms => _currentAlarms.AsReadOnly();

    public RobotAlarm? ActiveAlarm => _currentAlarms
        .Where(a => !a.IsReset)
        .OrderByDescending(a => a.OccurredAt)
        .FirstOrDefault();

    public bool HasActiveAlarm => _currentAlarms.Any(a => !a.IsReset);

    public event EventHandler<RobotAlarmStateChangedEventArgs>? AlarmStateChanged;

    public async Task RefreshAlarmsAsync()
    {
        if (!_robotService.IsConnected)
        {
            if (_currentAlarms.Count > 0)
            {
                _currentAlarms.Clear();
                _knownAlarmKeys.Clear();
                UpdateState(RobotAlarmState.None);
            }
            return;
        }

        // Fetch alarms via FTP
        var alarms = await _robotService.GetAlarmsAsync();

        // Check for new alarms that we haven't seen before
        var newAlarms = new List<RobotAlarm>();
        foreach (var alarm in alarms)
        {
            var key = GetAlarmKey(alarm);
            if (!_knownAlarmKeys.Contains(key))
            {
                newAlarms.Add(alarm);
                _knownAlarmKeys.Add(key);
            }
        }

        // Preserve acknowledged state from existing alarms
        var acknowledgedKeys = _currentAlarms
            .Where(a => a.IsAcknowledged)
            .Select(GetAlarmKey)
            .ToHashSet();

        // Update the current alarms list
        _currentAlarms.Clear();
        _currentAlarms.AddRange(alarms);

        // Restore acknowledged state
        foreach (var alarm in _currentAlarms)
        {
            var key = GetAlarmKey(alarm);
            if (acknowledgedKeys.Contains(key))
            {
                alarm.IsAcknowledged = true;
            }
        }

        // Determine new state
        if (_currentAlarms.Count == 0)
        {
            UpdateState(RobotAlarmState.None);
        }
        else if (newAlarms.Count > 0)
        {
            // New unacknowledged alarms
            UpdateState(RobotAlarmState.Active);
        }
        else if (_currentAlarms.All(a => a.IsAcknowledged))
        {
            UpdateState(RobotAlarmState.Acknowledged);
        }
        // Otherwise keep current state
    }

    public void AcknowledgeAlarms()
    {
        foreach (var alarm in _currentAlarms)
        {
            if (!alarm.IsAcknowledged)
            {
                alarm.IsAcknowledged = true;
                alarm.AcknowledgedAt = DateTime.UtcNow;
            }
        }

        if (_currentAlarms.Count > 0 && _currentState == RobotAlarmState.Active)
        {
            UpdateState(RobotAlarmState.Acknowledged);
        }
    }

    public async Task<bool> ResetAlarmsAsync()
    {
        var success = await _robotService.ClearAlarmsAsync();

        if (success)
        {
            foreach (var alarm in _currentAlarms)
            {
                alarm.IsReset = true;
                alarm.ResetAt = DateTime.UtcNow;
            }

            // Refresh to get actual state from robot
            await RefreshAlarmsAsync();
        }

        return success;
    }

    private void OnRobotStatusChanged(object? sender, Events.RobotStatusChangedEventArgs e)
    {
        Console.WriteLine($"[RobotAlarmService] StatusChanged: IsConnected={e.Status.IsConnected}, _timerStarted={_timerStarted}");

        if (e.Status.IsConnected)
        {
            if (!_timerStarted)
            {
                // Verbindung hergestellt - Timer mit Verzögerung starten
                // Startet NACH RegisterCacheService um FTP/SNPX nicht gleichzeitig zu belasten
                _timerStarted = true;
                _refreshTimer = new System.Threading.Timer(
                    RefreshTimerCallback,
                    null,
                    TimeSpan.FromMilliseconds(INITIAL_DELAY_AFTER_CONNECT_MS),
                    TimeSpan.FromMilliseconds(REFRESH_INTERVAL_MS));

                Console.WriteLine($"[RobotAlarmService] Timer gestartet mit {INITIAL_DELAY_AFTER_CONNECT_MS}ms Initial-Delay");
            }
        }
        else
        {
            // Verbindung getrennt - Timer stoppen und Alarms leeren
            if (_refreshTimer != null)
            {
                _refreshTimer.Dispose();
                _refreshTimer = null;
            }
            _timerStarted = false;

            if (_currentAlarms.Count > 0)
            {
                _currentAlarms.Clear();
                _knownAlarmKeys.Clear();
                UpdateState(RobotAlarmState.None);
            }

            Console.WriteLine("[RobotAlarmService] Timer gestoppt, Alarms geleert");
        }
    }

    private void UpdateState(RobotAlarmState newState)
    {
        if (_currentState != newState)
        {
            _currentState = newState;
            AlarmStateChanged?.Invoke(this, new RobotAlarmStateChangedEventArgs
            {
                NewState = newState,
                Alarms = _currentAlarms.AsReadOnly()
            });
        }
    }

    private static string GetAlarmKey(RobotAlarm alarm)
    {
        return $"{alarm.ErrorCode}_{alarm.OccurredAt:yyyyMMddHHmmss}";
    }

    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;

        _refreshTimer?.Dispose();
        _robotService.StatusChanged -= OnRobotStatusChanged;
        GC.SuppressFinalize(this);
    }
}
