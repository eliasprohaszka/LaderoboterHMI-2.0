using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service für Benutzeraktions-Protokollierung
/// </summary>
public class UserActionLogService : IUserActionLogService
{
    private readonly IDbContextFactory<LaderoboterDbContext> _contextFactory;
    private readonly IAuthService _authService;

    public UserActionLogService(
        IDbContextFactory<LaderoboterDbContext> contextFactory,
        IAuthService authService)
    {
        _contextFactory = contextFactory;
        _authService = authService;
    }

    public async Task LogActionAsync(int userId, string action, string? details = null, string? ipAddress = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var user = await context.Users.FindAsync(userId);

        var log = new UserActionLog
        {
            UserId = userId,
            PersonalNumber = user?.PersonalNumber,
            Action = action,
            Details = details,
            IpAddress = ipAddress,
            Timestamp = DateTime.UtcNow
        };

        context.UserActionLogs.Add(log);
        await context.SaveChangesAsync();
    }

    public async Task LogActionAsync(string action, string? details = null, string? ipAddress = null)
    {
        var currentUser = await _authService.GetCurrentUserAsync();
        if (currentUser != null)
        {
            await LogActionAsync(currentUser.Id, action, details, ipAddress);
        }
        else
        {
            // Log without user reference
            await using var context = await _contextFactory.CreateDbContextAsync();

            var log = new UserActionLog
            {
                UserId = null,
                PersonalNumber = null,
                Action = action,
                Details = details,
                IpAddress = ipAddress,
                Timestamp = DateTime.UtcNow
            };

            context.UserActionLogs.Add(log);
            await context.SaveChangesAsync();
        }
    }

    public async Task LogActionWithPersonalNumberAsync(string personalNumber, string action, string? details = null, string? ipAddress = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var user = await context.Users.FirstOrDefaultAsync(u => u.PersonalNumber == personalNumber);

        var log = new UserActionLog
        {
            UserId = user?.Id,
            PersonalNumber = personalNumber,
            Action = action,
            Details = details,
            IpAddress = ipAddress,
            Timestamp = DateTime.UtcNow
        };

        context.UserActionLogs.Add(log);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<UserActionLog>> GetLogsAsync(int? userId = null, DateTime? from = null, DateTime? to = null)
    {
        await using var context = await _contextFactory.CreateDbContextAsync();

        var query = context.UserActionLogs
            .Include(l => l.User)
            .AsQueryable();

        if (userId.HasValue)
        {
            query = query.Where(l => l.UserId == userId.Value);
        }

        if (from.HasValue)
        {
            query = query.Where(l => l.Timestamp >= from.Value);
        }

        if (to.HasValue)
        {
            query = query.Where(l => l.Timestamp <= to.Value);
        }

        return await query
            .OrderByDescending(l => l.Timestamp)
            .ToListAsync();
    }
}
