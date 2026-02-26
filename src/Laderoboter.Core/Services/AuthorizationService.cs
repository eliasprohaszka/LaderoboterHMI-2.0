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

        // Admin hat alle Berechtigungen
        if (currentRole == UserRole.Admin)
            return true;

        // Einrichter hat Einrichter und Bediener Berechtigungen
        if (currentRole == UserRole.Einrichter)
            return requiredRole <= UserRole.Einrichter;

        // Bediener hat nur Bediener Berechtigungen
        return currentRole.Value >= requiredRole;
    }

    public bool IsAdmin()
    {
        return GetCurrentRole() == UserRole.Admin;
    }

    public bool IsEinrichter()
    {
        return HasRole(UserRole.Einrichter);
    }

    public bool IsBediener()
    {
        return HasRole(UserRole.Bediener);
    }
}
