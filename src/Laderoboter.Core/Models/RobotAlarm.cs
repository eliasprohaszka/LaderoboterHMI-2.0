namespace Laderoboter.Core.Models;

/// <summary>
/// Represents a robot alarm/error entry from the FANUC controller
/// </summary>
public class RobotAlarm
{
    /// <summary>
    /// Unique identifier for this alarm
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Error code from the robot (e.g. "SRVO-001")
    /// </summary>
    public string ErrorCode { get; set; } = string.Empty;

    /// <summary>
    /// Error message description
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Raw text of the error entry
    /// </summary>
    public string? RawText { get; set; }

    /// <summary>
    /// When the error occurred
    /// </summary>
    public DateTime OccurredAt { get; set; }

    /// <summary>
    /// Whether this alarm has been acknowledged/viewed by the user
    /// </summary>
    public bool IsAcknowledged { get; set; }

    /// <summary>
    /// When the alarm was acknowledged
    /// </summary>
    public DateTime? AcknowledgedAt { get; set; }

    /// <summary>
    /// Whether this alarm has been reset
    /// </summary>
    public bool IsReset { get; set; }

    /// <summary>
    /// When the alarm was reset
    /// </summary>
    public DateTime? ResetAt { get; set; }
}

/// <summary>
/// Represents the current alarm state for the robot
/// </summary>
public enum RobotAlarmState
{
    /// <summary>
    /// No active alarms
    /// </summary>
    None,

    /// <summary>
    /// Active alarm that has not been viewed
    /// </summary>
    Active,

    /// <summary>
    /// Alarm has been viewed but not reset
    /// </summary>
    Acknowledged,

    /// <summary>
    /// All alarms have been reset
    /// </summary>
    Reset
}
