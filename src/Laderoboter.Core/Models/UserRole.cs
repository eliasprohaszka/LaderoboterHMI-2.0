namespace Laderoboter.Core.Models;

/// <summary>
/// Benutzerrollen für die Anwendung
/// </summary>
public enum UserRole
{
    /// <summary>
    /// Bediener - Grundlegende Berechtigungen
    /// </summary>
    Bediener = 1,

    /// <summary>
    /// Einrichter - Erweiterte Berechtigungen
    /// </summary>
    Einrichter = 2,

    /// <summary>
    /// Admin - Volle Berechtigungen inkl. Benutzerverwaltung
    /// </summary>
    Admin = 3
}
