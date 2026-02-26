using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public class TranslationService : ITranslationService
{
    private readonly IDbContextFactory<LaderoboterDbContext> _contextFactory;
    private Dictionary<string, string> _translations = new();
    private string _currentLanguage = "de";
    private bool _isInitialized = false;

    public string CurrentLanguage => _currentLanguage;
    public event EventHandler? LanguageChanged;

    public TranslationService(IDbContextFactory<LaderoboterDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task InitializeAsync()
    {
        if (_isInitialized) return;

        await using var context = await _contextFactory.CreateDbContextAsync();

        var setting = await context.Settings
            .FirstOrDefaultAsync(s => s.SettingKey == "ui.language");

        var savedLanguage = setting?.SettingValue ?? "de";
        await LoadTranslationsAsync(savedLanguage);
        _isInitialized = true;
    }

    public async Task SetLanguageAsync(string languageCode)
    {
        await LoadTranslationsAsync(languageCode);

        await using var context = await _contextFactory.CreateDbContextAsync();

        var setting = await context.Settings
            .FirstOrDefaultAsync(s => s.SettingKey == "ui.language");

        if (setting != null)
        {
            setting.SettingValue = _currentLanguage;
            setting.UpdatedAt = DateTime.UtcNow;
        }
        else
        {
            context.Settings.Add(new Setting
            {
                SettingKey = "ui.language",
                SettingValue = _currentLanguage,
                ValueType = "string",
                Category = "ui",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
        }

        await context.SaveChangesAsync();

        LanguageChanged?.Invoke(this, EventArgs.Empty);
    }

    private async Task LoadTranslationsAsync(string languageCode)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var language = await context.Languages
            .FirstOrDefaultAsync(l => l.Code == languageCode && l.IsActive);

        if (language == null)
        {
            language = await context.Languages
                .FirstOrDefaultAsync(l => l.IsActive);
        }

        if (language == null)
        {
            return;
        }

        var translations = await context.Translations
            .Where(t => t.LanguageId == language.Id)
            .ToDictionaryAsync(t => t.Key, t => t.Value);

        _translations = translations;
        _currentLanguage = language.Code;
    }

    public string Translate(string key)
    {
        if (_translations.TryGetValue(key, out var translation))
        {
            return translation;
        }

        return key;
    }

    public string Translate(string key, params object[] args)
    {
        var translation = Translate(key);

        if (args.Length > 0)
        {
            try
            {
                return string.Format(translation, args);
            }
            catch
            {
                return translation;
            }
        }

        return translation;
    }

    public async Task<IEnumerable<Language>> GetAvailableLanguagesAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Languages
            .OrderBy(l => l.SortOrder)
            .ToListAsync();
    }

    public async Task<IEnumerable<Language>> GetActiveLanguagesAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Languages
            .Where(l => l.IsActive)
            .OrderBy(l => l.SortOrder)
            .ToListAsync();
    }

    // Language CRUD

    public async Task<Language> AddLanguageAsync(string code, string name, string nativeName)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var maxSortOrder = await context.Languages.MaxAsync(l => (int?)l.SortOrder) ?? 0;

        var language = new Language
        {
            Code = code.ToLowerInvariant(),
            Name = name,
            NativeName = nativeName,
            IsActive = true,
            SortOrder = maxSortOrder + 1,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        context.Languages.Add(language);
        await context.SaveChangesAsync();

        return language;
    }

    public async Task<Language> UpdateLanguageAsync(int id, string name, string nativeName, bool isActive, int sortOrder)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var language = await context.Languages.FindAsync(id)
            ?? throw new InvalidOperationException($"Language with ID {id} not found");

        language.Name = name;
        language.NativeName = nativeName;
        language.IsActive = isActive;
        language.SortOrder = sortOrder;
        language.UpdatedAt = DateTime.UtcNow;

        await context.SaveChangesAsync();

        return language;
    }

    public async Task DeleteLanguageAsync(int id)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var language = await context.Languages
            .Include(l => l.Translations)
            .FirstOrDefaultAsync(l => l.Id == id)
            ?? throw new InvalidOperationException($"Language with ID {id} not found");

        context.Translations.RemoveRange(language.Translations);
        context.Languages.Remove(language);

        await context.SaveChangesAsync();
    }

    public async Task UpdateLanguageSortOrderAsync(IEnumerable<(int Id, int SortOrder)> sortOrders)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        foreach (var (id, sortOrder) in sortOrders)
        {
            var language = await context.Languages.FindAsync(id);
            if (language != null)
            {
                language.SortOrder = sortOrder;
                language.UpdatedAt = DateTime.UtcNow;
            }
        }

        await context.SaveChangesAsync();
    }

    // Translation CRUD

    public async Task<IEnumerable<string>> GetAllTranslationKeysAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Translations
            .Select(t => t.Key)
            .Distinct()
            .OrderBy(k => k)
            .ToListAsync();
    }

    public async Task<IEnumerable<string>> GetCategoriesAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Translations
            .Where(t => t.Category != null)
            .Select(t => t.Category!)
            .Distinct()
            .OrderBy(c => c)
            .ToListAsync();
    }

    public async Task<IEnumerable<Translation>> GetTranslationsForKeyAsync(string key)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Translations
            .Include(t => t.Language)
            .Where(t => t.Key == key)
            .OrderBy(t => t.Language.SortOrder)
            .ToListAsync();
    }

    public async Task<IEnumerable<Translation>> GetTranslationsByLanguageAsync(int languageId)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Translations
            .Where(t => t.LanguageId == languageId)
            .OrderBy(t => t.Key)
            .ToListAsync();
    }

    public async Task<IEnumerable<Translation>> SearchTranslationsAsync(string? searchTerm, string? category)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var query = context.Translations
            .Include(t => t.Language)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            var term = searchTerm.ToLowerInvariant();
            query = query.Where(t =>
                t.Key.ToLower().Contains(term) ||
                t.Value.ToLower().Contains(term));
        }

        if (!string.IsNullOrWhiteSpace(category))
        {
            query = query.Where(t => t.Category == category);
        }

        return await query
            .OrderBy(t => t.Key)
            .ThenBy(t => t.Language.SortOrder)
            .ToListAsync();
    }

    public async Task<Translation> AddTranslationAsync(int languageId, string key, string value, string? category = null, string? description = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        // Derive category from key if not provided
        var derivedCategory = category ?? key.Split('.').FirstOrDefault();

        var translation = new Translation
        {
            LanguageId = languageId,
            Key = key,
            Value = value,
            Category = derivedCategory,
            Description = description,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        context.Translations.Add(translation);
        await context.SaveChangesAsync();

        // Reload cache if this is the current language
        var language = await context.Languages.FindAsync(languageId);
        if (language?.Code == _currentLanguage)
        {
            _translations[key] = value;
        }

        return translation;
    }

    public async Task<Translation> UpdateTranslationAsync(int id, string value, string? description = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var translation = await context.Translations
            .Include(t => t.Language)
            .FirstOrDefaultAsync(t => t.Id == id)
            ?? throw new InvalidOperationException($"Translation with ID {id} not found");

        translation.Value = value;
        if (description != null)
        {
            translation.Description = description;
        }
        translation.UpdatedAt = DateTime.UtcNow;

        await context.SaveChangesAsync();

        // Update cache if this is the current language
        if (translation.Language.Code == _currentLanguage)
        {
            _translations[translation.Key] = value;
        }

        return translation;
    }

    public async Task DeleteTranslationAsync(int id)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var translation = await context.Translations
            .Include(t => t.Language)
            .FirstOrDefaultAsync(t => t.Id == id)
            ?? throw new InvalidOperationException($"Translation with ID {id} not found");

        var key = translation.Key;
        var languageCode = translation.Language.Code;

        context.Translations.Remove(translation);
        await context.SaveChangesAsync();

        // Update cache if this is the current language
        if (languageCode == _currentLanguage)
        {
            _translations.Remove(key);
        }
    }

    public async Task<int> GetMissingTranslationsCountAsync(int languageId)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var allKeys = await context.Translations
            .Select(t => t.Key)
            .Distinct()
            .ToListAsync();

        var languageKeys = await context.Translations
            .Where(t => t.LanguageId == languageId)
            .Select(t => t.Key)
            .ToListAsync();

        return allKeys.Except(languageKeys).Count();
    }

    // Import/Export

    public async Task<string> ExportTranslationsAsync(int? languageId = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        if (languageId.HasValue)
        {
            var language = await context.Languages.FindAsync(languageId.Value);
            if (language == null)
                throw new InvalidOperationException($"Language with ID {languageId} not found");

            var translations = await context.Translations
                .Where(t => t.LanguageId == languageId.Value)
                .ToDictionaryAsync(t => t.Key, t => t.Value);

            var export = new Dictionary<string, object>
            {
                ["language"] = language.Code,
                ["translations"] = translations
            };

            return JsonSerializer.Serialize(export, new JsonSerializerOptions { WriteIndented = true });
        }
        else
        {
            var languages = await context.Languages.ToListAsync();
            var export = new Dictionary<string, object>();

            foreach (var language in languages)
            {
                var translations = await context.Translations
                    .Where(t => t.LanguageId == language.Id)
                    .ToDictionaryAsync(t => t.Key, t => t.Value);

                export[language.Code] = translations;
            }

            return JsonSerializer.Serialize(export, new JsonSerializerOptions { WriteIndented = true });
        }
    }

    public async Task ImportTranslationsAsync(string json, bool overwriteExisting = false)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var document = JsonDocument.Parse(json);
        var root = document.RootElement;

        // Check if it's a single language export or multi-language
        if (root.TryGetProperty("language", out var langElement))
        {
            // Single language format
            var languageCode = langElement.GetString()!;
            var language = await context.Languages.FirstOrDefaultAsync(l => l.Code == languageCode);

            if (language == null)
            {
                language = new Language
                {
                    Code = languageCode,
                    Name = languageCode,
                    NativeName = languageCode,
                    IsActive = true,
                    SortOrder = await context.Languages.MaxAsync(l => (int?)l.SortOrder) + 1 ?? 1,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                context.Languages.Add(language);
                await context.SaveChangesAsync();
            }

            var translations = root.GetProperty("translations");
            await ImportLanguageTranslationsAsync(context, language.Id, translations, overwriteExisting);
        }
        else
        {
            // Multi-language format
            foreach (var langProperty in root.EnumerateObject())
            {
                var languageCode = langProperty.Name;
                var language = await context.Languages.FirstOrDefaultAsync(l => l.Code == languageCode);

                if (language == null)
                {
                    language = new Language
                    {
                        Code = languageCode,
                        Name = languageCode,
                        NativeName = languageCode,
                        IsActive = true,
                        SortOrder = await context.Languages.MaxAsync(l => (int?)l.SortOrder) + 1 ?? 1,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    };
                    context.Languages.Add(language);
                    await context.SaveChangesAsync();
                }

                await ImportLanguageTranslationsAsync(context, language.Id, langProperty.Value, overwriteExisting);
            }
        }

        // Reload translations if current language was affected
        await LoadTranslationsAsync(_currentLanguage);
    }

    private async Task ImportLanguageTranslationsAsync(LaderoboterDbContext context, int languageId, JsonElement translations, bool overwriteExisting)
    {
        foreach (var kvp in translations.EnumerateObject())
        {
            var key = kvp.Name;
            var value = kvp.Value.GetString() ?? "";
            var category = key.Split('.').FirstOrDefault();

            var existing = await context.Translations
                .FirstOrDefaultAsync(t => t.LanguageId == languageId && t.Key == key);

            if (existing != null)
            {
                if (overwriteExisting)
                {
                    existing.Value = value;
                    existing.UpdatedAt = DateTime.UtcNow;
                }
            }
            else
            {
                context.Translations.Add(new Translation
                {
                    LanguageId = languageId,
                    Key = key,
                    Value = value,
                    Category = category,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
            }
        }

        await context.SaveChangesAsync();
    }
}
