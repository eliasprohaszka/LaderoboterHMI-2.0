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
        services.AddSingleton<IRobotRequestQueue, RobotRequestQueue>();
        services.AddSingleton<IRobotService, RobotService>();
        services.AddSingleton<IRegisterCacheService, RegisterCacheService>();
        services.AddSingleton<ITaskStatusMonitor, TaskStatusMonitor>();
        services.AddSingleton<IRobotMonitor, RobotMonitor>();
        services.AddSingleton<IRobotAlarmService, RobotAlarmService>();
        services.AddSingleton<IRegisterErrorService, RegisterErrorService>();
        services.AddSingleton<IAutostopHandshakeService, AutostopHandshakeService>();
        services.AddSingleton<IPaletteHandshakeService, PaletteHandshakeService>();
        services.AddSingleton<ISystemService, SystemService>();
        services.AddSingleton<ITranslationService, TranslationService>();

        // Authentication & Authorization Services
        services.AddSingleton<IPasswordService, PasswordService>();
        services.AddSingleton<IAuthService, AuthService>();
        services.AddSingleton<IAuthorizationService, AuthorizationService>();
        services.AddSingleton<IUserService, UserService>();
        services.AddSingleton<IUserActionLogService, UserActionLogService>();
        services.AddSingleton<IGhSettingsService, GhSettingsService>();
        services.AddSingleton<IJobService, JobService>();
        services.AddSingleton<IWorkpieceProgramNumberService, WorkpieceProgramNumberService>();

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

    public static async Task InitializeGhSettingsAsync(this IServiceProvider serviceProvider)
    {
        var ghSettingsService = serviceProvider.GetRequiredService<IGhSettingsService>();
        await ghSettingsService.LoadAsync();
    }

    /// <summary>
    /// Initialisiert die Service-Verbindungen nach DI-Container-Erstellung.
    /// Löst zirkuläre Abhängigkeiten zwischen RobotService, RegisterCacheService und TaskStatusMonitor.
    /// </summary>
    public static void InitializeServiceConnections(this IServiceProvider serviceProvider)
    {
        var robotService = serviceProvider.GetRequiredService<IRobotService>() as RobotService;
        var registerCache = serviceProvider.GetRequiredService<IRegisterCacheService>();
        var taskStatusMonitor = serviceProvider.GetRequiredService<ITaskStatusMonitor>();

        robotService?.SetRegisterCache(registerCache);
        robotService?.SetTaskStatusMonitor(taskStatusMonitor);

        // Instanziiere Handshake-Services damit sie aktiv werden (subscriben auf RegisterChanged Events)
        _ = serviceProvider.GetRequiredService<IAutostopHandshakeService>();
        _ = serviceProvider.GetRequiredService<IPaletteHandshakeService>();
    }
}
