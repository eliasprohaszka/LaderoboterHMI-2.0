using Laderoboter.Core.Interfaces;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service für GH-spezifische Einstellungen
/// </summary>
public class GhSettingsService : IGhSettingsService
{
    private readonly ISettingsService _settingsService;

    // Setting keys
    private const string KEY_JOB_LIST_ENABLED = "gh.jobList.enabled";
    private const string KEY_SHELF_EDITING_ENABLED = "gh.shelf.editing.enabled";
    private const string KEY_SHELF_EDITING_OFFLINE = "gh.shelf.editing.offline";

    public event EventHandler? SettingsChanged;

    public bool IsJobListEnabled { get; private set; }
    public bool IsShelfWorkpieceEditingEnabled { get; private set; } = true;
    public bool IsShelfWorkpieceEditingOffline { get; private set; }

    public GhSettingsService(ISettingsService settingsService)
    {
        _settingsService = settingsService;
    }

    public async Task LoadAsync()
    {
        IsJobListEnabled = await _settingsService.GetAsync<bool>(KEY_JOB_LIST_ENABLED);
        IsShelfWorkpieceEditingEnabled = await _settingsService.GetAsync<bool?>(KEY_SHELF_EDITING_ENABLED) ?? true;
        IsShelfWorkpieceEditingOffline = await _settingsService.GetAsync<bool>(KEY_SHELF_EDITING_OFFLINE);
    }

    public async Task SetJobListEnabledAsync(bool enabled)
    {
        IsJobListEnabled = enabled;
        await _settingsService.SetAsync(KEY_JOB_LIST_ENABLED, enabled);
        SettingsChanged?.Invoke(this, EventArgs.Empty);
    }

    public async Task SetShelfWorkpieceEditingEnabledAsync(bool enabled)
    {
        IsShelfWorkpieceEditingEnabled = enabled;
        await _settingsService.SetAsync(KEY_SHELF_EDITING_ENABLED, enabled);
        SettingsChanged?.Invoke(this, EventArgs.Empty);
    }

    public async Task SetShelfWorkpieceEditingOfflineAsync(bool offline)
    {
        IsShelfWorkpieceEditingOffline = offline;
        await _settingsService.SetAsync(KEY_SHELF_EDITING_OFFLINE, offline);
        SettingsChanged?.Invoke(this, EventArgs.Empty);
    }
}
