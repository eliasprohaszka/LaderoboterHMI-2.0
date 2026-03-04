using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Data;

public static class SettingsSeeder
{
    /// <summary>
    /// Seeds default settings at runtime (not via migrations).
    /// Call this after EnsureCreated/Migrate.
    /// </summary>
    public static async Task SeedAsync(LaderoboterDbContext context)
    {
        var now = DateTime.UtcNow;

        var existingKeys = (await context.Settings
            .Select(s => s.SettingKey)
            .ToListAsync())
            .ToHashSet();

        var defaults = GetDefaultSettings();
        var toAdd = new List<Setting>();

        foreach (var setting in defaults)
        {
            if (!existingKeys.Contains(setting.Key))
            {
                toAdd.Add(new Setting
                {
                    SettingKey = setting.Key,
                    SettingValue = setting.Value,
                    ValueType = setting.ValueType,
                    Category = setting.Category,
                    Description = setting.Description,
                    DefaultValue = setting.Value,
                    IsSystemSetting = setting.IsSystem,
                    CreatedAt = now,
                    UpdatedAt = now
                });
            }
        }

        if (toAdd.Count > 0)
        {
            context.Settings.AddRange(toAdd);
            await context.SaveChangesAsync();
        }
    }

    private static List<(string Key, string Value, string ValueType, string Category, string Description, bool IsSystem)> GetDefaultSettings()
    {
        return
        [
            // Robot Connection
            ("robot.connection.ip", "192.168.1.1", "string", "robot", "IP-Adresse des FANUC Roboters", false),
            ("robot.connection.timeout", "2000", "number", "robot", "Verbindungs-Timeout in Millisekunden", true),
            ("robot.connection.autoConnect", "false", "boolean", "robot", "Automatische Verbindung beim Start", false),

            // Monitoring
            ("monitoring.updateInterval", "500", "number", "monitoring", "Update-Intervall für Register-Polling in ms", true),

            // UI
            ("ui.language", "de", "string", "ui", "Sprache der Benutzeroberfläche", false),
            ("ui.theme", "light", "string", "ui", "Theme der Benutzeroberfläche", false),

            // Logging
            ("logging.maxErrorLogDays", "90", "number", "logging", "Maximale Aufbewahrungszeit für Fehlerprotokolle in Tagen", true)
        ];
    }
}
