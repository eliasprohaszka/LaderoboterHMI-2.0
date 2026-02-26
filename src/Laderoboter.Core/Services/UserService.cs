using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service für Benutzerverwaltung
/// </summary>
public class UserService : IUserService
{
    private readonly IDbContextFactory<LaderoboterDbContext> _contextFactory;
    private readonly IPasswordService _passwordService;
    private readonly IUserActionLogService _actionLogService;

    public UserService(
        IDbContextFactory<LaderoboterDbContext> contextFactory,
        IPasswordService passwordService,
        IUserActionLogService actionLogService)
    {
        _contextFactory = contextFactory;
        _passwordService = passwordService;
        _actionLogService = actionLogService;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Users
            .OrderBy(u => u.PersonalNumber)
            .ToListAsync();
    }

    public async Task<User?> GetUserByIdAsync(int id)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Users.FindAsync(id);
    }

    public async Task<User?> GetUserByPersonalNumberAsync(string personalNumber)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        return await context.Users
            .FirstOrDefaultAsync(u => u.PersonalNumber == personalNumber);
    }

    public async Task<User> CreateUserAsync(string personalNumber, string password, UserRole role, string? name = null, string? rfidTag = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var user = new User
        {
            PersonalNumber = personalNumber,
            PasswordHash = _passwordService.HashPassword(password),
            Role = role,
            Name = name,
            RfidTag = rfidTag != null ? _passwordService.HashRfidTag(rfidTag) : null,
            IsActive = true,
            CreatedAt = DateTime.UtcNow
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();

        await _actionLogService.LogActionAsync(
            "Benutzer angelegt",
            $"Personalnummer: {personalNumber}, Rolle: {role}, Name: {name ?? "-"}");

        return user;
    }

    public async Task<User?> UpdateUserAsync(int id, string? personalNumber = null, string? password = null, UserRole? role = null, string? name = null, string? rfidTag = null, bool? isActive = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var user = await context.Users.FindAsync(id);
        if (user == null)
            return null;

        var changes = new List<string>();

        if (personalNumber != null && personalNumber != user.PersonalNumber)
        {
            changes.Add($"Personalnummer: {user.PersonalNumber} → {personalNumber}");
            user.PersonalNumber = personalNumber;
        }

        if (!string.IsNullOrEmpty(password))
        {
            changes.Add("Passwort geändert");
            user.PasswordHash = _passwordService.HashPassword(password);
        }

        if (role.HasValue && role.Value != user.Role)
        {
            changes.Add($"Rolle: {user.Role} → {role.Value}");
            user.Role = role.Value;
        }

        if (name != null && name != user.Name)
        {
            changes.Add($"Name: {user.Name ?? "-"} → {name}");
            user.Name = name;
        }

        // RFID: null = unchanged, empty = remove, non-empty = update
        if (rfidTag != null)
        {
            if (string.IsNullOrEmpty(rfidTag))
            {
                if (user.RfidTag != null)
                {
                    changes.Add("RFID entfernt");
                    user.RfidTag = null;
                }
            }
            else
            {
                changes.Add("RFID geändert");
                user.RfidTag = _passwordService.HashRfidTag(rfidTag);
            }
        }

        if (isActive.HasValue && isActive.Value != user.IsActive)
        {
            changes.Add($"Status: {(user.IsActive ? "Aktiv" : "Inaktiv")} → {(isActive.Value ? "Aktiv" : "Inaktiv")}");
            user.IsActive = isActive.Value;
        }

        if (changes.Count > 0)
        {
            await context.SaveChangesAsync();

            await _actionLogService.LogActionAsync(
                "Benutzer bearbeitet",
                $"Benutzer: {user.PersonalNumber}, Änderungen: {string.Join(", ", changes)}");
        }

        return user;
    }

    public async Task<bool> DeleteUserAsync(int id)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var user = await context.Users.FindAsync(id);
        if (user == null)
            return false;

        var personalNumber = user.PersonalNumber;
        var userName = user.Name;

        context.Users.Remove(user);
        await context.SaveChangesAsync();

        await _actionLogService.LogActionAsync(
            "Benutzer gelöscht",
            $"Personalnummer: {personalNumber}, Name: {userName ?? "-"}");

        return true;
    }
}
