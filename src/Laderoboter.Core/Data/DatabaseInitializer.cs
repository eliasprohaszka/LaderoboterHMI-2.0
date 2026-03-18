using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Models;
using Laderoboter.Core.Interfaces;

namespace Laderoboter.Core.Data;

public static class DatabaseInitializer
{
    public static async Task InitializeAsync(LaderoboterDbContext context, IPasswordService? passwordService = null)
    {
        // First try to apply pending migrations, fall back to EnsureCreated for new databases
        try
        {
            var pendingMigrations = await context.Database.GetPendingMigrationsAsync();
            if (pendingMigrations.Any())
            {
                await context.Database.MigrateAsync();
            }
        }
        catch
        {
            // If migrations fail (e.g., no __EFMigrationsHistory table), ensure database is created
            await context.Database.EnsureCreatedAsync();
        }

        // Seed default users if needed
        try
        {
            if (passwordService != null && !await context.Users.AnyAsync())
            {
                await SeedDefaultUsersAsync(context, passwordService);
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Error seeding Users: {ex.Message}");
            Console.WriteLine($"Error seeding Users: {ex.Message}");
        }
    }

    private static async Task SeedDefaultUsersAsync(LaderoboterDbContext context, IPasswordService passwordService)
    {
        var now = DateTime.UtcNow;

        var users = new List<User>
        {
            new User
            {
                PersonalNumber = "001",
                PasswordHash = passwordService.HashPassword("SUNRISE"),
                Role = UserRole.Bediener,
                Name = "Bediener Test",
                IsActive = true,
                CreatedAt = now
            },
            new User
            {
                PersonalNumber = "002",
                PasswordHash = passwordService.HashPassword("SUNRISE"),
                Role = UserRole.Einrichter,
                Name = "Einrichter Test",
                IsActive = true,
                CreatedAt = now
            },
            new User
            {
                PersonalNumber = "admin",
                PasswordHash = passwordService.HashPassword("admin"),
                Role = UserRole.GHAdmin,
                Name = "GH Administrator",
                IsActive = true,
                CreatedAt = now
            }
        };

        context.Users.AddRange(users);
        await context.SaveChangesAsync();
    }

    public static string GetDatabasePath()
    {
        var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        var dbFolder = Path.Combine(appDataPath, "Laderoboter");

        if (!Directory.Exists(dbFolder))
        {
            Directory.CreateDirectory(dbFolder);
        }

        return Path.Combine(dbFolder, "laderoboter.db");
    }
}
