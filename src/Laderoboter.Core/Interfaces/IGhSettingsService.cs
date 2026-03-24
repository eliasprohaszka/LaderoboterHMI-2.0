namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für GH-spezifische Einstellungen (nur für GH Admin zugänglich)
/// </summary>
public interface IGhSettingsService
{
    /// <summary>
    /// Event das ausgelöst wird, wenn sich die Einstellungen ändern
    /// </summary>
    event EventHandler? SettingsChanged;

    /// <summary>
    /// Jobliste aktiviert/deaktiviert
    /// </summary>
    bool IsJobListEnabled { get; }

    /// <summary>
    /// Regal Werkstückbearbeitung aktiviert/deaktiviert
    /// </summary>
    bool IsShelfWorkpieceEditingEnabled { get; }

    /// <summary>
    /// Regal Werkstückbearbeitung Offline-Modus (Änderungen nur lokal, nicht an Roboter senden)
    /// </summary>
    bool IsShelfWorkpieceEditingOffline { get; }

    /// <summary>
    /// Lädt die Einstellungen aus der Datenbank
    /// </summary>
    Task LoadAsync();

    /// <summary>
    /// Setzt ob die Jobliste aktiviert ist
    /// </summary>
    Task SetJobListEnabledAsync(bool enabled);

    /// <summary>
    /// Setzt ob die Regal Werkstückbearbeitung aktiviert ist
    /// </summary>
    Task SetShelfWorkpieceEditingEnabledAsync(bool enabled);

    /// <summary>
    /// Setzt ob die Regal Werkstückbearbeitung im Offline-Modus ist
    /// </summary>
    Task SetShelfWorkpieceEditingOfflineAsync(bool offline);
}
