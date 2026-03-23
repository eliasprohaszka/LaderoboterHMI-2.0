using Laderoboter.Core.Models;

namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für Benutzeraktions-Protokollierung
/// </summary>
public interface IUserActionLogService
{
    /// <summary>
    /// Protokolliert eine Aktion für einen bestimmten Benutzer
    /// </summary>
    Task LogActionAsync(int userId, string action, string? details = null, string? ipAddress = null);

    /// <summary>
    /// Protokolliert eine Aktion für den aktuell angemeldeten Benutzer
    /// </summary>
    Task LogActionAsync(string action, string? details = null, string? ipAddress = null);

    /// <summary>
    /// Protokolliert eine Aktion mit Personalnummer
    /// </summary>
    Task LogActionWithPersonalNumberAsync(string personalNumber, string action, string? details = null, string? ipAddress = null);

    /// <summary>
    /// Gibt Protokolleinträge zurück, optional gefiltert
    /// </summary>
    Task<IEnumerable<UserActionLog>> GetLogsAsync(int? userId = null, DateTime? from = null, DateTime? to = null);

    /// <summary>
    /// Gibt Protokolleinträge zurück mit erweiterten Filtern
    /// </summary>
    Task<IEnumerable<UserActionLog>> GetLogsAsync(
        string? personalNumber = null,
        string? action = null,
        DateTime? from = null,
        DateTime? to = null,
        TimeSpan? timeFrom = null,
        TimeSpan? timeTo = null);

    /// <summary>
    /// Gibt alle eindeutigen Aktionen zurück
    /// </summary>
    Task<IEnumerable<string>> GetDistinctActionsAsync();

    /// <summary>
    /// Gibt alle eindeutigen Personalnummern zurück
    /// </summary>
    Task<IEnumerable<string>> GetDistinctPersonalNumbersAsync();
}
