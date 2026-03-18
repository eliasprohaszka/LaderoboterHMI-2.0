using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Data;

public static class TranslationSeeder
{
    /// <summary>
    /// Seeds translations at runtime (not via migrations).
    /// Call this after EnsureCreated/Migrate.
    /// </summary>
    public static async Task SeedAsync(LaderoboterDbContext context)
    {
        var now = DateTime.UtcNow;

        // Ensure languages exist
        if (!await context.Languages.AnyAsync())
        {
            context.Languages.AddRange(
                new Language { Code = "de", Name = "German", NativeName = "Deutsch", IsActive = true, SortOrder = 1, CreatedAt = now, UpdatedAt = now },
                new Language { Code = "en", Name = "English", NativeName = "English", IsActive = true, SortOrder = 2, CreatedAt = now, UpdatedAt = now }
            );
            await context.SaveChangesAsync();
        }

        var deLang = await context.Languages.FirstAsync(l => l.Code == "de");
        var enLang = await context.Languages.FirstAsync(l => l.Code == "en");

        // Get existing keys to avoid duplicates
        var existingKeys = await context.Translations
            .Select(t => new { t.Key, t.LanguageId })
            .ToListAsync();
        var existingSet = existingKeys.ToHashSet();

        var translations = GetTranslations();
        var toAdd = new List<Translation>();

        foreach (var (key, de, en, category) in translations)
        {
            if (!existingSet.Contains(new { Key = key, LanguageId = deLang.Id }))
            {
                toAdd.Add(new Translation { Key = key, Value = de, LanguageId = deLang.Id, Category = category, CreatedAt = now, UpdatedAt = now });
            }
            if (!existingSet.Contains(new { Key = key, LanguageId = enLang.Id }))
            {
                toAdd.Add(new Translation { Key = key, Value = en, LanguageId = enLang.Id, Category = category, CreatedAt = now, UpdatedAt = now });
            }
        }

        if (toAdd.Count > 0)
        {
            context.Translations.AddRange(toAdd);
            await context.SaveChangesAsync();
        }
    }

    private static List<(string Key, string De, string En, string? Category)> GetTranslations()
    {
        var translations = new List<(string, string, string, string?)>();

        void Add(string key, string de, string en, string? category = null)
            => translations.Add((key, de, en, category));

        // === Common / Shared ===
        Add("common.cancel", "Abbrechen", "Cancel", "common");
        Add("common.confirm", "Bestätigen", "Confirm", "common");
        Add("common.save", "Speichern", "Save", "common");
        Add("common.reset", "Zurücksetzen", "Reset", "common");
        Add("common.close", "Schließen", "Close", "common");
        Add("common.ok", "OK", "OK", "common");
        Add("common.yes", "Ja", "Yes", "common");
        Add("common.no", "Nein", "No", "common");
        Add("common.error", "Fehler", "Error", "common");
        Add("common.warning", "Warnung", "Warning", "common");
        Add("common.info", "Information", "Information", "common");
        Add("common.understood", "Verstanden", "Understood", "common");
        Add("common.loading", "Laden...", "Loading...", "common");
        Add("common.connected", "Verbunden", "Connected", "common");
        Add("common.disconnected", "Getrennt", "Disconnected", "common");
        Add("common.notConnected", "Nicht verbunden", "Not connected", "common");
        Add("common.version", "Version", "Version", "common");

        // === Header ===
        Add("header.title", "Laderoboter HMI", "Loading Robot HMI", "header");
        Add("header.subtitle", "Flachschleifmaschine FS 840", "Surface Grinding Machine FS 840", "header");
        Add("header.systemStatus", "SYSTEM STATUS", "SYSTEM STATUS", "header");
        Add("header.currentTime", "AKTUELLE ZEIT", "CURRENT TIME", "header");
        Add("header.robot", "Robot", "Robot", "header");
        Add("header.cnc", "CNC", "CNC", "header");
        Add("header.showRobotError", "Roboterfehler anzeigen", "Show robot error", "header");
        Add("header.dashboard", "Dashboard", "Dashboard", "header");
        Add("header.settings", "Einstellungen", "Settings", "header");
        Add("header.maintenance", "Wartung", "Maintenance", "header");

        // === Robot Alarms ===
        Add("alarm.title", "Roboter-Alarme", "Robot Alarms", "alarm");
        Add("alarm.noAlarms", "Keine aktiven Alarme", "No active alarms", "alarm");
        Add("alarm.currentAlarm", "Aktueller Alarm", "Current Alarm", "alarm");
        Add("alarm.history", "Alarm-Historie", "Alarm History", "alarm");
        Add("alarm.acknowledge", "Gesehen", "Acknowledge", "alarm");
        Add("alarm.acknowledged", "Gesehen", "Acknowledged", "alarm");
        Add("alarm.resetAlarms", "Alarme zurücksetzen", "Reset Alarms", "alarm");
        Add("alarm.resetting", "Zurücksetzen...", "Resetting...", "alarm");
        Add("alarm.reset", "Zurückgesetzt", "Reset", "alarm");
        Add("alarm.registerError", "Systemfehler", "System Error", "alarm");
        Add("alarm.systemAlarm", "FANUC Alarm", "FANUC Alarm", "alarm");
        Add("alarm.resetOnMaintenancePage", "Bitte auf Wartungsseite zurücksetzen", "Please reset on Maintenance page", "alarm");

        // === Connection Dialog (MainPage) ===
        Add("connection.title", "Roboterverbindung", "Robot Connection", "connection");
        Add("connection.description", "Bitte verbinden Sie sich mit dem FANUC Roboter, um fortzufahren.", "Please connect to the FANUC robot to continue.", "connection");
        Add("connection.offlineMode", "Offline-Modus (RoboGuide)", "Offline Mode (RoboGuide)", "connection");
        Add("connection.roboGuidePath", "RoboGuide Pfad", "RoboGuide Path", "connection");
        Add("connection.roboGuidePathPlaceholder", "z.B. C:\\Workcells\\Robot_1", "e.g. C:\\Workcells\\Robot_1", "connection");
        Add("connection.ipAddress", "IP-Adresse", "IP Address", "connection");
        Add("connection.ipAddressPlaceholder", "z.B. 192.168.1.1", "e.g. 192.168.1.1", "connection");
        Add("connection.autoConnect", "Automatisch verbinden", "Auto-connect", "connection");
        Add("connection.connecting", "Verbinde...", "Connecting...", "connection");
        Add("connection.connect", "Verbinden", "Connect", "connection");
        Add("connection.disconnect", "Trennen", "Disconnect", "connection");
        Add("connection.connectionFailed", "Verbindung fehlgeschlagen", "Connection failed", "connection");

        // === Palette Overview ===
        Add("palette.overview", "Palettenübersicht", "Palette Overview", "palette");
        Add("palette.overviewDescription", "Status und Steuerung der Werkstücke", "Workpiece status and control", "palette");
        Add("palette.palette1", "Palette 1", "Palette 1", "palette");
        Add("palette.palette2", "Palette 2", "Palette 2", "palette");
        Add("palette.resetAll", "Alle zurücksetzen", "Reset all", "palette");
        Add("palette.changesBeingProcessed", "Änderungen werden verarbeitet", "Changes being processed", "palette");

        // === Program Control ===
        Add("program.autostart", "Autostart", "Autostart", "program");
        Add("program.running", "Läuft...", "Running...", "program");
        Add("program.autostop", "Autostop", "Autostop", "program");
        Add("program.stopping", "Stoppt...", "Stopping...", "program");
        Add("program.pause", "Pause", "Pause", "program");
        Add("program.resume", "Fortsetzen", "Resume", "program");
        Add("program.stop", "Stop", "Stop", "program");
        Add("program.reset", "Reset", "Reset", "program");

        // === Speed Override ===
        Add("speed.title", "Geschwindigkeit", "Speed", "speed");
        Add("speed.description", "Geschwindigkeit des Roboters einstellen", "Set robot speed", "speed");
        Add("speed.collapse", "Einklappen", "Collapse", "speed");

        // === Workpiece States ===
        Add("workpiece.empty", "Leer", "Empty", "workpiece");
        Add("workpiece.locked", "Gesperrt", "Locked", "workpiece");
        Add("workpiece.ready", "Bereit", "Ready", "workpiece");
        Add("workpiece.processed", "Bearbeitet", "Processed", "workpiece");
        Add("workpiece.atRobot", "Am Roboter", "At Robot", "workpiece");
        Add("workpiece.inMachine", "In Maschine", "In Machine", "workpiece");
        Add("workpiece.unknown", "Unbekannt", "Unknown", "workpiece");
        Add("workpiece.currentStatus", "Aktueller Status", "Current status", "workpiece");

        // === Workpiece Context Menu ===
        Add("workpieceMenu.lock", "Sperren", "Lock", "workpieceMenu");
        Add("workpieceMenu.lockDescription", "Position für Bearbeitung sperren", "Lock position for processing", "workpieceMenu");
        Add("workpieceMenu.reset", "Zurücksetzen", "Reset", "workpieceMenu");
        Add("workpieceMenu.resetDescription", "Als unbearbeitet markieren", "Mark as unprocessed", "workpieceMenu");
        Add("workpieceMenu.complete", "Fertig", "Complete", "workpieceMenu");
        Add("workpieceMenu.completeDescription", "Als bearbeitet markieren", "Mark as processed", "workpieceMenu");

        // === Change Mode ===
        Add("changeMode.activate", "Wechselmodus aktivieren", "Activate Change Mode", "changeMode");
        Add("changeMode.end", "Wechselmodus beenden", "End Change Mode", "changeMode");
        Add("changeMode.title", "Wechselmodus", "Change Mode", "changeMode");
        Add("changeMode.pleaseWait", "Bitte warten...", "Please wait...", "changeMode");
        Add("changeMode.activatingFor", "Wechselmodus für Palette {0} wird aktiviert...", "Activating change mode for palette {0}...", "changeMode");
        Add("changeMode.endingFor", "Wechselmodus für Palette {0} wird beendet...", "Ending change mode for palette {0}...", "changeMode");
        Add("changeMode.inProgress", "Wechsel läuft (Schritt {0})", "Change in progress (Step {0})", "changeMode");
        Add("changeMode.start", "Wechselmodus starten", "Start Change Mode", "changeMode");
        Add("changeMode.confirmQuestion", "Möchten Sie den Wechselmodus für Palette {0} aktivieren?", "Do you want to activate change mode for palette {0}?", "changeMode");
        Add("changeMode.endQuestion", "Möchten Sie den Wechselmodus für Palette {0} beenden?", "Do you want to end change mode for palette {0}?", "changeMode");
        Add("changeMode.note", "Hinweis:", "Note:", "changeMode");
        Add("changeMode.robotGoesHome", "Der Roboter fährt in die Home-Position", "The robot moves to home position", "changeMode");
        Add("changeMode.doorReleased", "Die Tür wird freigegeben", "The door is released", "changeMode");
        Add("changeMode.workpiecesLocked", "Alle Werkstücke werden gesperrt", "All workpieces are locked", "changeMode");
        Add("changeMode.doorMustBeClosed", "Die Tür muss geschlossen sein", "The door must be closed", "changeMode");
        Add("changeMode.paletteActivated", "Die Palette wird wieder aktiviert", "The palette is reactivated", "changeMode");
        Add("changeMode.robotCanAccess", "Der Roboter kann wieder auf die Palette zugreifen", "The robot can access the palette again", "changeMode");
        Add("changeMode.error", "Fehler beim Wechselmodus", "Change Mode Error", "changeMode");

        // === Change Mode Progress Steps ===
        Add("changeMode.step.checkNextPickup", "Prüfe NEXT_PICK_UP Register", "Check NEXT_PICK_UP register", "changeMode");
        Add("changeMode.step.resetRegister", "Setze Register zurück", "Reset register", "changeMode");
        Add("changeMode.step.setChangeRegister", "Setze CHANGE Register", "Set CHANGE register", "changeMode");
        Add("changeMode.step.waitDoorClose", "Warte auf Türschließung", "Waiting for door to close", "changeMode");
        Add("changeMode.step.activatePalette", "Aktiviere Palette", "Activate palette", "changeMode");
        Add("changeMode.step.checkCriticalStatus", "Prüfe kritische Werkstückstatus", "Check critical workpiece status", "changeMode");
        Add("changeMode.step.checkPickup", "Prüfe PICK_UP Register", "Check PICK_UP register", "changeMode");
        Add("changeMode.step.setChangeWaitDoor", "Setze CHANGE Register und warte auf Türfreigabe", "Set CHANGE register and wait for door release", "changeMode");
        Add("changeMode.step.lockWorkpieces", "Sperre Werkstücke", "Lock workpieces", "changeMode");
        Add("changeMode.step.activateChangeMode", "Aktiviere Wechselmodus", "Activate change mode", "changeMode");

        // === Settings Page ===
        Add("settings.title", "Einstellungen", "Settings", "settings");
        Add("settings.description", "Anwendungskonfiguration und Systemeinstellungen", "Application configuration and system settings", "settings");
        Add("settings.export", "Exportieren", "Export", "settings");
        Add("settings.import", "Importieren", "Import", "settings");

        // === Settings Export ===
        Add("settings.export.success", "Export erfolgreich", "Export successful", "settings");
        Add("settings.export.successMessage", "Die Einstellungen wurden erfolgreich exportiert.", "Settings have been exported successfully.", "settings");
        Add("settings.export.error", "Export fehlgeschlagen", "Export failed", "settings");

        // === Settings Import ===
        Add("settings.import.confirmTitle", "Einstellungen importieren", "Import Settings", "settings");
        Add("settings.import.confirmMessage", "Achtung: Alle bestehenden Einstellungen werden durch den Import überschrieben!", "Warning: All existing settings will be overwritten by the import!", "settings");
        Add("settings.import.validFields", "Gültige Felder", "Valid fields", "settings");
        Add("settings.import.incompatibleFields", "Inkompatible Felder", "Incompatible fields", "settings");
        Add("settings.import.incompatibleNote", "Diese Felder existieren nicht in der Datenbank und werden übersprungen.", "These fields do not exist in the database and will be skipped.", "settings");
        Add("settings.import.backupHint", "Tipp: Exportieren Sie zuerst die aktuellen Einstellungen als Backup.", "Tip: Export the current settings first as a backup.", "settings");
        Add("settings.import.exportFirst", "Erst exportieren", "Export first", "settings");
        Add("settings.import.confirmImport", "Importieren", "Import", "settings");
        Add("settings.import.selectFile", "Datei auswählen", "Select file", "settings");
        Add("settings.import.proceedQuestion", "Möchten Sie den Import fortsetzen?", "Do you want to proceed with the import?", "settings");
        Add("settings.import.success", "Import erfolgreich", "Import successful", "settings");
        Add("settings.import.successMessage", "{0} Einstellungen wurden erfolgreich importiert.", "{0} settings have been imported successfully.", "settings");
        Add("settings.import.skippedFields", "{0} Felder wurden übersprungen:", "{0} fields were skipped:", "settings");
        Add("settings.import.error", "Import fehlgeschlagen", "Import failed", "settings");
        Add("settings.import.readError", "Datei konnte nicht gelesen werden", "Could not read file", "settings");

        // === Common ===
        Add("common.more", "weitere", "more", "common");

        // === Robot Settings ===
        Add("settings.robot.title", "Roboter-Verbindung", "Robot Connection", "settings");
        Add("settings.robot.ipAddress", "IP-Adresse", "IP Address", "settings");
        Add("settings.robot.offlineMode", "Offline-Modus (RoboGuide)", "Offline Mode (RoboGuide)", "settings");
        Add("settings.robot.roboGuidePath", "RoboGuide Pfad", "RoboGuide Path", "settings");
        Add("settings.robot.autoConnect", "Auto-Verbindung", "Auto-Connect", "settings");

        // === Language & Display Settings ===
        Add("settings.language.title", "Sprache & Anzeige", "Language & Display", "settings");
        Add("settings.language.language", "Sprache", "Language", "settings");
        Add("settings.language.german", "Deutsch", "German", "settings");
        Add("settings.language.english", "English", "English", "settings");
        Add("settings.language.updateInterval", "Update-Intervall (ms)", "Update Interval (ms)", "settings");
        Add("settings.language.manageTranslations", "Übersetzungen verwalten", "Manage Translations", "settings");

        // === Translations Page ===
        Add("translations.title", "Übersetzungen", "Translations", "translations");
        Add("translations.description", "Sprachen und Übersetzungen verwalten", "Manage languages and translations", "translations");
        Add("translations.languages", "Sprachen", "Languages", "translations");
        Add("translations.translations", "Übersetzungen", "Translations", "translations");
        Add("translations.addLanguage", "Sprache hinzufügen", "Add Language", "translations");
        Add("translations.languageCode", "Sprachcode", "Language Code", "translations");
        Add("translations.languageName", "Sprachname", "Language Name", "translations");
        Add("translations.nativeName", "Eigenname", "Native Name", "translations");
        Add("translations.search", "Suchen...", "Search...", "translations");
        Add("translations.allCategories", "Alle Kategorien", "All Categories", "translations");
        Add("translations.missingOnly", "Nur fehlende", "Missing only", "translations");
        Add("translations.missing", "Fehlt", "Missing", "translations");
        Add("translations.noResults", "Keine Übersetzungen gefunden", "No translations found", "translations");
        Add("translations.export", "Exportieren", "Export", "translations");
        Add("translations.import", "Importieren", "Import", "translations");
        Add("translations.importTitle", "Übersetzungen importieren", "Import Translations", "translations");
        Add("translations.overwriteExisting", "Bestehende überschreiben", "Overwrite existing", "translations");
        Add("translations.export.success", "Export erfolgreich", "Export successful", "translations");
        Add("translations.export.successMessage", "Die Übersetzungen wurden erfolgreich exportiert.", "Translations have been exported successfully.", "translations");
        Add("translations.export.error", "Export fehlgeschlagen", "Export failed", "translations");
        Add("translations.import.success", "Import erfolgreich", "Import successful", "translations");
        Add("translations.import.successMessage", "Die Übersetzungen wurden erfolgreich importiert.", "Translations have been imported successfully.", "translations");
        Add("translations.import.error", "Import fehlgeschlagen", "Import failed", "translations");
        Add("translations.import.confirmMessage", "Achtung: Übersetzungen werden importiert!", "Warning: Translations will be imported!", "translations");
        Add("translations.import.backupHint", "Tipp: Exportieren Sie zuerst die aktuellen Übersetzungen als Backup.", "Tip: Export the current translations first as a backup.", "translations");
        Add("translations.import.exportFirst", "Erst exportieren", "Export first", "translations");
        Add("translations.import.selectFile", "Datei auswählen", "Select file", "translations");
        Add("translations.import.confirmImport", "Importieren", "Import", "translations");

        // === Connection Status ===
        Add("settings.connection.title", "Verbindungsstatus", "Connection Status", "settings");
        Add("settings.connection.status", "Status", "Status", "settings");

        // === System Info ===
        Add("settings.system.title", "System-Information", "System Information", "settings");
        Add("settings.system.framework", "Framework", "Framework", "settings");
        Add("settings.system.database", "Datenbank", "Database", "settings");

        // === Maintenance Page ===
        Add("maintenance.title", "Wartung", "Maintenance", "maintenance");
        Add("maintenance.description", "Manuelle Steuerung und Wartungsoperationen", "Manual control and maintenance operations", "maintenance");

        // === Maintenance Actions ===
        Add("maintenance.layDown", "Werkstück ablegen", "Lay down workpiece", "maintenance");
        Add("maintenance.pickUp", "Werkstück abholen", "Pick up workpiece", "maintenance");
        Add("maintenance.homePosition", "Home Position", "Home Position", "maintenance");
        Add("maintenance.maintenanceDoor", "Wartungstür", "Maintenance Door", "maintenance");
        Add("maintenance.release", "Freigeben", "Release", "maintenance");
        Add("maintenance.loadDoor", "Ladetür", "Load Door", "maintenance");
        Add("maintenance.open", "Öffnen", "Open", "maintenance");
        Add("maintenance.close", "Schließen", "Close", "maintenance");
        Add("maintenance.paletteDoor1", "Palettentür 1", "Palette Door 1", "maintenance");
        Add("maintenance.paletteDoor2", "Palettentür 2", "Palette Door 2", "maintenance");
        Add("maintenance.ioSignals", "I/O Signale", "I/O Signals", "maintenance");
        Add("maintenance.clearError", "Fehler löschen", "Clear Error", "maintenance");
        Add("maintenance.noError", "Kein Fehler", "No Error", "maintenance");
        Add("maintenance.clearingError", "Fehler wird gelöscht...", "Clearing error...", "maintenance");
        Add("maintenance.reset", "RESET", "RESET", "maintenance");
        Add("maintenance.programStop", "Programm STOP", "Program STOP", "maintenance");
        Add("maintenance.pcRestart", "PC Neustart", "PC Restart", "maintenance");
        Add("maintenance.pcShutdown", "PC Herunterfahren", "PC Shutdown", "maintenance");

        // === Maintenance Dialogs ===
        Add("maintenance.homeDialog.title", "Home Position", "Home Position", "maintenance");
        Add("maintenance.homeDialog.message", "Roboter zur Home-Position fahren?", "Move robot to home position?", "maintenance");
        Add("maintenance.homeDialog.confirm", "Fahren", "Move", "maintenance");

        Add("maintenance.pickUpDialog.title", "Werkstück abholen", "Pick Up Workpiece", "maintenance");
        Add("maintenance.pickUpDialog.message", "Werkstück vom Greifer abholen?", "Pick up workpiece from gripper?", "maintenance");
        Add("maintenance.pickUpDialog.confirm", "Abholen", "Pick Up", "maintenance");

        Add("maintenance.layDownDialog.title", "Werkstück ablegen", "Lay Down Workpiece", "maintenance");
        Add("maintenance.layDownDialog.message", "Wählen Sie die Position, an der das Werkstück abgelegt werden soll.", "Select the position where the workpiece should be placed.", "maintenance");
        Add("maintenance.layDownDialog.selectLabel", "Werkstück auswählen", "Select workpiece", "maintenance");
        Add("maintenance.layDownDialog.confirmWithId", "Ablegen auf {0}", "Place at {0}", "maintenance");
        Add("maintenance.layDownDialog.confirm", "Ablegen", "Place", "maintenance");

        Add("maintenance.shutdownDialog.title", "PC Herunterfahren", "PC Shutdown", "maintenance");
        Add("maintenance.shutdownDialog.message", "Möchten Sie den PC wirklich herunterfahren?", "Do you really want to shut down the PC?", "maintenance");
        Add("maintenance.shutdownDialog.confirm", "Herunterfahren", "Shutdown", "maintenance");

        Add("maintenance.restartDialog.title", "PC Neustart", "PC Restart", "maintenance");
        Add("maintenance.restartDialog.message", "Möchten Sie den PC wirklich neu starten?", "Do you really want to restart the PC?", "maintenance");
        Add("maintenance.restartDialog.confirm", "Neustart", "Restart", "maintenance");

        Add("maintenance.shutdownCountdown.title", "PC wird heruntergefahren", "PC Shutting Down", "maintenance");
        Add("maintenance.shutdownCountdown.message", "System wird in {0} Sekunden heruntergefahren...", "System will shut down in {0} seconds...", "maintenance");

        Add("maintenance.restartCountdown.title", "PC wird neu gestartet", "PC Restarting", "maintenance");
        Add("maintenance.restartCountdown.message", "System wird in {0} Sekunden neu gestartet...", "System will restart in {0} seconds...", "maintenance");

        // === I/O Signals Dialog ===
        Add("io.title", "I/O Signale", "I/O Signals", "io");
        Add("io.description", "Digitale Ein- und Ausgänge des Roboters", "Digital inputs and outputs of the robot", "io");
        Add("io.digitalInputs", "Digitale Eingänge", "Digital Inputs", "io");
        Add("io.digitalOutputs", "Digitale Ausgänge", "Digital Outputs", "io");
        Add("io.doors", "Türen", "Doors", "io");
        Add("io.grinder", "Schleifmaschine", "Grinding Machine", "io");
        Add("io.doorSafety", "Türsicherheit", "Door Safety", "io");
        Add("io.safetySystem", "Sicherheitssystem", "Safety System", "io");
        Add("io.palettes", "Paletten", "Palettes", "io");
        Add("io.chuck", "Spannfutter", "Chuck", "io");
        Add("io.system", "System", "System", "io");
        Add("io.loadControl", "Ladesteuerung", "Load Control", "io");
        Add("io.doorControl", "Türsteuerung", "Door Control", "io");

        // === Error Dialog ===
        Add("error.title.info", "Information", "Information", "error");
        Add("error.title.warning", "Warnung", "Warning", "error");
        Add("error.title.error", "Fehler", "Error", "error");
        Add("error.title.critical", "Kritischer Fehler", "Critical Error", "error");
        Add("error.code", "Fehlercode", "Error code", "error");

        // === Confirmation Dialog Defaults ===
        Add("dialog.confirmation", "Bestätigung", "Confirmation", "dialog");
        Add("dialog.confirmMessage", "Möchten Sie fortfahren?", "Do you want to continue?", "dialog");

        // === Program Running Dialog ===
        Add("dialog.programRunning.title", "Programm läuft", "Program Running", "dialog");
        Add("dialog.programRunning.message", "Das Programm 'main' läuft noch. Um die Seite zu wechseln, muss das Programm zuerst gestoppt werden.", "The 'main' program is still running. To change the page, the program must be stopped first.", "dialog");
        Add("dialog.programRunning.stop", "Sofort stoppen", "Stop Now", "dialog");
        Add("dialog.programRunning.waitingForStop", "Warte auf Programm-Ende...", "Waiting for program to stop...", "dialog");

        // === Maintenance Exit Dialog ===
        Add("dialog.maintenanceExit.title", "Wartungsseite verlassen", "Leave Maintenance Page", "dialog");
        Add("dialog.maintenanceExit.message", "Wie möchten Sie die Paletten vorbereiten?", "How do you want to prepare the palettes?", "dialog");
        Add("dialog.maintenanceExit.justSwitch", "Nur wechseln", "Just switch", "dialog");
        Add("dialog.maintenanceExit.lockAll", "Alle sperren", "Lock all", "dialog");
        Add("dialog.maintenanceExit.resetAll", "Alle zurücksetzen", "Reset all", "dialog");
        Add("dialog.maintenanceExit.locking", "Sperren...", "Locking...", "dialog");
        Add("dialog.maintenanceExit.resetting", "Zurücksetzen...", "Resetting...", "dialog");

        // === Wait Messages ===
        Add("wait.doorRelease", "Warte auf Türfreigabe R[{0}] = {1} (erwartet: 1)", "Waiting for door release R[{0}] = {1} (expected: 1)", "wait");
        Add("wait.closeDoor", "Bitte Tür von Palette {0} schließen!", "Please close door of palette {0}!", "wait");
        Add("wait.doorStillReleased", "Tür von Palette {0} ist noch freigegeben!", "Door of palette {0} is still released!", "wait");

        // === Error Messages ===
        Add("error.changeModeNotPossible", "Wechselmodus nicht möglich: Werkstücke befinden sich in kritischem Zustand:", "Change mode not possible: Workpieces are in critical state:", "error");
        Add("error.waitForProcessing", "Bitte warten Sie, bis alle Werkstücke bearbeitet sind.", "Please wait until all workpieces are processed.", "error");
        Add("error.workpieceInPickup", "Wechselmodus nicht möglich: Werkstück der Palette {0} befindet sich im PICK_UP Register (R[46]).", "Change mode not possible: Workpiece of palette {0} is in PICK_UP register (R[46]).", "error");
        Add("error.waitForPickup", "Bitte warten Sie, bis der Pickup-Vorgang abgeschlossen ist.", "Please wait until the pickup process is complete.", "error");
        Add("error.setChangeRegister", "Fehler beim Setzen des CHANGE_PAL_{0} Registers", "Error setting CHANGE_PAL_{0} register", "error");
        Add("error.doorTimeout", "Timeout: DOOR_PAL_{0}_UNLOD wurde nicht innerhalb von {1}ms freigegeben", "Timeout: DOOR_PAL_{0}_UNLOD was not released within {1}ms", "error");

        // === Slide to Delete ===
        Add("common.slideToDelete", "Zum Löschen schieben", "Slide to delete", "common");
        Add("common.confirmed", "Bestätigt", "Confirmed", "common");
        Add("translations.deleteLanguage", "Sprache löschen", "Delete Language", "translations");
        Add("translations.deleteLanguageConfirm", "Möchten Sie diese Sprache wirklich löschen?", "Do you really want to delete this language?", "translations");

        // === Login Page ===
        Add("login.title", "Anmeldung", "Login", "login");
        Add("login.description", "Melden Sie sich an, um fortzufahren", "Sign in to continue", "login");
        Add("login.personalNumber", "Personalnummer", "Personal Number", "login");
        Add("login.personalNumberPlaceholder", "z.B. 001", "e.g. 001", "login");
        Add("login.password", "Passwort", "Password", "login");
        Add("login.passwordPlaceholder", "Passwort eingeben", "Enter password", "login");
        Add("login.login", "Anmelden", "Login", "login");
        Add("login.loggingIn", "Anmeldung...", "Logging in...", "login");
        Add("login.or", "oder", "or", "login");
        Add("login.nfcReady", "NFC-Leser bereit", "NFC reader ready", "login");
        Add("login.nfcHint", "Halten Sie Ihre Karte an den Leser", "Hold your card to the reader", "login");
        Add("login.nfcNotAvailable", "NFC-Leser nicht verfügbar", "NFC reader not available", "login");
        Add("login.invalidCredentials", "Ungültige Anmeldedaten", "Invalid credentials", "login");
        Add("login.loginFailed", "Anmeldung fehlgeschlagen", "Login failed", "login");

        // === Header User/Logout ===
        Add("header.logout", "Abmelden", "Logout", "header");
        Add("header.userManagement", "Benutzerverwaltung", "User Management", "header");

        // === Common ===
        Add("common.saving", "Speichern...", "Saving...", "common");
        Add("common.delete", "Löschen", "Delete", "common");
        Add("common.edit", "Bearbeiten", "Edit", "common");
        Add("common.add", "Hinzufügen", "Add", "common");
        Add("common.search", "Suchen", "Search", "common");
        Add("common.actions", "Aktionen", "Actions", "common");

        // === User Management ===
        Add("users.title", "Benutzerverwaltung", "User Management", "users");
        Add("users.description", "Benutzer verwalten und Berechtigungen zuweisen", "Manage users and assign permissions", "users");
        Add("users.addUser", "Benutzer hinzufügen", "Add User", "users");
        Add("users.editUser", "Benutzer bearbeiten", "Edit User", "users");
        Add("users.deleteUser", "Benutzer löschen", "Delete User", "users");
        Add("users.deleteUserConfirm", "Möchten Sie diesen Benutzer wirklich löschen?", "Do you really want to delete this user?", "users");
        Add("users.personalNumber", "Personalnummer", "Personal Number", "users");
        Add("users.name", "Name", "Name", "users");
        Add("users.role", "Rolle", "Role", "users");
        Add("users.rfidTag", "RFID-Tag", "RFID Tag", "users");
        Add("users.password", "Passwort", "Password", "users");
        Add("users.passwordHint", "Leer lassen, um das Passwort nicht zu ändern", "Leave empty to keep current password", "users");
        Add("users.isActive", "Aktiv", "Active", "users");
        Add("users.createdAt", "Erstellt am", "Created at", "users");
        Add("users.lastLogin", "Letzte Anmeldung", "Last Login", "users");
        Add("users.noUsers", "Keine Benutzer gefunden", "No users found", "users");
        Add("users.scanRfid", "RFID scannen", "Scan RFID", "users");
        Add("users.scanning", "Scanne...", "Scanning...", "users");
        Add("users.roles.bediener", "Bediener", "Operator", "users");
        Add("users.roles.einrichter", "Einrichter", "Setup", "users");
        Add("users.roles.admin", "Administrator", "Administrator", "users");
        Add("users.roles.ghadmin", "GH Administrator", "GH Administrator", "users");
        Add("users.role.bediener", "Bediener", "Operator", "users");
        Add("users.role.einrichter", "Einrichter", "Setup", "users");
        Add("users.role.admin", "Administrator", "Administrator", "users");
        Add("users.role.ghadmin", "GH Administrator", "GH Administrator", "users");
        Add("users.noAccess", "Zugriff verweigert. Nur Administratoren können diese Seite sehen.", "Access denied. Only administrators can view this page.", "users");
        Add("users.add", "Benutzer hinzufügen", "Add User", "users");
        Add("users.status", "Status", "Status", "users");
        Add("users.rfid", "RFID", "RFID", "users");
        Add("users.actions", "Aktionen", "Actions", "users");
        Add("users.active", "Aktiv", "Active", "users");
        Add("users.inactive", "Inaktiv", "Inactive", "users");
        Add("users.createTitle", "Benutzer erstellen", "Create User", "users");
        Add("users.editTitle", "Benutzer bearbeiten", "Edit User", "users");
        Add("users.scanNfc", "NFC scannen", "Scan NFC", "users");
        Add("users.scanningNfc", "Scanne NFC...", "Scanning NFC...", "users");
        Add("users.rfidAssigned", "RFID zugewiesen", "RFID assigned", "users");
        Add("users.rfidNew", "Neuer RFID", "New RFID", "users");
        Add("users.deleteTitle", "Benutzer löschen", "Delete User", "users");
        Add("users.deleteConfirm", "Möchten Sie den Benutzer {0} wirklich löschen?", "Do you really want to delete user {0}?", "users");
        Add("users.delete", "Löschen", "Delete", "users");
        Add("users.error.personalNumberRequired", "Personalnummer ist erforderlich", "Personal number is required", "users");
        Add("users.error.passwordRequired", "Passwort ist erforderlich", "Password is required", "users");

        // === User Export/Import ===
        Add("users.export", "Exportieren", "Export", "users");
        Add("users.import", "Importieren", "Import", "users");
        Add("users.export.success", "Export erfolgreich", "Export successful", "users");
        Add("users.export.successMessage", "Die Benutzer wurden erfolgreich exportiert.", "Users have been exported successfully.", "users");
        Add("users.export.error", "Export fehlgeschlagen", "Export failed", "users");
        Add("users.import.confirmTitle", "Benutzer importieren", "Import Users", "users");
        Add("users.import.confirmMessage", "Achtung: Bestehende Benutzer mit gleicher Personalnummer werden aktualisiert!", "Warning: Existing users with the same personal number will be updated!", "users");
        Add("users.import.backupHint", "Tipp: Exportieren Sie zuerst die aktuellen Benutzer als Backup.", "Tip: Export the current users first as a backup.", "users");
        Add("users.import.exportFirst", "Erst exportieren", "Export first", "users");
        Add("users.import.selectFile", "Datei auswählen", "Select file", "users");
        Add("users.import.newUsers", "Neue Benutzer", "New users", "users");
        Add("users.import.existingUsers", "Existierende Benutzer (werden aktualisiert)", "Existing users (will be updated)", "users");
        Add("users.import.warnings", "Warnungen", "Warnings", "users");
        Add("users.import.passwordNote", "Neue Benutzer erhalten ihre Personalnummer als Standardpasswort.", "New users will receive their personal number as default password.", "users");
        Add("users.import.proceedQuestion", "Möchten Sie den Import fortsetzen?", "Do you want to proceed with the import?", "users");
        Add("users.import.confirmImport", "Importieren", "Import", "users");
        Add("users.import.success", "Import erfolgreich", "Import successful", "users");
        Add("users.import.successMessage", "{0} Benutzer neu erstellt, {1} aktualisiert.", "{0} users created, {1} updated.", "users");
        Add("users.import.skippedUsers", "{0} Benutzer wurden übersprungen.", "{0} users were skipped.", "users");
        Add("users.import.error", "Import fehlgeschlagen", "Import failed", "users");
        Add("users.import.readError", "Datei konnte nicht gelesen werden", "Could not read file", "users");

        // === Action Log ===
        Add("actionLog.title", "Aktionsprotokoll", "Action Log", "actionLog");
        Add("actionLog.description", "Benutzeraktionen und Systemereignisse", "User actions and system events", "actionLog");
        Add("actionLog.user", "Benutzer", "User", "actionLog");
        Add("actionLog.action", "Aktion", "Action", "actionLog");
        Add("actionLog.details", "Details", "Details", "actionLog");
        Add("actionLog.timestamp", "Zeitstempel", "Timestamp", "actionLog");
        Add("actionLog.noLogs", "Keine Einträge gefunden", "No entries found", "actionLog");
        Add("actionLog.filterByUser", "Nach Benutzer filtern", "Filter by user", "actionLog");
        Add("actionLog.filterByAction", "Nach Aktion filtern", "Filter by action", "actionLog");
        Add("actionLog.allUsers", "Alle Benutzer", "All Users", "actionLog");
        Add("actionLog.allActions", "Alle Aktionen", "All Actions", "actionLog");
        Add("actionLog.systemAction", "Systemaktion", "System Action", "actionLog");
        Add("actionLog.entriesCount", "{0} Einträge", "{0} entries", "actionLog");

        // === Errors ===
        Add("errors.000", "Kein Fehler", "No Error", "errors");
        Add("errors.001", "Werkzeugträgerzustand ungültig", "Tool carrier state invalid", "errors");
        Add("errors.002", "Werkstücktäger an Roboter", "Workpiece carrier on robot", "errors");
        Add("errors.003", "Mehr als ein Werkstückträger in Maschine", "More than one workpiece carrier in machine", "errors");
        Add("errors.004", "Palette 1 nicht vorhanden / korrekt eingelegt es soll aber davon gegriffen bzw. abgelegt werden", "Palette 1 not present / correctly inserted but should be gripped or placed", "errors");
        Add("errors.005", "Palette 2 nicht vorhanden / korrekt eingelegt es soll aber davon gegriffen bzw. abgelegt werden", "Palette 2 not present / correctly inserted but should be gripped or placed", "errors");
        Add("errors.010", "Greifer öffnet nicht", "Gripper does not open", "errors");
        Add("errors.011", "Greifer schließt nicht", "Gripper does not close", "errors");
        Add("errors.012", "Werkstückträger nicht an Greifer vorhanden", "Workpiece carrier not present on gripper", "errors");
        Add("errors.013", "Spannsystem öffnet nicht", "Clamping system does not open", "errors");
        Add("errors.014", "Spannsystem schließt nicht", "Clamping system does not close", "errors");
        Add("errors.015", "Werkstückträger nicht in Spannsystem vorhanden", "Workpiece carrier not present in clamping system", "errors");
        Add("errors.016", "Schiebetür öffnet nicht", "Sliding door does not open", "errors");
        Add("errors.017", "Schiebetür schließt nicht", "Sliding door does not close", "errors");
        Add("errors.018", "Ablegeprogramm in Maschine angewählt aber Spannsystem belegt", "Deposit program in machine selected but clamping system occupied", "errors");
        Add("errors.019", "Abholprogramm aus Maschine angewählt aber Spannsystem nicht belegt", "Pick-up program from machine selected but clamping system not occupied", "errors");
        Add("errors.020", "GO TO HOME Fehler, Werkstückträgernummer ungültig", "GO TO HOME error, workpiece carrier number invalid", "errors");
        Add("errors.021", "Ablegeprogramm angewählt aber kein Werkstückträger an Greifer", "Deposit program selected but no workpiece carrier on gripper", "errors");
        Add("errors.022", "Abholprogramm angewählt aber Werkstückträger an Greifer", "Pick-up program selected but workpiece carrier on gripper", "errors");
        Add("errors.023", "Autostart angewählt aber Roboter nicht in Home Position", "Autostart selected but robot not in home position", "errors");
        Add("errors.030", "LUFTDRUCK zu niedrig (setzt sich selbstständig zurück)", "AIR PRESSURE too low (resets automatically)", "errors");
        Add("errors.040", "Kein Signal von Schleifmaschine (setzt sich selbstständig zurück)", "No signal from grinding machine (resets automatically)", "errors");
        Add("errors.041", "Störung Schleifmaschine (setzt sich selbstständig zurück)", "Grinding machine fault (resets automatically)", "errors");
        Add("errors.075", "Keine Ablageplatz für LAY_DOWN_UI definiert", "No deposit location defined for LAY_DOWN_UI", "errors");

        return translations;
    }
}
