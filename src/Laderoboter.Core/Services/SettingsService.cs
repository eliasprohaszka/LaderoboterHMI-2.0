using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public class SettingsService : ISettingsService
{
    private readonly LaderoboterDbContext _context;

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
}
