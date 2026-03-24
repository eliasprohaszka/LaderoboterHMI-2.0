using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service für Benutzerautorisierung
/// </summary>
public class AuthorizationService : IAuthorizationService
{
    private readonly IAuthService _authService;

    public UserRole? CurrentUserRole => GetCurrentRole();

    public event EventHandler<UserRole?>? OnRoleChanged;

    public AuthorizationService(IAuthService authService)
    {
        _authService = authService;
        _authService.CurrentUserChanged += OnCurrentUserChanged;
    }

    private UserRole? GetCurrentRole()
    {
        var user = _authService.GetCurrentUserAsync().GetAwaiter().GetResult();
        return user?.Role;
    }

    private void OnCurrentUserChanged(object? sender, User? user)
    {
        OnRoleChanged?.Invoke(this, user?.Role);
    }

    public bool HasRole(UserRole requiredRole)
    {
        var currentRole = GetCurrentRole();

        if (currentRole == null)
            return false;

        // GH Admin hat alle Berechtigungen
        if (currentRole == UserRole.GHAdmin)
            return true;

        // Admin hat alle Berechtigungen außer GHAdmin-spezifische
        if (currentRole == UserRole.Admin)
            return requiredRole <= UserRole.Admin;

        // Einrichter hat Einrichter und Bediener Berechtigungen
        if (currentRole == UserRole.Einrichter)
            return requiredRole <= UserRole.Einrichter;

        // Bediener hat nur Bediener Berechtigungen
        return currentRole.Value >= requiredRole;
    }

    public bool IsGHAdmin()
    {
        return GetCurrentRole() == UserRole.GHAdmin;
    }

    public bool IsAdmin()
    {
        var role = GetCurrentRole();
        return role == UserRole.Admin || role == UserRole.GHAdmin;
    }

    public bool IsEinrichter()
    {
        var role = GetCurrentRole();
        return role >= UserRole.Einrichter;
    }

    public bool IsBediener()
    {
        var role = GetCurrentRole();
        return role >= UserRole.Bediener;
    }

    public bool CanEditIO()
    {
        // Nur GH Admin darf I/O Signale ändern
        return IsGHAdmin();
    }

    public bool CanAccessMaintenance()
    {
        // Einrichter, Admin, GH Admin
        return IsEinrichter();
    }

    public bool CanAccessSettings()
    {
        // Einrichter, Admin, GH Admin
        return IsEinrichter();
    }

    public bool CanAccessUserManagement()
    {
        // Admin, GH Admin
        return IsAdmin();
    }

    public bool CanAccessActionLog()
    {
        // Admin, GH Admin
        return IsAdmin();
    }

    public bool CanAccessTranslations()
    {
        // Admin, GH Admin
        return IsAdmin();
    }

    public bool CanAccessGhSettings()
    {
        // Nur GH Admin
        return IsGHAdmin();
    }
}
