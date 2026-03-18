namespace Laderoboter.Core.Models;

/// <summary>
/// Benutzerrollen für die Anwendung
/// </summary>
public enum UserRole
{
    /// <summary>
    /// Bediener - Nur Hauptseite, keine Navigation zu anderen Seiten
    /// </summary>
    Bediener = 1,

    /// <summary>
    /// Einrichter - Hauptseite, Wartung, Einstellungen (keine Benutzerverwaltung, Protokoll, Übersetzungen)
    /// </summary>
    Einrichter = 2,

    /// <summary>
    /// Admin - Volle Berechtigungen außer I/O Signale ändern
    /// </summary>
    Admin = 3,

    /// <summary>
    /// GH Admin - Volle Berechtigungen inkl. I/O Signale ändern
    /// </summary>
    GHAdmin = 4
}
