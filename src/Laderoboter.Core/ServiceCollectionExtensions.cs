using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Laderoboter.Core.Data;
using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Services;

namespace Laderoboter.Core;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLaderoboterCore(this IServiceCollection services)
    {
        var dbPath = DatabaseInitializer.GetDatabasePath();

        services.AddDbContext<LaderoboterDbContext>(options =>
            options.UseSqlite($"Data Source={dbPath}"));

        services.AddDbContextFactory<LaderoboterDbContext>(options =>
            options.UseSqlite($"Data Source={dbPath}"), ServiceLifetime.Singleton);

        services.AddScoped<ISettingsService, SettingsService>();
        services.AddScoped<IErrorLogService, ErrorLogService>();
        services.AddSingleton<IRobotService, RobotService>();
        services.AddSingleton<IRobotMonitor, RobotMonitor>();
        services.AddSingleton<ISystemService, SystemService>();
        services.AddSingleton<ITranslationService, TranslationService>();

        // Authentication & Authorization Services
        services.AddSingleton<IPasswordService, PasswordService>();
        services.AddSingleton<IAuthService, AuthService>();
        services.AddSingleton<IAuthorizationService, AuthorizationService>();
        services.AddSingleton<IUserService, UserService>();
        services.AddSingleton<IUserActionLogService, UserActionLogService>();

        return services;
    }

    public static async Task InitializeDatabaseAsync(this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<LaderoboterDbContext>();
        var passwordService = serviceProvider.GetRequiredService<IPasswordService>();
        await DatabaseInitializer.InitializeAsync(context, passwordService);

        // Seed settings and translations at runtime (not via migrations to keep them small)
        await SettingsSeeder.SeedAsync(context);
        await TranslationSeeder.SeedAsync(context);
    }

    public static async Task InitializeTranslationsAsync(this IServiceProvider serviceProvider)
    {
        var translationService = serviceProvider.GetRequiredService<ITranslationService>();
        await translationService.InitializeAsync();
    }
}
