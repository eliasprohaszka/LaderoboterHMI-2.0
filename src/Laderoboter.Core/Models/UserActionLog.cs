namespace Laderoboter.Core.Models;

/// <summary>
/// Protokolliert Benutzeraktionen für Audit-Trail
/// </summary>
public class UserActionLog
{
    public int Id { get; set; }

    /// <summary>
    /// Fremdschlüssel zum Benutzer (nullable für gelöschte Benutzer)
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Navigation zum Benutzer
    /// </summary>
    public User? User { get; set; }

    /// <summary>
    /// Denormalisierte Personalnummer für historische Protokolle
    /// </summary>
    public string? PersonalNumber { get; set; }

    /// <summary>
    /// Durchgeführte Aktion (z.B. "Login", "Logout", "Benutzer angelegt")
    /// </summary>
    public string Action { get; set; } = string.Empty;

    /// <summary>
    /// Optionale Details zur Aktion
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// Optionale IP-Adresse
    /// </summary>
    public string? IpAddress { get; set; }

    /// <summary>
    /// Zeitstempel der Aktion (UTC)
    /// </summary>
    public DateTime Timestamp { get; set; }
}
