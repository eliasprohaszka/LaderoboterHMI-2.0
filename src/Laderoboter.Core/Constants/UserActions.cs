namespace Laderoboter.Core.Constants;

/// <summary>
/// Konstanten für Benutzeraktions-Protokollierung
/// </summary>
public static class UserActions
{
    // Authentifizierung
    public const string Login = "Login";
    public const string Logout = "Logout";

    // Werkstückträger Status
    public const string WorkpieceStateChanged = "WorkpieceStateChanged";
    public const string PaletteReset = "PaletteReset";
    public const string ShelfWorkpieceStateChanged = "ShelfWorkpieceStateChanged";
    public const string ShelfReset = "ShelfReset";

    // Werkstückträger Be-/Entladung
    public const string ShelfLoad = "ShelfLoad";
    public const string ShelfUnload = "ShelfUnload";

    // Fehlerbehandlung
    public const string ErrorCleared = "ErrorCleared";
    public const string ErrorViewed = "ErrorViewed";

    // Paletten Wechselmodus
    public const string PaletteModeChangeStarted = "PaletteModeChangeStarted";
    public const string PaletteModeChangeCompleted = "PaletteModeChangeCompleted";
    public const string PaletteModeChangeEnded = "PaletteModeChangeEnded";

    // HMI Sprache
    public const string LanguageChanged = "LanguageChanged";

    // Roboter Verbindung
    public const string RobotConnected = "RobotConnected";
    public const string RobotDisconnected = "RobotDisconnected";

    // Benutzerverwaltung
    public const string UserCreated = "UserCreated";
    public const string UserUpdated = "UserUpdated";
    public const string UserDeleted = "UserDeleted";
    public const string UsersImported = "UsersImported";
    public const string UsersExported = "UsersExported";

    // Übersetzungen
    public const string TranslationUpdated = "TranslationUpdated";
    public const string TranslationAdded = "TranslationAdded";
    public const string TranslationsImported = "TranslationsImported";
    public const string TranslationsExported = "TranslationsExported";

    // Sprachen
    public const string LanguageAdded = "LanguageAdded";
    public const string LanguageDeleted = "LanguageDeleted";
    public const string LanguageUpdated = "LanguageUpdated";

    // Maintenance Seite
    public const string MaintenancePageEntered = "MaintenancePageEntered";
    public const string MaintenancePageExited = "MaintenancePageExited";
    public const string LayDown = "LayDown";
    public const string PickUp = "PickUp";
    public const string GoToHome = "GoToHome";
    public const string MaintenanceDoorToggled = "MaintenanceDoorToggled";
    public const string LoadDoorOpened = "LoadDoorOpened";
    public const string LoadDoorClosed = "LoadDoorClosed";
    public const string PaletteDoorToggled = "PaletteDoorToggled";
    public const string IoSignalsViewed = "IoSignalsViewed";
    public const string PcShutdown = "PcShutdown";
    public const string PcRestart = "PcRestart";
    public const string PcShutdownCancelled = "PcShutdownCancelled";

    // Programm Steuerung
    public const string ProgramStarted = "ProgramStarted";
    public const string ProgramStopped = "ProgramStopped";
    public const string ProgramPaused = "ProgramPaused";
    public const string ProgramResumed = "ProgramResumed";
    public const string AutostopStarted = "AutostopStarted";
    public const string SystemReset = "SystemReset";

    // Einstellungen
    public const string SettingsChanged = "SettingsChanged";
    public const string SettingsImported = "SettingsImported";
    public const string SettingsExported = "SettingsExported";
}
