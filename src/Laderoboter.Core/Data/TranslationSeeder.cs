using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Data;

public static class TranslationSeeder
{
    public static void SeedLanguagesAndTranslations(ModelBuilder modelBuilder)
    {
        var now = DateTime.UtcNow;

        // Seed Languages
        var languages = new List<Language>
        {
            new() { Id = 1, Code = "de", Name = "German", NativeName = "Deutsch", IsActive = true, SortOrder = 1, CreatedAt = now, UpdatedAt = now },
            new() { Id = 2, Code = "en", Name = "English", NativeName = "English", IsActive = true, SortOrder = 2, CreatedAt = now, UpdatedAt = now }
        };

        modelBuilder.Entity<Language>().HasData(languages);

        // Seed Translations
        var translations = new List<Translation>();
        int id = 1;

        // Helper function to add translation pair
        void AddTranslation(string key, string de, string en, string? category = null)
        {
            translations.Add(new Translation { Id = id++, Key = key, Value = de, LanguageId = 1, Category = category, CreatedAt = now, UpdatedAt = now });
            translations.Add(new Translation { Id = id++, Key = key, Value = en, LanguageId = 2, Category = category, CreatedAt = now, UpdatedAt = now });
        }

        // === Common / Shared ===
        AddTranslation("common.cancel", "Abbrechen", "Cancel", "common");
        AddTranslation("common.confirm", "Bestätigen", "Confirm", "common");
        AddTranslation("common.save", "Speichern", "Save", "common");
        AddTranslation("common.reset", "Zurücksetzen", "Reset", "common");
        AddTranslation("common.close", "Schließen", "Close", "common");
        AddTranslation("common.ok", "OK", "OK", "common");
        AddTranslation("common.yes", "Ja", "Yes", "common");
        AddTranslation("common.no", "Nein", "No", "common");
        AddTranslation("common.error", "Fehler", "Error", "common");
        AddTranslation("common.warning", "Warnung", "Warning", "common");
        AddTranslation("common.info", "Information", "Information", "common");
        AddTranslation("common.understood", "Verstanden", "Understood", "common");
        AddTranslation("common.loading", "Laden...", "Loading...", "common");
        AddTranslation("common.connected", "Verbunden", "Connected", "common");
        AddTranslation("common.disconnected", "Getrennt", "Disconnected", "common");
        AddTranslation("common.notConnected", "Nicht verbunden", "Not connected", "common");
        AddTranslation("common.version", "Version", "Version", "common");

        // === Header ===
        AddTranslation("header.title", "Laderoboter HMI", "Loading Robot HMI", "header");
        AddTranslation("header.subtitle", "Flachschleifmaschine FS 840", "Surface Grinding Machine FS 840", "header");
        AddTranslation("header.systemStatus", "SYSTEM STATUS", "SYSTEM STATUS", "header");
        AddTranslation("header.currentTime", "AKTUELLE ZEIT", "CURRENT TIME", "header");
        AddTranslation("header.robot", "Robot", "Robot", "header");
        AddTranslation("header.cnc", "CNC", "CNC", "header");
        AddTranslation("header.showRobotError", "Roboterfehler anzeigen", "Show robot error", "header");
        AddTranslation("header.dashboard", "Dashboard", "Dashboard", "header");
        AddTranslation("header.settings", "Einstellungen", "Settings", "header");
        AddTranslation("header.maintenance", "Wartung", "Maintenance", "header");

        // === Connection Dialog (MainPage) ===
        AddTranslation("connection.title", "Roboterverbindung", "Robot Connection", "connection");
        AddTranslation("connection.description", "Bitte verbinden Sie sich mit dem FANUC Roboter, um fortzufahren.", "Please connect to the FANUC robot to continue.", "connection");
        AddTranslation("connection.offlineMode", "Offline-Modus (RoboGuide)", "Offline Mode (RoboGuide)", "connection");
        AddTranslation("connection.roboGuidePath", "RoboGuide Pfad", "RoboGuide Path", "connection");
        AddTranslation("connection.roboGuidePathPlaceholder", "z.B. C:\\Workcells\\Robot_1", "e.g. C:\\Workcells\\Robot_1", "connection");
        AddTranslation("connection.ipAddress", "IP-Adresse", "IP Address", "connection");
        AddTranslation("connection.ipAddressPlaceholder", "z.B. 192.168.1.1", "e.g. 192.168.1.1", "connection");
        AddTranslation("connection.autoConnect", "Automatisch verbinden", "Auto-connect", "connection");
        AddTranslation("connection.connecting", "Verbinde...", "Connecting...", "connection");
        AddTranslation("connection.connect", "Verbinden", "Connect", "connection");
        AddTranslation("connection.disconnect", "Trennen", "Disconnect", "connection");
        AddTranslation("connection.connectionFailed", "Verbindung fehlgeschlagen", "Connection failed", "connection");

        // === Palette Overview ===
        AddTranslation("palette.overview", "Palettenübersicht", "Palette Overview", "palette");
        AddTranslation("palette.overviewDescription", "Status und Steuerung der Werkstücke", "Workpiece status and control", "palette");
        AddTranslation("palette.palette1", "Palette 1", "Palette 1", "palette");
        AddTranslation("palette.palette2", "Palette 2", "Palette 2", "palette");
        AddTranslation("palette.resetAll", "Alle zurücksetzen", "Reset all", "palette");
        AddTranslation("palette.changesBeingProcessed", "Änderungen werden verarbeitet", "Changes being processed", "palette");

        // === Program Control ===
        AddTranslation("program.autostart", "Autostart", "Autostart", "program");
        AddTranslation("program.running", "Läuft...", "Running...", "program");
        AddTranslation("program.autostop", "Autostop", "Autostop", "program");
        AddTranslation("program.stopping", "Stoppt...", "Stopping...", "program");
        AddTranslation("program.pause", "Pause", "Pause", "program");
        AddTranslation("program.resume", "Fortsetzen", "Resume", "program");
        AddTranslation("program.stop", "Stop", "Stop", "program");
        AddTranslation("program.reset", "Reset", "Reset", "program");

        // === Speed Override ===
        AddTranslation("speed.title", "Geschwindigkeit", "Speed", "speed");
        AddTranslation("speed.description", "Geschwindigkeit des Roboters einstellen", "Set robot speed", "speed");
        AddTranslation("speed.collapse", "Einklappen", "Collapse", "speed");

        // === Workpiece States ===
        AddTranslation("workpiece.empty", "Leer", "Empty", "workpiece");
        AddTranslation("workpiece.locked", "Gesperrt", "Locked", "workpiece");
        AddTranslation("workpiece.ready", "Bereit", "Ready", "workpiece");
        AddTranslation("workpiece.processed", "Bearbeitet", "Processed", "workpiece");
        AddTranslation("workpiece.atRobot", "Am Roboter", "At Robot", "workpiece");
        AddTranslation("workpiece.inMachine", "In Maschine", "In Machine", "workpiece");
        AddTranslation("workpiece.unknown", "Unbekannt", "Unknown", "workpiece");
        AddTranslation("workpiece.currentStatus", "Aktueller Status", "Current status", "workpiece");

        // === Workpiece Context Menu ===
        AddTranslation("workpieceMenu.lock", "Sperren", "Lock", "workpieceMenu");
        AddTranslation("workpieceMenu.lockDescription", "Position für Bearbeitung sperren", "Lock position for processing", "workpieceMenu");
        AddTranslation("workpieceMenu.reset", "Zurücksetzen", "Reset", "workpieceMenu");
        AddTranslation("workpieceMenu.resetDescription", "Als unbearbeitet markieren", "Mark as unprocessed", "workpieceMenu");
        AddTranslation("workpieceMenu.complete", "Fertig", "Complete", "workpieceMenu");
        AddTranslation("workpieceMenu.completeDescription", "Als bearbeitet markieren", "Mark as processed", "workpieceMenu");

        // === Change Mode ===
        AddTranslation("changeMode.activate", "Wechselmodus aktivieren", "Activate Change Mode", "changeMode");
        AddTranslation("changeMode.end", "Wechselmodus beenden", "End Change Mode", "changeMode");
        AddTranslation("changeMode.title", "Wechselmodus", "Change Mode", "changeMode");
        AddTranslation("changeMode.pleaseWait", "Bitte warten...", "Please wait...", "changeMode");
        AddTranslation("changeMode.activatingFor", "Wechselmodus für Palette {0} wird aktiviert...", "Activating change mode for palette {0}...", "changeMode");
        AddTranslation("changeMode.endingFor", "Wechselmodus für Palette {0} wird beendet...", "Ending change mode for palette {0}...", "changeMode");
        AddTranslation("changeMode.inProgress", "Wechsel läuft (Schritt {0})", "Change in progress (Step {0})", "changeMode");
        AddTranslation("changeMode.start", "Wechselmodus starten", "Start Change Mode", "changeMode");
        AddTranslation("changeMode.confirmQuestion", "Möchten Sie den Wechselmodus für Palette {0} aktivieren?", "Do you want to activate change mode for palette {0}?", "changeMode");
        AddTranslation("changeMode.endQuestion", "Möchten Sie den Wechselmodus für Palette {0} beenden?", "Do you want to end change mode for palette {0}?", "changeMode");
        AddTranslation("changeMode.note", "Hinweis:", "Note:", "changeMode");
        AddTranslation("changeMode.robotGoesHome", "Der Roboter fährt in die Home-Position", "The robot moves to home position", "changeMode");
        AddTranslation("changeMode.doorReleased", "Die Tür wird freigegeben", "The door is released", "changeMode");
        AddTranslation("changeMode.workpiecesLocked", "Alle Werkstücke werden gesperrt", "All workpieces are locked", "changeMode");
        AddTranslation("changeMode.doorMustBeClosed", "Die Tür muss geschlossen sein", "The door must be closed", "changeMode");
        AddTranslation("changeMode.paletteActivated", "Die Palette wird wieder aktiviert", "The palette is reactivated", "changeMode");
        AddTranslation("changeMode.robotCanAccess", "Der Roboter kann wieder auf die Palette zugreifen", "The robot can access the palette again", "changeMode");
        AddTranslation("changeMode.error", "Fehler beim Wechselmodus", "Change Mode Error", "changeMode");

        // === Change Mode Progress Steps ===
        AddTranslation("changeMode.step.checkNextPickup", "Prüfe NEXT_PICK_UP Register", "Check NEXT_PICK_UP register", "changeMode");
        AddTranslation("changeMode.step.resetRegister", "Setze Register zurück", "Reset register", "changeMode");
        AddTranslation("changeMode.step.setChangeRegister", "Setze CHANGE Register", "Set CHANGE register", "changeMode");
        AddTranslation("changeMode.step.waitDoorClose", "Warte auf Türschließung", "Waiting for door to close", "changeMode");
        AddTranslation("changeMode.step.activatePalette", "Aktiviere Palette", "Activate palette", "changeMode");
        AddTranslation("changeMode.step.checkCriticalStatus", "Prüfe kritische Werkstückstatus", "Check critical workpiece status", "changeMode");
        AddTranslation("changeMode.step.checkPickup", "Prüfe PICK_UP Register", "Check PICK_UP register", "changeMode");
        AddTranslation("changeMode.step.setChangeWaitDoor", "Setze CHANGE Register und warte auf Türfreigabe", "Set CHANGE register and wait for door release", "changeMode");
        AddTranslation("changeMode.step.lockWorkpieces", "Sperre Werkstücke", "Lock workpieces", "changeMode");
        AddTranslation("changeMode.step.activateChangeMode", "Aktiviere Wechselmodus", "Activate change mode", "changeMode");

        // === Settings Page ===
        AddTranslation("settings.title", "Einstellungen", "Settings", "settings");
        AddTranslation("settings.description", "Anwendungskonfiguration und Systemeinstellungen", "Application configuration and system settings", "settings");
        AddTranslation("settings.export", "Exportieren", "Export", "settings");
        AddTranslation("settings.import", "Importieren", "Import", "settings");

        // === Robot Settings ===
        AddTranslation("settings.robot.title", "Roboter-Verbindung", "Robot Connection", "settings");
        AddTranslation("settings.robot.ipAddress", "IP-Adresse", "IP Address", "settings");
        AddTranslation("settings.robot.offlineMode", "Offline-Modus (RoboGuide)", "Offline Mode (RoboGuide)", "settings");
        AddTranslation("settings.robot.roboGuidePath", "RoboGuide Pfad", "RoboGuide Path", "settings");
        AddTranslation("settings.robot.autoConnect", "Auto-Verbindung", "Auto-Connect", "settings");

        // === Language & Display Settings ===
        AddTranslation("settings.language.title", "Sprache & Anzeige", "Language & Display", "settings");
        AddTranslation("settings.language.language", "Sprache", "Language", "settings");
        AddTranslation("settings.language.german", "Deutsch", "German", "settings");
        AddTranslation("settings.language.english", "English", "English", "settings");
        AddTranslation("settings.language.updateInterval", "Update-Intervall (ms)", "Update Interval (ms)", "settings");
        AddTranslation("settings.language.manageTranslations", "Übersetzungen verwalten", "Manage Translations", "settings");

        // === Translations Page ===
        AddTranslation("translations.title", "Übersetzungen", "Translations", "translations");
        AddTranslation("translations.description", "Sprachen und Übersetzungen verwalten", "Manage languages and translations", "translations");
        AddTranslation("translations.languages", "Sprachen", "Languages", "translations");
        AddTranslation("translations.translations", "Übersetzungen", "Translations", "translations");
        AddTranslation("translations.addLanguage", "Sprache hinzufügen", "Add Language", "translations");
        AddTranslation("translations.languageCode", "Sprachcode", "Language Code", "translations");
        AddTranslation("translations.languageName", "Sprachname", "Language Name", "translations");
        AddTranslation("translations.nativeName", "Eigenname", "Native Name", "translations");
        AddTranslation("translations.search", "Suchen...", "Search...", "translations");
        AddTranslation("translations.allCategories", "Alle Kategorien", "All Categories", "translations");
        AddTranslation("translations.missingOnly", "Nur fehlende", "Missing only", "translations");
        AddTranslation("translations.missing", "Fehlt", "Missing", "translations");
        AddTranslation("translations.noResults", "Keine Übersetzungen gefunden", "No translations found", "translations");
        AddTranslation("translations.export", "Exportieren", "Export", "translations");
        AddTranslation("translations.import", "Importieren", "Import", "translations");
        AddTranslation("translations.importTitle", "Übersetzungen importieren", "Import Translations", "translations");
        AddTranslation("translations.overwriteExisting", "Bestehende überschreiben", "Overwrite existing", "translations");

        // === Connection Status ===
        AddTranslation("settings.connection.title", "Verbindungsstatus", "Connection Status", "settings");
        AddTranslation("settings.connection.status", "Status", "Status", "settings");

        // === System Info ===
        AddTranslation("settings.system.title", "System-Information", "System Information", "settings");
        AddTranslation("settings.system.framework", "Framework", "Framework", "settings");
        AddTranslation("settings.system.database", "Datenbank", "Database", "settings");

        // === Maintenance Page ===
        AddTranslation("maintenance.title", "Wartung", "Maintenance", "maintenance");
        AddTranslation("maintenance.description", "Manuelle Steuerung und Wartungsoperationen", "Manual control and maintenance operations", "maintenance");

        // === Maintenance Actions ===
        AddTranslation("maintenance.layDown", "Werkstück ablegen", "Lay down workpiece", "maintenance");
        AddTranslation("maintenance.pickUp", "Werkstück abholen", "Pick up workpiece", "maintenance");
        AddTranslation("maintenance.homePosition", "Home Position", "Home Position", "maintenance");
        AddTranslation("maintenance.maintenanceDoor", "Wartungstür", "Maintenance Door", "maintenance");
        AddTranslation("maintenance.release", "Freigeben", "Release", "maintenance");
        AddTranslation("maintenance.loadDoor", "Ladetür", "Load Door", "maintenance");
        AddTranslation("maintenance.open", "Öffnen", "Open", "maintenance");
        AddTranslation("maintenance.close", "Schließen", "Close", "maintenance");
        AddTranslation("maintenance.paletteDoor1", "Palettentür 1", "Palette Door 1", "maintenance");
        AddTranslation("maintenance.paletteDoor2", "Palettentür 2", "Palette Door 2", "maintenance");
        AddTranslation("maintenance.ioSignals", "I/O Signale", "I/O Signals", "maintenance");
        AddTranslation("maintenance.clearError", "Fehler löschen", "Clear Error", "maintenance");
        AddTranslation("maintenance.noError", "Kein Fehler", "No Error", "maintenance");
        AddTranslation("maintenance.reset", "RESET", "RESET", "maintenance");
        AddTranslation("maintenance.programStop", "Programm STOP", "Program STOP", "maintenance");
        AddTranslation("maintenance.pcRestart", "PC Neustart", "PC Restart", "maintenance");
        AddTranslation("maintenance.pcShutdown", "PC Herunterfahren", "PC Shutdown", "maintenance");

        // === Maintenance Dialogs ===
        AddTranslation("maintenance.homeDialog.title", "Home Position", "Home Position", "maintenance");
        AddTranslation("maintenance.homeDialog.message", "Roboter zur Home-Position fahren?", "Move robot to home position?", "maintenance");
        AddTranslation("maintenance.homeDialog.confirm", "Fahren", "Move", "maintenance");

        AddTranslation("maintenance.pickUpDialog.title", "Werkstück abholen", "Pick Up Workpiece", "maintenance");
        AddTranslation("maintenance.pickUpDialog.message", "Werkstück vom Greifer abholen?", "Pick up workpiece from gripper?", "maintenance");
        AddTranslation("maintenance.pickUpDialog.confirm", "Abholen", "Pick Up", "maintenance");

        AddTranslation("maintenance.layDownDialog.title", "Werkstück ablegen", "Lay Down Workpiece", "maintenance");
        AddTranslation("maintenance.layDownDialog.message", "Wählen Sie die Position, an der das Werkstück abgelegt werden soll.", "Select the position where the workpiece should be placed.", "maintenance");
        AddTranslation("maintenance.layDownDialog.selectLabel", "Werkstück auswählen", "Select workpiece", "maintenance");
        AddTranslation("maintenance.layDownDialog.confirmWithId", "Ablegen auf {0}", "Place at {0}", "maintenance");
        AddTranslation("maintenance.layDownDialog.confirm", "Ablegen", "Place", "maintenance");

        AddTranslation("maintenance.shutdownDialog.title", "PC Herunterfahren", "PC Shutdown", "maintenance");
        AddTranslation("maintenance.shutdownDialog.message", "Möchten Sie den PC wirklich herunterfahren?", "Do you really want to shut down the PC?", "maintenance");
        AddTranslation("maintenance.shutdownDialog.confirm", "Herunterfahren", "Shutdown", "maintenance");

        AddTranslation("maintenance.restartDialog.title", "PC Neustart", "PC Restart", "maintenance");
        AddTranslation("maintenance.restartDialog.message", "Möchten Sie den PC wirklich neu starten?", "Do you really want to restart the PC?", "maintenance");
        AddTranslation("maintenance.restartDialog.confirm", "Neustart", "Restart", "maintenance");

        AddTranslation("maintenance.shutdownCountdown.title", "PC wird heruntergefahren", "PC Shutting Down", "maintenance");
        AddTranslation("maintenance.shutdownCountdown.message", "System wird in {0} Sekunden heruntergefahren...", "System will shut down in {0} seconds...", "maintenance");

        AddTranslation("maintenance.restartCountdown.title", "PC wird neu gestartet", "PC Restarting", "maintenance");
        AddTranslation("maintenance.restartCountdown.message", "System wird in {0} Sekunden neu gestartet...", "System will restart in {0} seconds...", "maintenance");

        // === I/O Signals Dialog ===
        AddTranslation("io.title", "I/O Signale", "I/O Signals", "io");
        AddTranslation("io.description", "Digitale Ein- und Ausgänge des Roboters", "Digital inputs and outputs of the robot", "io");
        AddTranslation("io.digitalInputs", "Digitale Eingänge", "Digital Inputs", "io");
        AddTranslation("io.digitalOutputs", "Digitale Ausgänge", "Digital Outputs", "io");
        AddTranslation("io.doors", "Türen", "Doors", "io");
        AddTranslation("io.grinder", "Schleifmaschine", "Grinding Machine", "io");
        AddTranslation("io.doorSafety", "Türsicherheit", "Door Safety", "io");
        AddTranslation("io.safetySystem", "Sicherheitssystem", "Safety System", "io");
        AddTranslation("io.palettes", "Paletten", "Palettes", "io");
        AddTranslation("io.chuck", "Spannfutter", "Chuck", "io");
        AddTranslation("io.system", "System", "System", "io");
        AddTranslation("io.loadControl", "Ladesteuerung", "Load Control", "io");
        AddTranslation("io.doorControl", "Türsteuerung", "Door Control", "io");

        // === Error Dialog ===
        AddTranslation("error.title.info", "Information", "Information", "error");
        AddTranslation("error.title.warning", "Warnung", "Warning", "error");
        AddTranslation("error.title.error", "Fehler", "Error", "error");
        AddTranslation("error.title.critical", "Kritischer Fehler", "Critical Error", "error");
        AddTranslation("error.code", "Fehlercode", "Error code", "error");

        // === Confirmation Dialog Defaults ===
        AddTranslation("dialog.confirmation", "Bestätigung", "Confirmation", "dialog");
        AddTranslation("dialog.confirmMessage", "Möchten Sie fortfahren?", "Do you want to continue?", "dialog");

        // === Wait Messages ===
        AddTranslation("wait.doorRelease", "Warte auf Türfreigabe R[{0}] = {1} (erwartet: 1)", "Waiting for door release R[{0}] = {1} (expected: 1)", "wait");
        AddTranslation("wait.closeDoor", "Bitte Tür von Palette {0} schließen!", "Please close door of palette {0}!", "wait");
        AddTranslation("wait.doorStillReleased", "Tür von Palette {0} ist noch freigegeben!", "Door of palette {0} is still released!", "wait");

        // === Error Messages ===
        AddTranslation("error.changeModeNotPossible", "Wechselmodus nicht möglich: Werkstücke befinden sich in kritischem Zustand:", "Change mode not possible: Workpieces are in critical state:", "error");
        AddTranslation("error.waitForProcessing", "Bitte warten Sie, bis alle Werkstücke bearbeitet sind.", "Please wait until all workpieces are processed.", "error");
        AddTranslation("error.workpieceInPickup", "Wechselmodus nicht möglich: Werkstück der Palette {0} befindet sich im PICK_UP Register (R[46]).", "Change mode not possible: Workpiece of palette {0} is in PICK_UP register (R[46]).", "error");
        AddTranslation("error.waitForPickup", "Bitte warten Sie, bis der Pickup-Vorgang abgeschlossen ist.", "Please wait until the pickup process is complete.", "error");
        AddTranslation("error.setChangeRegister", "Fehler beim Setzen des CHANGE_PAL_{0} Registers", "Error setting CHANGE_PAL_{0} register", "error");
        AddTranslation("error.doorTimeout", "Timeout: DOOR_PAL_{0}_UNLOD wurde nicht innerhalb von {1}ms freigegeben", "Timeout: DOOR_PAL_{0}_UNLOD was not released within {1}ms", "error");

        // === Footer ===
        AddTranslation("footer.copyright", "© 2025 Geibel & Hotz GmbH", "© 2025 Geibel & Hotz GmbH", "footer");

        // === Slide to Delete ===
        AddTranslation("common.slideToDelete", "Zum Löschen schieben", "Slide to delete", "common");
        AddTranslation("common.confirmed", "Bestätigt", "Confirmed", "common");
        AddTranslation("translations.deleteLanguage", "Sprache löschen", "Delete Language", "translations");
        AddTranslation("translations.deleteLanguageConfirm", "Möchten Sie diese Sprache wirklich löschen?", "Do you really want to delete this language?", "translations");

        // === Login Page ===
        AddTranslation("login.title", "Anmeldung", "Login", "login");
        AddTranslation("login.description", "Melden Sie sich an, um fortzufahren", "Sign in to continue", "login");
        AddTranslation("login.personalNumber", "Personalnummer", "Personal Number", "login");
        AddTranslation("login.personalNumberPlaceholder", "z.B. 001", "e.g. 001", "login");
        AddTranslation("login.password", "Passwort", "Password", "login");
        AddTranslation("login.passwordPlaceholder", "Passwort eingeben", "Enter password", "login");
        AddTranslation("login.login", "Anmelden", "Login", "login");
        AddTranslation("login.loggingIn", "Anmeldung...", "Logging in...", "login");
        AddTranslation("login.or", "oder", "or", "login");
        AddTranslation("login.nfcReady", "NFC-Leser bereit", "NFC reader ready", "login");
        AddTranslation("login.nfcHint", "Halten Sie Ihre Karte an den Leser", "Hold your card to the reader", "login");
        AddTranslation("login.nfcNotAvailable", "NFC-Leser nicht verfügbar", "NFC reader not available", "login");
        AddTranslation("login.invalidCredentials", "Ungültige Anmeldedaten", "Invalid credentials", "login");
        AddTranslation("login.loginFailed", "Anmeldung fehlgeschlagen", "Login failed", "login");

        // === Header User/Logout ===
        AddTranslation("header.logout", "Abmelden", "Logout", "header");
        AddTranslation("header.userManagement", "Benutzerverwaltung", "User Management", "header");

        // === Common ===
        AddTranslation("common.saving", "Speichern...", "Saving...", "common");
        AddTranslation("common.delete", "Löschen", "Delete", "common");
        AddTranslation("common.edit", "Bearbeiten", "Edit", "common");
        AddTranslation("common.add", "Hinzufügen", "Add", "common");
        AddTranslation("common.search", "Suchen", "Search", "common");
        AddTranslation("common.actions", "Aktionen", "Actions", "common");

        // === User Management ===
        AddTranslation("users.title", "Benutzerverwaltung", "User Management", "users");
        AddTranslation("users.description", "Benutzer verwalten und Berechtigungen zuweisen", "Manage users and assign permissions", "users");
        AddTranslation("users.addUser", "Benutzer hinzufügen", "Add User", "users");
        AddTranslation("users.editUser", "Benutzer bearbeiten", "Edit User", "users");
        AddTranslation("users.deleteUser", "Benutzer löschen", "Delete User", "users");
        AddTranslation("users.deleteUserConfirm", "Möchten Sie diesen Benutzer wirklich löschen?", "Do you really want to delete this user?", "users");
        AddTranslation("users.personalNumber", "Personalnummer", "Personal Number", "users");
        AddTranslation("users.name", "Name", "Name", "users");
        AddTranslation("users.role", "Rolle", "Role", "users");
        AddTranslation("users.rfidTag", "RFID-Tag", "RFID Tag", "users");
        AddTranslation("users.password", "Passwort", "Password", "users");
        AddTranslation("users.passwordHint", "Leer lassen, um das Passwort nicht zu ändern", "Leave empty to keep current password", "users");
        AddTranslation("users.isActive", "Aktiv", "Active", "users");
        AddTranslation("users.createdAt", "Erstellt am", "Created at", "users");
        AddTranslation("users.lastLogin", "Letzte Anmeldung", "Last Login", "users");
        AddTranslation("users.noUsers", "Keine Benutzer gefunden", "No users found", "users");
        AddTranslation("users.scanRfid", "RFID scannen", "Scan RFID", "users");
        AddTranslation("users.scanning", "Scanne...", "Scanning...", "users");
        AddTranslation("users.roles.bediener", "Bediener", "Operator", "users");
        AddTranslation("users.roles.einrichter", "Einrichter", "Setup", "users");
        AddTranslation("users.roles.admin", "Administrator", "Administrator", "users");
        AddTranslation("users.role.bediener", "Bediener", "Operator", "users");
        AddTranslation("users.role.einrichter", "Einrichter", "Setup", "users");
        AddTranslation("users.role.admin", "Administrator", "Administrator", "users");
        AddTranslation("users.noAccess", "Zugriff verweigert. Nur Administratoren können diese Seite sehen.", "Access denied. Only administrators can view this page.", "users");
        AddTranslation("users.add", "Benutzer hinzufügen", "Add User", "users");
        AddTranslation("users.status", "Status", "Status", "users");
        AddTranslation("users.rfid", "RFID", "RFID", "users");
        AddTranslation("users.actions", "Aktionen", "Actions", "users");
        AddTranslation("users.active", "Aktiv", "Active", "users");
        AddTranslation("users.inactive", "Inaktiv", "Inactive", "users");

        // === Action Log ===
        AddTranslation("actionLog.title", "Aktionsprotokoll", "Action Log", "actionLog");
        AddTranslation("actionLog.description", "Benutzeraktionen und Systemereignisse", "User actions and system events", "actionLog");
        AddTranslation("actionLog.user", "Benutzer", "User", "actionLog");
        AddTranslation("actionLog.action", "Aktion", "Action", "actionLog");
        AddTranslation("actionLog.details", "Details", "Details", "actionLog");
        AddTranslation("actionLog.timestamp", "Zeitstempel", "Timestamp", "actionLog");
        AddTranslation("actionLog.noLogs", "Keine Einträge gefunden", "No entries found", "actionLog");
        AddTranslation("actionLog.filterByUser", "Nach Benutzer filtern", "Filter by user", "actionLog");
        AddTranslation("actionLog.filterByAction", "Nach Aktion filtern", "Filter by action", "actionLog");
        AddTranslation("actionLog.allUsers", "Alle Benutzer", "All Users", "actionLog");
        AddTranslation("actionLog.allActions", "Alle Aktionen", "All Actions", "actionLog");
        AddTranslation("actionLog.systemAction", "Systemaktion", "System Action", "actionLog");
        AddTranslation("actionLog.entriesCount", "{0} Einträge", "{0} entries", "actionLog");

        modelBuilder.Entity<Translation>().HasData(translations);
    }
}
