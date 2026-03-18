using Laderoboter.Core.Models;

namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für Benutzerautorisierung
/// </summary>
public interface IAuthorizationService
{
    /// <summary>
    /// Prüft, ob der aktuelle Benutzer die erforderliche Rolle hat
    /// </summary>
    bool HasRole(UserRole requiredRole);

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer GH Admin ist
    /// </summary>
    bool IsGHAdmin();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer Admin oder höher ist
    /// </summary>
    bool IsAdmin();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer Einrichter oder höher ist
    /// </summary>
    bool IsEinrichter();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer Bediener oder höher ist
    /// </summary>
    bool IsBediener();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer I/O Signale ändern darf (nur GH Admin)
    /// </summary>
    bool CanEditIO();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer auf Wartungsseite zugreifen darf (Einrichter oder höher)
    /// </summary>
    bool CanAccessMaintenance();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer auf Einstellungen zugreifen darf (Einrichter oder höher)
    /// </summary>
    bool CanAccessSettings();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer auf Benutzerverwaltung zugreifen darf (Admin oder höher)
    /// </summary>
    bool CanAccessUserManagement();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer auf Protokoll zugreifen darf (Admin oder höher)
    /// </summary>
    bool CanAccessActionLog();

    /// <summary>
    /// Prüft, ob der aktuelle Benutzer auf Übersetzungen zugreifen darf (Admin oder höher)
    /// </summary>
    bool CanAccessTranslations();

    /// <summary>
    /// Gibt die aktuelle Benutzerrolle zurück
    /// </summary>
    UserRole? CurrentUserRole { get; }

    /// <summary>
    /// Event bei Änderung der Rolle
    /// </summary>
    event EventHandler<UserRole?>? OnRoleChanged;
}
