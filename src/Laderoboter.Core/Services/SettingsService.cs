using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public class SettingsService : ISettingsService
{
    private readonly LaderoboterDbContext _context;
    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public SettingsService(LaderoboterDbContext context)
    {
        _context = context;
    }

    public async Task<string?> GetAsync(string key)
    {
        var setting = await _context.Settings
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.SettingKey == key);

        return setting?.SettingValue ?? setting?.DefaultValue;
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        var value = await GetAsync(key);
        if (string.IsNullOrEmpty(value))
            return default;

        try
        {
            if (typeof(T) == typeof(int))
                return (T)(object)int.Parse(value);
            if (typeof(T) == typeof(bool))
                return (T)(object)bool.Parse(value);
            if (typeof(T) == typeof(double))
                return (T)(object)double.Parse(value);
            if (typeof(T) == typeof(string))
                return (T)(object)value;

            return JsonSerializer.Deserialize<T>(value);
        }
        catch
        {
            return default;
        }
    }

    public async Task SetAsync(string key, string value)
    {
        var setting = await _context.Settings.FirstOrDefaultAsync(s => s.SettingKey == key);

        if (setting == null)
        {
            setting = new Setting
            {
                SettingKey = key,
                SettingValue = value,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            _context.Settings.Add(setting);
        }
        else
        {
            setting.SettingValue = value;
            setting.UpdatedAt = DateTime.UtcNow;
        }

        await _context.SaveChangesAsync();
    }

    public async Task SetAsync<T>(string key, T value)
    {
        string stringValue;

        if (value is string strValue)
            stringValue = strValue;
        else if (value is int or bool or double)
            stringValue = value.ToString()!;
        else
            stringValue = JsonSerializer.Serialize(value);

        await SetAsync(key, stringValue);
    }

    public async Task<IEnumerable<Setting>> GetByCategoryAsync(string category)
    {
        return await _context.Settings
            .AsNoTracking()
            .Where(s => s.Category == category)
            .ToListAsync();
    }

    public async Task<string?> GetEncryptedAsync(string key)
    {
        var encryptedValue = await GetAsync(key);
        if (string.IsNullOrEmpty(encryptedValue))
            return null;

        try
        {
            var encryptedBytes = Convert.FromBase64String(encryptedValue);
            var decryptedBytes = ProtectedData.Unprotect(
                encryptedBytes,
                null,
                DataProtectionScope.CurrentUser);

            return Encoding.UTF8.GetString(decryptedBytes);
        }
        catch
        {
            return null;
        }
    }

    public async Task SetEncryptedAsync(string key, string value)
    {
        var plainBytes = Encoding.UTF8.GetBytes(value);
        var encryptedBytes = ProtectedData.Protect(
            plainBytes,
            null,
            DataProtectionScope.CurrentUser);

        var encryptedValue = Convert.ToBase64String(encryptedBytes);
        await SetAsync(key, encryptedValue);
    }

    public async Task<bool> ExistsAsync(string key)
    {
        return await _context.Settings.AnyAsync(s => s.SettingKey == key);
    }

    public async Task DeleteAsync(string key)
    {
        var setting = await _context.Settings.FirstOrDefaultAsync(s => s.SettingKey == key);
        if (setting != null)
        {
            _context.Settings.Remove(setting);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<string> ExportToJsonAsync()
    {
        var settings = await _context.Settings
            .AsNoTracking()
            .OrderBy(s => s.SettingKey)
            .ToListAsync();

        var exportData = new SettingsExportData
        {
            ExportedAt = DateTime.UtcNow,
            Version = "1.0",
            Settings = settings.ToDictionary(
                s => s.SettingKey,
                s => new SettingsExportEntry
                {
                    Value = s.SettingValue,
                    ValueType = s.ValueType,
                    Category = s.Category
                })
        };

        return JsonSerializer.Serialize(exportData, _jsonOptions);
    }

    public async Task<IEnumerable<string>> GetAllKeysAsync()
    {
        return await _context.Settings
            .AsNoTracking()
            .Select(s => s.SettingKey)
            .ToListAsync();
    }

    public async Task<SettingsImportValidation> ValidateImportJsonAsync(string json)
    {
        var validation = new SettingsImportValidation();

        try
        {
            var importData = JsonSerializer.Deserialize<SettingsExportData>(json, _jsonOptions);
            if (importData?.Settings == null)
            {
                validation.IsValid = false;
                validation.ErrorMessage = "Invalid JSON format: Missing settings data";
                return validation;
            }

            var existingKeys = (await GetAllKeysAsync()).ToHashSet();

            foreach (var kvp in importData.Settings)
            {
                if (existingKeys.Contains(kvp.Key))
                {
                    validation.ValidFieldCount++;
                }
                else
                {
                    validation.IncompatibleFields.Add(kvp.Key);
                }
            }

            validation.IsValid = validation.IncompatibleFields.Count == 0;
            return validation;
        }
        catch (JsonException ex)
        {
            validation.IsValid = false;
            validation.ErrorMessage = $"Invalid JSON: {ex.Message}";
            return validation;
        }
    }

    public async Task<SettingsImportResult> ImportFromJsonAsync(string json)
    {
        var result = new SettingsImportResult();

        try
        {
            var importData = JsonSerializer.Deserialize<SettingsExportData>(json, _jsonOptions);
            if (importData?.Settings == null)
            {
                result.Success = false;
                result.ErrorMessage = "Invalid JSON format: Missing settings data";
                return result;
            }

            var existingKeys = (await GetAllKeysAsync()).ToHashSet();

            foreach (var kvp in importData.Settings)
            {
                if (!existingKeys.Contains(kvp.Key))
                {
                    result.IncompatibleFields.Add(kvp.Key);
                    result.SkippedCount++;
                    continue;
                }

                var setting = await _context.Settings.FirstOrDefaultAsync(s => s.SettingKey == kvp.Key);
                if (setting != null)
                {
                    setting.SettingValue = kvp.Value.Value;
                    setting.UpdatedAt = DateTime.UtcNow;
                    result.ImportedCount++;
                }
            }

            await _context.SaveChangesAsync();

            result.Success = result.IncompatibleFields.Count == 0;
            return result;
        }
        catch (JsonException ex)
        {
            result.Success = false;
            result.ErrorMessage = $"Invalid JSON: {ex.Message}";
            return result;
        }
    }
}

/// <summary>
/// Data structure for settings export/import JSON.
/// </summary>
public class SettingsExportData
{
    [JsonPropertyName("exportedAt")]
    public DateTime ExportedAt { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; } = "1.0";

    [JsonPropertyName("settings")]
    public Dictionary<string, SettingsExportEntry> Settings { get; set; } = new();
}

/// <summary>
/// Single setting entry in export/import JSON.
/// </summary>
public class SettingsExportEntry
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    [JsonPropertyName("valueType")]
    public string? ValueType { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }
}
