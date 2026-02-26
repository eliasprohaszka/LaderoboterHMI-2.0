using Laderoboter.Core.Models;

namespace Laderoboter.Core.Events;

public class RobotStatusChangedEventArgs : EventArgs
{
    public required RobotStatus Status { get; init; }
}

public class RegisterChangedEventArgs : EventArgs
{
    public int Address { get; init; }
    public int OldValue { get; init; }
    public int NewValue { get; init; }
    public DateTime Timestamp { get; init; } = DateTime.UtcNow;
}

public class PaletteChangedEventArgs : EventArgs
{
    public required PaletteData Palette1 { get; init; }
    public required PaletteData Palette2 { get; init; }
}

public class ErrorOccurredEventArgs : EventArgs
{
    public required string ErrorCode { get; init; }
    public required string ErrorMessage { get; init; }
    public ErrorSeverity Severity { get; init; }
    public ErrorSource Source { get; init; }
}
