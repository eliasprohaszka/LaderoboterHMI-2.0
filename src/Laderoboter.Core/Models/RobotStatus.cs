namespace Laderoboter.Core.Models;

public class RobotStatus
{
    public bool IsConnected { get; set; }
    public string? IpAddress { get; set; }
    public bool IsRunning { get; set; }
    public string? CurrentProgram { get; set; }
    public int SpeedOverride { get; set; }
    public bool MaintenanceDoorOpen { get; set; }
    public bool AutoStopActive { get; set; }
    public DateTime? LastUpdated { get; set; }
    public string? ErrorMessage { get; set; }
}
