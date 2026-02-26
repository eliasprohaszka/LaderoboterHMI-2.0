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
}
