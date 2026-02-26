using Laderoboter.Core.Models;

namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für Benutzer-Authentifizierung
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Anmeldung mit Personalnummer und Passwort
    /// </summary>
    Task<User?> LoginAsync(string personalNumber, string password);

    /// <summary>
    /// Anmeldung mit RFID-Tag
    /// </summary>
    Task<User?> LoginByRfidAsync(string rfidTag);

    /// <summary>
    /// Abmeldung eines Benutzers
    /// </summary>
    Task LogoutAsync(int userId);

    /// <summary>
    /// Gibt den aktuell angemeldeten Benutzer zurück
    /// </summary>
    Task<User?> GetCurrentUserAsync();

    /// <summary>
    /// Setzt den aktuellen Benutzer
    /// </summary>
    void SetCurrentUser(User? user);

    /// <summary>
    /// Event bei Änderung des aktuellen Benutzers
    /// </summary>
    event EventHandler<User?>? CurrentUserChanged;
}
