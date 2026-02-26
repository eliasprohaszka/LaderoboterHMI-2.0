using Laderoboter.Core.Models;

namespace Laderoboter.UI.Services;

/// <summary>
/// UI-Service für Authentifizierungsstatus
/// </summary>
public interface IAuthStateService
{
    /// <summary>
    /// Aktuell angemeldeter Benutzer
    /// </summary>
    User? CurrentUser { get; }

    /// <summary>
    /// Gibt an, ob ein Benutzer angemeldet ist
    /// </summary>
    bool IsAuthenticated { get; }

    /// <summary>
    /// Event bei Änderung des Authentifizierungsstatus
    /// </summary>
    event EventHandler<User?>? AuthStateChanged;

    /// <summary>
    /// Anmeldung mit Personalnummer und Passwort
    /// </summary>
    Task<bool> LoginAsync(string personalNumber, string password);

    /// <summary>
    /// Anmeldung mit RFID-Tag
    /// </summary>
    Task<bool> LoginByRfidAsync(string rfidTag);

    /// <summary>
    /// Abmeldung
    /// </summary>
    Task LogoutAsync();
}
