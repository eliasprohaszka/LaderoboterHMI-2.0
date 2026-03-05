using System.Text.Json;
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

    public async Task<string> ExportToJsonAsync()
    {
        await using var context = await _contextFactory.CreateDbContextAsync();
        var users = await context.Users.OrderBy(u => u.PersonalNumber).ToListAsync();

        var exportData = users.Select(u => new UserExportDto
        {
            PersonalNumber = u.PersonalNumber,
            Name = u.Name,
            Role = u.Role.ToString(),
            IsActive = u.IsActive
        }).ToList();

        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        return JsonSerializer.Serialize(new { users = exportData, exportedAt = DateTime.UtcNow }, options);
    }

    public async Task<UsersImportValidation> ValidateImportJsonAsync(string json)
    {
        var validation = new UsersImportValidation();

        try
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var importData = JsonSerializer.Deserialize<UserImportContainer>(json, options);

            if (importData?.Users == null || importData.Users.Count == 0)
            {
                validation.ErrorMessage = "Keine Benutzer in der Datei gefunden.";
                return validation;
            }

            await using var context = await _contextFactory.CreateDbContextAsync();
            var existingUsers = await context.Users.Select(u => u.PersonalNumber).ToListAsync();

            foreach (var user in importData.Users)
            {
                if (string.IsNullOrWhiteSpace(user.PersonalNumber))
                {
                    validation.Warnings.Add("Benutzer ohne Personalnummer wird übersprungen");
                    continue;
                }

                if (!Enum.TryParse<UserRole>(user.Role, true, out _))
                {
                    validation.Warnings.Add($"Ungültige Rolle für {user.PersonalNumber}: {user.Role}");
                    continue;
                }

                if (existingUsers.Contains(user.PersonalNumber))
                {
                    validation.ExistingUserCount++;
                }
                else
                {
                    validation.NewUserCount++;
                }
            }

            validation.IsValid = validation.NewUserCount > 0 || validation.ExistingUserCount > 0;
        }
        catch (JsonException ex)
        {
            validation.ErrorMessage = $"Ungültiges JSON-Format: {ex.Message}";
        }

        return validation;
    }

    public async Task<UsersImportResult> ImportFromJsonAsync(string json)
    {
        var result = new UsersImportResult();

        try
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var importData = JsonSerializer.Deserialize<UserImportContainer>(json, options);

            if (importData?.Users == null)
            {
                result.ErrorMessage = "Keine Benutzer in der Datei gefunden.";
                return result;
            }

            await using var context = await _contextFactory.CreateDbContextAsync();

            foreach (var importUser in importData.Users)
            {
                if (string.IsNullOrWhiteSpace(importUser.PersonalNumber))
                {
                    result.SkippedCount++;
                    result.Errors.Add("Benutzer ohne Personalnummer übersprungen");
                    continue;
                }

                if (!Enum.TryParse<UserRole>(importUser.Role, true, out var role))
                {
                    result.SkippedCount++;
                    result.Errors.Add($"Ungültige Rolle für {importUser.PersonalNumber}");
                    continue;
                }

                var existingUser = await context.Users.FirstOrDefaultAsync(u => u.PersonalNumber == importUser.PersonalNumber);

                if (existingUser != null)
                {
                    // Update existing user (except password and RFID)
                    existingUser.Name = importUser.Name;
                    existingUser.Role = role;
                    existingUser.IsActive = importUser.IsActive;
                    result.UpdatedCount++;
                }
                else
                {
                    // Create new user with default password
                    var newUser = new User
                    {
                        PersonalNumber = importUser.PersonalNumber,
                        Name = importUser.Name,
                        Role = role,
                        IsActive = importUser.IsActive,
                        PasswordHash = _passwordService.HashPassword(importUser.PersonalNumber), // Default password = PersonalNumber
                        CreatedAt = DateTime.UtcNow
                    };
                    context.Users.Add(newUser);
                    result.ImportedCount++;
                }
            }

            await context.SaveChangesAsync();

            await _actionLogService.LogActionAsync(
                "Benutzer importiert",
                $"Neu: {result.ImportedCount}, Aktualisiert: {result.UpdatedCount}, Übersprungen: {result.SkippedCount}");

            result.Success = true;
        }
        catch (Exception ex)
        {
            result.ErrorMessage = $"Import fehlgeschlagen: {ex.Message}";
        }

        return result;
    }

    private class UserExportDto
    {
        public string PersonalNumber { get; set; } = "";
        public string? Name { get; set; }
        public string Role { get; set; } = "";
        public bool IsActive { get; set; }
    }

    private class UserImportContainer
    {
        public List<UserExportDto> Users { get; set; } = new();
    }
}
