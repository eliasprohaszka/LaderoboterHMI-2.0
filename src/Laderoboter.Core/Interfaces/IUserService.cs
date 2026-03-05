using Laderoboter.Core.Models;

namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für Benutzerverwaltung
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Gibt alle Benutzer zurück
    /// </summary>
    Task<IEnumerable<User>> GetAllUsersAsync();

    /// <summary>
    /// Gibt einen Benutzer anhand der ID zurück
    /// </summary>
    Task<User?> GetUserByIdAsync(int id);

    /// <summary>
    /// Gibt einen Benutzer anhand der Personalnummer zurück
    /// </summary>
    Task<User?> GetUserByPersonalNumberAsync(string personalNumber);

    /// <summary>
    /// Erstellt einen neuen Benutzer
    /// </summary>
    Task<User> CreateUserAsync(string personalNumber, string password, UserRole role, string? name = null, string? rfidTag = null);

    /// <summary>
    /// Aktualisiert einen Benutzer
    /// </summary>
    Task<User?> UpdateUserAsync(int id, string? personalNumber = null, string? password = null, UserRole? role = null, string? name = null, string? rfidTag = null, bool? isActive = null);

    /// <summary>
    /// Löscht einen Benutzer
    /// </summary>
    Task<bool> DeleteUserAsync(int id);

    /// <summary>
    /// Exportiert alle Benutzer als JSON-String (ohne Passwort-Hashes und RFID-Tags)
    /// </summary>
    Task<string> ExportToJsonAsync();

    /// <summary>
    /// Validiert und importiert Benutzer aus einem JSON-String
    /// </summary>
    Task<UsersImportResult> ImportFromJsonAsync(string json);

    /// <summary>
    /// Validiert den JSON ohne zu importieren
    /// </summary>
    Task<UsersImportValidation> ValidateImportJsonAsync(string json);
}

/// <summary>
/// Result of a users import operation.
/// </summary>
public class UsersImportResult
{
    public bool Success { get; set; }
    public int ImportedCount { get; set; }
    public int UpdatedCount { get; set; }
    public int SkippedCount { get; set; }
    public List<string> Errors { get; set; } = new();
    public string? ErrorMessage { get; set; }
}

/// <summary>
/// Result of validating a users import JSON.
/// </summary>
public class UsersImportValidation
{
    public bool IsValid { get; set; }
    public int NewUserCount { get; set; }
    public int ExistingUserCount { get; set; }
    public List<string> Warnings { get; set; } = new();
    public string? ErrorMessage { get; set; }
}
