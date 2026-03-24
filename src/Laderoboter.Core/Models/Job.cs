namespace Laderoboter.Core.Models;

/// <summary>
/// Repräsentiert einen Job in der Jobliste.
/// Ein Job verknüpft ein Werkstück (Position auf einer Palette) mit einer Sequenznummer.
/// </summary>
public class Job
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
    /// Reihenfolge in der Jobliste (1-16)
    /// </summary>
    public int SequenceNumber { get; set; }

    /// <summary>
    /// CNC-Programmnummer (optional, für zukünftige Verwendung)
    /// </summary>
    public int? ProgramNumber { get; set; }

    /// <summary>
    /// Zeitpunkt der Erstellung
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Zeitpunkt der letzten Änderung
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gibt die Werkstück-ID im Format "P{Palette}-{Position}" zurück
    /// </summary>
    public string WorkpieceId => $"P{PaletteNumber}-{Position}";
}
