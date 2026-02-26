namespace Laderoboter.Core.Models;

public class ErrorLog
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    public string? ErrorCode { get; set; }
    public required string ErrorMessage { get; set; }
    public ErrorSeverity Severity { get; set; } = ErrorSeverity.Error;
    public ErrorSource Source { get; set; } = ErrorSource.System;
    public int? RegisterAddress { get; set; }
    public int? RegisterValue { get; set; }
    public DateTime? AcknowledgedAt { get; set; }
    public string? AcknowledgedBy { get; set; }
    public DateTime? ResolvedAt { get; set; }
    public string? ResolutionNotes { get; set; }
}

public enum ErrorSeverity
{
    Info,
    Warning,
    Error,
    Critical
}

public enum ErrorSource
{
    Robot,
    System,
    User
}
