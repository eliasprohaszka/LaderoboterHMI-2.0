namespace Laderoboter.Core.Models;

public class RobotStatus
{
    public bool IsConnected { get; set; }
    public string? IpAddress { get; set; }

    /// <summary>
    /// Legacy property - set manually when RunProgramAsync/StopProgramAsync is called.
    /// For active monitoring, use IsMainProgramRunning instead.
    /// </summary>
    public bool IsRunning { get; set; }

    /// <summary>
    /// Actively monitored via SNPX CurrentTaskStatus - indicates if MAIN program is running.
    /// This is the authoritative source for register address switching (R50-65 vs R150-165).
    /// </summary>
    public bool IsMainProgramRunning { get; set; }

    /// <summary>
    /// Actively monitored via SNPX CurrentTaskStatus - indicates if MAIN program is paused.
    /// </summary>
    public bool IsProgramPaused { get; set; }

    public string? CurrentProgram { get; set; }
    public int SpeedOverride { get; set; }
    public bool MaintenanceDoorOpen { get; set; }
    public bool AutoStopActive { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? ErrorMessage { get; set; }
}
