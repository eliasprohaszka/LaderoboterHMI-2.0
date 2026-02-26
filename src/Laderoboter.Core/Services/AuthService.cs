using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service für Benutzer-Authentifizierung
/// </summary>
public class AuthService : IAuthService
{
    private readonly IDbContextFactory<LaderoboterDbContext> _contextFactory;
    private readonly IPasswordService _passwordService;
    private User? _currentUser;

    public event EventHandler<User?>? CurrentUserChanged;

    public AuthService(
        IDbContextFactory<LaderoboterDbContext> contextFactory,
        IPasswordService passwordService)
    {
        _contextFactory = contextFactory;
        _passwordService = passwordService;
    }

    public async Task<User?> LoginAsync(string personalNumber, string password)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var user = await context.Users
            .FirstOrDefaultAsync(u => u.PersonalNumber == personalNumber && u.IsActive);

        if (user == null)
            return null;

        if (!_passwordService.VerifyPassword(password, user.PasswordHash))
            return null;

        user.LastLoginAt = DateTime.UtcNow;
        await context.SaveChangesAsync();

        SetCurrentUser(user);
        return user;
    }

    public async Task<User?> LoginByRfidAsync(string rfidTag)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var users = await context.Users
            .Where(u => u.IsActive && u.RfidTag != null)
            .ToListAsync();

        foreach (var user in users)
        {
            if (_passwordService.VerifyRfidTag(rfidTag, user.RfidTag!))
            {
                user.LastLoginAt = DateTime.UtcNow;
                await context.SaveChangesAsync();

                SetCurrentUser(user);
                return user;
            }
        }

        return null;
    }

    public async Task LogoutAsync(int userId)
    {
        if (_currentUser?.Id == userId)
        {
            SetCurrentUser(null);
        }

        await Task.CompletedTask;
    }

    public Task<User?> GetCurrentUserAsync()
    {
        return Task.FromResult(_currentUser);
    }

    public void SetCurrentUser(User? user)
    {
        _currentUser = user;
        CurrentUserChanged?.Invoke(this, user);
    }
}
