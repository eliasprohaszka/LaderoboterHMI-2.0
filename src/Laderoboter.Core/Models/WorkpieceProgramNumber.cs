namespace Laderoboter.Core.Models;

/// <summary>
/// Speichert die CNC-Programmnummer für ein Werkstück an einer bestimmten Position.
/// </summary>
public class WorkpieceProgramNumber
{
    public int Id { get; set; }

    /// <summary>
    /// Palette-Nummer (1 oder 2)
    /// </summary>
    public int PaletteNumber { get; set; }

    /// <summary>
    /// Position auf der Palette (1-8)
    /// </summary>
    public int Position { get; set; }

    /// <summary>
    /// CNC-Programmnummer
    /// </summary>
    public int ProgramNumber { get; set; }

    /// <summary>
    /// Zeitpunkt der Erstellung
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Zeitpunkt der letzten Änderung
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
