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
    /// Prüft, ob der aktuelle Benutzer Admin ist
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
    /// Gibt die aktuelle Benutzerrolle zurück
    /// </summary>
    UserRole? CurrentUserRole { get; }

    /// <summary>
    /// Event bei Änderung der Rolle
    /// </summary>
    event EventHandler<UserRole?>? OnRoleChanged;
}
