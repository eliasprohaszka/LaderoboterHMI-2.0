using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service for managing robot alarm state and notifications
/// </summary>
public interface IRobotAlarmService
{
    /// <summary>
    /// Current alarm state
    /// </summary>
    RobotAlarmState CurrentState { get; }

    /// <summary>
    /// List of current alarms
    /// </summary>
    IReadOnlyList<RobotAlarm> CurrentAlarms { get; }

    /// <summary>
    /// The most recent active alarm (not reset)
    /// </summary>
    RobotAlarm? ActiveAlarm { get; }

    /// <summary>
    /// Whether there is an active alarm that needs attention
    /// </summary>
    bool HasActiveAlarm { get; }

    /// <summary>
    /// Event raised when alarm state changes
    /// </summary>
    event EventHandler<RobotAlarmStateChangedEventArgs>? AlarmStateChanged;

    /// <summary>
    /// Refreshes the alarm list from the robot
    /// </summary>
    Task RefreshAlarmsAsync();

    /// <summary>
    /// Acknowledges that the user has seen the current alarms
    /// </summary>
    void AcknowledgeAlarms();

    /// <summary>
    /// Resets/clears alarms on the robot
    /// </summary>
    Task<bool> ResetAlarmsAsync();
}

public class RobotAlarmStateChangedEventArgs : EventArgs
{
    public required RobotAlarmState NewState { get; init; }
    public required IReadOnlyList<RobotAlarm> Alarms { get; init; }
}
