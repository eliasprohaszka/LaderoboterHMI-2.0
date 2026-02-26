using Microsoft.EntityFrameworkCore;
using Laderoboter.Core.Data;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public class ErrorLogService : IErrorLogService
{
    private readonly LaderoboterDbContext _context;

    public ErrorLogService(LaderoboterDbContext context)
    {
        _context = context;
    }

    public async Task LogAsync(string message, ErrorSeverity severity = ErrorSeverity.Error,
        ErrorSource source = ErrorSource.System, string? errorCode = null,
        int? registerAddress = null, int? registerValue = null)
    {
        var errorLog = new ErrorLog
        {
            ErrorMessage = message,
            Severity = severity,
            Source = source,
            ErrorCode = errorCode,
            RegisterAddress = registerAddress,
            RegisterValue = registerValue,
            Timestamp = DateTime.UtcNow
        };

        _context.ErrorLogs.Add(errorLog);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ErrorLog>> GetAllAsync(int page = 1, int pageSize = 50)
    {
        return await _context.ErrorLogs
            .AsNoTracking()
            .OrderByDescending(e => e.Timestamp)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IEnumerable<ErrorLog>> GetBySeverityAsync(ErrorSeverity severity, int page = 1, int pageSize = 50)
    {
        return await _context.ErrorLogs
            .AsNoTracking()
            .Where(e => e.Severity == severity)
            .OrderByDescending(e => e.Timestamp)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<IEnumerable<ErrorLog>> GetUnacknowledgedAsync()
    {
        return await _context.ErrorLogs
            .AsNoTracking()
            .Where(e => e.AcknowledgedAt == null)
            .OrderByDescending(e => e.Timestamp)
            .ToListAsync();
    }

    public async Task<int> GetTotalCountAsync()
    {
        return await _context.ErrorLogs.CountAsync();
    }

    public async Task AcknowledgeAsync(int id, string? acknowledgedBy = null)
    {
        var errorLog = await _context.ErrorLogs.FindAsync(id);
        if (errorLog != null)
        {
            errorLog.AcknowledgedAt = DateTime.UtcNow;
            errorLog.AcknowledgedBy = acknowledgedBy;
            await _context.SaveChangesAsync();
        }
    }

    public async Task ResolveAsync(int id, string? resolutionNotes = null)
    {
        var errorLog = await _context.ErrorLogs.FindAsync(id);
        if (errorLog != null)
        {
            errorLog.ResolvedAt = DateTime.UtcNow;
            errorLog.ResolutionNotes = resolutionNotes;
            await _context.SaveChangesAsync();
        }
    }

    public async Task DeleteOldLogsAsync(int daysToKeep)
    {
        var cutoffDate = DateTime.UtcNow.AddDays(-daysToKeep);
        var oldLogs = await _context.ErrorLogs
            .Where(e => e.Timestamp < cutoffDate)
            .ToListAsync();

        _context.ErrorLogs.RemoveRange(oldLogs);
        await _context.SaveChangesAsync();
    }

    public async Task ClearAllAsync()
    {
        _context.ErrorLogs.RemoveRange(_context.ErrorLogs);
        await _context.SaveChangesAsync();
    }
}
