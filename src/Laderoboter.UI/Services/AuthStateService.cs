using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Models;

namespace Laderoboter.UI.Services;

/// <summary>
/// UI-Service für Authentifizierungsstatus
/// </summary>
public class AuthStateService : IAuthStateService
{
    private readonly IAuthService _authService;
    private readonly IUserActionLogService _actionLogService;

    public User? CurrentUser { get; private set; }
    public bool IsAuthenticated => CurrentUser != null;

    public event EventHandler<User?>? AuthStateChanged;

    public AuthStateService(IAuthService authService, IUserActionLogService actionLogService)
    {
        _authService = authService;
        _actionLogService = actionLogService;

        _authService.CurrentUserChanged += OnCurrentUserChanged;
    }

    private void OnCurrentUserChanged(object? sender, User? user)
    {
        CurrentUser = user;
        AuthStateChanged?.Invoke(this, user);
    }

    public async Task<bool> LoginAsync(string personalNumber, string password)
    {
        var user = await _authService.LoginAsync(personalNumber, password);
        if (user != null)
        {
            await _actionLogService.LogActionAsync(user.Id, "Login", $"Login via Personalnummer: {personalNumber}");
            return true;
        }
        return false;
    }

    public async Task<bool> LoginByRfidAsync(string rfidTag)
    {
        var user = await _authService.LoginByRfidAsync(rfidTag);
        if (user != null)
        {
            await _actionLogService.LogActionAsync(user.Id, "Login", "Login via RFID");
            return true;
        }
        return false;
    }

    public async Task LogoutAsync()
    {
        if (CurrentUser != null)
        {
            await _actionLogService.LogActionAsync(CurrentUser.Id, "Logout");
            await _authService.LogoutAsync(CurrentUser.Id);
        }
    }
}
