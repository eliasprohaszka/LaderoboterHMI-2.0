namespace Laderoboter.Core.Models;

/// <summary>
/// Benutzermodell für Authentifizierung und Autorisierung
/// </summary>
public class User
{
    public int Id { get; set; }

    /// <summary>
    /// Eindeutige Personalnummer des Benutzers
    /// </summary>
    public string PersonalNumber { get; set; } = string.Empty;

    /// <summary>
    /// PBKDF2 gehashtes Passwort mit Salt
    /// </summary>
    public string PasswordHash { get; set; } = string.Empty;

    /// <summary>
    /// Benutzerrolle (Bediener, Einrichter, Admin)
    /// </summary>
    public UserRole Role { get; set; }

    /// <summary>
    /// Optionaler Anzeigename
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gehashter RFID/NFC Tag für kontaktlose Anmeldung
    /// </summary>
    public string? RfidTag { get; set; }

    /// <summary>
    /// Gibt an, ob der Benutzer aktiv ist
    /// </summary>
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Erstellungszeitpunkt (UTC)
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Letzter Anmeldezeitpunkt (UTC)
    /// </summary>
    public DateTime? LastLoginAt { get; set; }

    /// <summary>
    /// Navigations-Property für Aktionsprotokolle
    /// </summary>
    public ICollection<UserActionLog> ActionLogs { get; set; } = new List<UserActionLog>();
}
