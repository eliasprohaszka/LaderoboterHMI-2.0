using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public interface IErrorLogService
{
    Task LogAsync(string message, ErrorSeverity severity = ErrorSeverity.Error,
        ErrorSource source = ErrorSource.System, string? errorCode = null,
        int? registerAddress = null, int? registerValue = null);

    Task<IEnumerable<ErrorLog>> GetAllAsync(int page = 1, int pageSize = 50);
    Task<IEnumerable<ErrorLog>> GetBySeverityAsync(ErrorSeverity severity, int page = 1, int pageSize = 50);
    Task<IEnumerable<ErrorLog>> GetUnacknowledgedAsync();
    Task<int> GetTotalCountAsync();
    Task AcknowledgeAsync(int id, string? acknowledgedBy = null);
    Task ResolveAsync(int id, string? resolutionNotes = null);
    Task DeleteOldLogsAsync(int daysToKeep);
    Task ClearAllAsync();
}
