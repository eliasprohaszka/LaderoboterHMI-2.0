using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public interface ISettingsService
{
    Task<string?> GetAsync(string key);
    Task<T?> GetAsync<T>(string key);
    Task SetAsync(string key, string value);
    Task SetAsync<T>(string key, T value);
    Task<IEnumerable<Setting>> GetByCategoryAsync(string category);
    Task<string?> GetEncryptedAsync(string key);
    Task SetEncryptedAsync(string key, string value);
    Task<bool> ExistsAsync(string key);
    Task DeleteAsync(string key);

    /// <summary>
    /// Exports all settings to a JSON string.
    /// </summary>
    Task<string> ExportToJsonAsync();

    /// <summary>
    /// Validates and imports settings from a JSON string.
    /// Returns a result with success status and any incompatible fields.
    /// </summary>
    Task<SettingsImportResult> ImportFromJsonAsync(string json);

    /// <summary>
    /// Validates the JSON without importing, returning any incompatible fields.
    /// </summary>
    Task<SettingsImportValidation> ValidateImportJsonAsync(string json);

    /// <summary>
    /// Gets all setting keys that exist in the database.
    /// </summary>
    Task<IEnumerable<string>> GetAllKeysAsync();
}

/// <summary>
/// Result of a settings import operation.
/// </summary>
public class SettingsImportResult
{
    public bool Success { get; set; }
    public int ImportedCount { get; set; }
    public int SkippedCount { get; set; }
    public List<string> IncompatibleFields { get; set; } = new();
    public string? ErrorMessage { get; set; }
}

/// <summary>
/// Result of validating a settings import JSON.
/// </summary>
public class SettingsImportValidation
{
    public bool IsValid { get; set; }
    public int ValidFieldCount { get; set; }
    public List<string> IncompatibleFields { get; set; } = new();
    public string? ErrorMessage { get; set; }
}
