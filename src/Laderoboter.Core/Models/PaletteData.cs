namespace Laderoboter.Core.Models;

public class PaletteData
{
    public int PaletteNumber { get; set; }
    public List<WorkpieceStatus> Workpieces { get; set; } = new(8);
    public int Mode { get; set; }
    public bool IsActive { get; set; }
}

public class WorkpieceStatus
{
    public int Position { get; set; }
    public int RegisterAddress { get; set; }
    public WorkpieceState State { get; set; }
    public int SequenceNumber { get; set; }
}

public enum WorkpieceState
{
    Unused = 0,
    Locked = 1,
    Unprocessed = 2,
    Processed = 3,
    AtRobot = 4,
    InMachine = 5
}
