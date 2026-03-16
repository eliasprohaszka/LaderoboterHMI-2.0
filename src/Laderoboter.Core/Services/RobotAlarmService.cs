using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service for managing robot alarm state and notifications
/// </summary>
public class RobotAlarmService : IRobotAlarmService, IDisposable
{
    private readonly IRobotService _robotService;
    private readonly List<RobotAlarm> _currentAlarms = [];
    private readonly System.Threading.Timer _refreshTimer;
    private readonly object _refreshLock = new();
    private RobotAlarmState _currentState = RobotAlarmState.None;
    private HashSet<string> _knownAlarmKeys = [];
    private bool _disposed;

    public RobotAlarmService(IRobotService robotService)
    {
        _robotService = robotService;
        _robotService.StatusChanged += OnRobotStatusChanged;

        // Timer to refresh alarms every 2 seconds
        _refreshTimer = new System.Threading.Timer(
            RefreshTimerCallback,
            null,
            TimeSpan.FromSeconds(1),
            TimeSpan.FromSeconds(2));
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
        // Could trigger alarm refresh on status changes if needed
        // For now, we rely on explicit RefreshAlarmsAsync calls
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

        _refreshTimer.Dispose();
        _robotService.StatusChanged -= OnRobotStatusChanged;
        GC.SuppressFinalize(this);
    }
}
