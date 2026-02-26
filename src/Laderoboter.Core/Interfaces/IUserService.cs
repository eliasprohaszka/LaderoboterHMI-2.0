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
}
