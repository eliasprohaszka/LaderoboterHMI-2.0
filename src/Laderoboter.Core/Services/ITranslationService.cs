using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public interface ITranslationService
{
    string CurrentLanguage { get; }
    event EventHandler? LanguageChanged;

    Task InitializeAsync();
    Task SetLanguageAsync(string languageCode);
    string Translate(string key);
    string Translate(string key, params object[] args);
    Task<IEnumerable<Language>> GetAvailableLanguagesAsync();
    Task<IEnumerable<Language>> GetActiveLanguagesAsync();

    // Language CRUD
    Task<Language> AddLanguageAsync(string code, string name, string nativeName);
    Task<Language> UpdateLanguageAsync(int id, string name, string nativeName, bool isActive, int sortOrder);
    Task DeleteLanguageAsync(int id);
    Task UpdateLanguageSortOrderAsync(IEnumerable<(int Id, int SortOrder)> sortOrders);

    // Translation CRUD
    Task<IEnumerable<string>> GetAllTranslationKeysAsync();
    Task<IEnumerable<string>> GetCategoriesAsync();
    Task<IEnumerable<Translation>> GetTranslationsForKeyAsync(string key);
    Task<IEnumerable<Translation>> GetTranslationsByLanguageAsync(int languageId);
    Task<IEnumerable<Translation>> SearchTranslationsAsync(string? searchTerm, string? category);
    Task<Translation> AddTranslationAsync(int languageId, string key, string value, string? category = null, string? description = null);
    Task<Translation> UpdateTranslationAsync(int id, string value, string? description = null);
    Task DeleteTranslationAsync(int id);
    Task<int> GetMissingTranslationsCountAsync(int languageId);

    // Import/Export
    Task<string> ExportTranslationsAsync(int? languageId = null);
    Task ImportTranslationsAsync(string json, bool overwriteExisting = false);
}
