using Laderoboter.Core.Models;

namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für die Verwaltung der Jobliste
/// </summary>
public interface IJobService
{
    /// <summary>
    /// Event das ausgelöst wird, wenn sich die Jobliste ändert
    /// </summary>
    event EventHandler? JobListChanged;

    /// <summary>
    /// Lädt alle Jobs aus der Datenbank, sortiert nach Sequenznummer
    /// </summary>
    Task<List<Job>> GetAllJobsAsync();

    /// <summary>
    /// Fügt ein Werkstück zur Jobliste hinzu
    /// </summary>
    /// <param name="paletteNumber">Palette-Nummer (1 oder 2)</param>
    /// <param name="position">Position auf der Palette (1-8)</param>
    /// <returns>Der erstellte Job oder null bei Fehler</returns>
    Task<Job?> AddJobAsync(int paletteNumber, int position);

    /// <summary>
    /// Entfernt einen Job aus der Jobliste
    /// </summary>
    /// <param name="jobId">ID des zu entfernenden Jobs</param>
    Task<bool> RemoveJobAsync(int jobId);

    /// <summary>
    /// Entfernt einen Job anhand der Werkstück-Position
    /// </summary>
    /// <param name="paletteNumber">Palette-Nummer</param>
    /// <param name="position">Position auf der Palette</param>
    Task<bool> RemoveJobByPositionAsync(int paletteNumber, int position);

    /// <summary>
    /// Aktualisiert die Reihenfolge der Jobs
    /// </summary>
    /// <param name="jobIds">Liste der Job-IDs in der neuen Reihenfolge</param>
    Task<bool> UpdateJobOrderAsync(List<int> jobIds);

    /// <summary>
    /// Prüft ob ein Werkstück bereits in der Jobliste ist
    /// </summary>
    /// <param name="paletteNumber">Palette-Nummer</param>
    /// <param name="position">Position auf der Palette</param>
    Task<bool> IsWorkpieceInJobListAsync(int paletteNumber, int position);

    /// <summary>
    /// Gibt die Anzahl der Jobs zurück
    /// </summary>
    Task<int> GetJobCountAsync();

    /// <summary>
    /// Löscht alle Jobs aus der Jobliste
    /// </summary>
    Task ClearAllJobsAsync();

    /// <summary>
    /// Gibt die maximale Anzahl an Jobs zurück (16)
    /// </summary>
    int MaxJobs { get; }
}
