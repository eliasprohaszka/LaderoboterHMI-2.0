using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Data;

public class LaderoboterDbContext : DbContext
{
    public LaderoboterDbContext(DbContextOptions<LaderoboterDbContext> options) : base(options)
    {
    }

    public DbSet<Setting> Settings => Set<Setting>();
    public DbSet<ErrorLog> ErrorLogs => Set<ErrorLog>();
    public DbSet<Language> Languages => Set<Language>();
    public DbSet<Translation> Translations => Set<Translation>();
    public DbSet<User> Users => Set<User>();
    public DbSet<UserActionLog> UserActionLogs => Set<UserActionLog>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasIndex(e => e.SettingKey).IsUnique();
            entity.Property(e => e.SettingKey).IsRequired();
            entity.Property(e => e.ValueType).HasDefaultValue("string");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.ErrorMessage).IsRequired();
            entity.Property(e => e.Severity).HasConversion<string>();
            entity.Property(e => e.Source).HasConversion<string>();
            entity.HasIndex(e => e.Timestamp);
            entity.HasIndex(e => e.Severity);
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasIndex(e => e.Code).IsUnique();
            entity.Property(e => e.Code).IsRequired().HasMaxLength(10);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.NativeName).IsRequired().HasMaxLength(100);
        });

        modelBuilder.Entity<Translation>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Key).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Value).IsRequired();
            entity.HasIndex(e => new { e.LanguageId, e.Key }).IsUnique();
            entity.HasOne(e => e.Language)
                .WithMany(l => l.Translations)
                .HasForeignKey(e => e.LanguageId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasIndex(e => e.PersonalNumber).IsUnique();
            entity.HasIndex(e => e.RfidTag).IsUnique();
            entity.Property(e => e.PersonalNumber).IsRequired().HasMaxLength(50);
            entity.Property(e => e.PasswordHash).IsRequired();
            entity.Property(e => e.Role).HasConversion<int>();
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.RfidTag).HasMaxLength(100);
        });

        modelBuilder.Entity<UserActionLog>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasIndex(e => e.Timestamp);
            entity.HasIndex(e => e.UserId);
            entity.Property(e => e.Action).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Details).HasMaxLength(500);
            entity.Property(e => e.PersonalNumber).HasMaxLength(50);
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.HasOne(e => e.User)
                .WithMany(u => u.ActionLogs)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        SeedDefaultSettings(modelBuilder);
        TranslationSeeder.SeedLanguagesAndTranslations(modelBuilder);
    }

    private static void SeedDefaultSettings(ModelBuilder modelBuilder)
    {
        var now = DateTime.UtcNow;
        var settings = new List<Setting>
        {
            new()
            {
                Id = 1,
                SettingKey = "robot.connection.ip",
                SettingValue = "192.168.1.1",
                ValueType = "string",
                Category = "robot",
                Description = "IP-Adresse des FANUC Roboters",
                DefaultValue = "192.168.1.1",
                CreatedAt = now,
                UpdatedAt = now,
                IsSystemSetting = false
            },
            new()
            {
                Id = 2,
                SettingKey = "robot.connection.timeout",
                SettingValue = "2000",
                ValueType = "number",
                Category = "robot",
                Description = "Verbindungs-Timeout in Millisekunden",
                DefaultValue = "2000",
                CreatedAt = now,
                UpdatedAt = now,
                IsSystemSetting = true
            },
            new()
            {
                Id = 3,
                SettingKey = "robot.connection.autoConnect",
                SettingValue = "false",
                ValueType = "boolean",
                Category = "robot",
                Description = "Automatische Verbindung beim Start",
                DefaultValue = "false",
                CreatedAt = now,
                UpdatedAt = now,
                IsSystemSetting = false
            },
            new()
            {
                Id = 4,
                SettingKey = "monitoring.updateInterval",
                SettingValue = "500",
                ValueType = "number",
                Category = "monitoring",
                Description = "Update-Intervall für Register-Polling in ms",
                DefaultValue = "500",
                CreatedAt = now,
                UpdatedAt = now,
                IsSystemSetting = true
            },
            new()
            {
                Id = 5,
                SettingKey = "ui.language",
                SettingValue = "de",
                ValueType = "string",
                Category = "ui",
                Description = "Sprache der Benutzeroberfläche",
                DefaultValue = "de",
                CreatedAt = now,
                UpdatedAt = now,
                IsSystemSetting = false
            },
            new()
            {
                Id = 6,
                SettingKey = "ui.theme",
                SettingValue = "light",
                ValueType = "string",
                Category = "ui",
                Description = "Theme der Benutzeroberfläche",
                DefaultValue = "light",
                CreatedAt = now,
                UpdatedAt = now,
                IsSystemSetting = false
            },
            new()
            {
                Id = 7,
                SettingKey = "logging.maxErrorLogDays",
                SettingValue = "90",
                ValueType = "number",
                Category = "logging",
                Description = "Maximale Aufbewahrungszeit für Fehlerprotokolle in Tagen",
                DefaultValue = "90",
                CreatedAt = now,
                UpdatedAt = now,
                IsSystemSetting = true
            }
        };

        modelBuilder.Entity<Setting>().HasData(settings);
    }
}
