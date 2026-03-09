namespace Laderoboter.Core.Models;

public class PaletteData
{
    public int PaletteNumber { get; set; }
    public List<WorkpieceStatus> Workpieces { get; set; } = new(8);
    public int Mode { get; set; }
    public bool IsActive { get; set; }
}

public class ShelfData
{
    /// <summary>
    /// 7 Reihen x 4 Spalten = 28 Positionen
    /// Position = (Row - 1) * 4 + Column, also Regal_1_1 = Position 1, Regal_7_4 = Position 28
    /// </summary>
    public List<WorkpieceStatus> Workpieces { get; set; } = new(28);
    public int Mode { get; set; }
    public bool IsActive { get; set; }

    /// <summary>
    /// Gibt das Werkstück an Position (row, column) zurück.
    /// Row: 1-7, Column: 1-4
    /// </summary>
    public WorkpieceStatus? GetWorkpiece(int row, int column)
    {
        if (row < 1 || row > 7 || column < 1 || column > 4)
            return null;
        var position = (row - 1) * 4 + column;
        return Workpieces.FirstOrDefault(w => w.Position == position);
    }
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
