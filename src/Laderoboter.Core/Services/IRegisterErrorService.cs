namespace Laderoboter.Core.Services;

/// <summary>
/// Event arguments for register error state changes
/// </summary>
public class RegisterErrorChangedEventArgs : EventArgs
{
    public int ErrorCode { get; init; }
    public string? ErrorMessage { get; init; }
    public DateTime? OccurredAt { get; init; }
    public bool IsAcknowledged { get; init; }
    public bool HasError => ErrorCode > 0;
}

/// <summary>
/// Service for monitoring and clearing user-defined errors from Register 80.
/// These errors are separate from FANUC system alarms and require a different reset mechanism.
/// </summary>
public interface IRegisterErrorService : IDisposable
{
    /// <summary>
    /// Current error code from Register 80 (0 = no error)
    /// </summary>
    int CurrentErrorCode { get; }

    /// <summary>
    /// Translated error message for the current error code
    /// </summary>
    string? CurrentErrorMessage { get; }

    /// <summary>
    /// Whether there is an active error (ErrorCode > 0)
    /// </summary>
    bool HasActiveError { get; }

    /// <summary>
    /// Whether the error clear handshake is currently in progress
    /// </summary>
    bool IsClearingError { get; }

    /// <summary>
    /// Whether the current error is self-resetting (errors 30, 40, 41)
    /// </summary>
    bool IsSelfResettingError { get; }

    /// <summary>
    /// When the current error first occurred
    /// </summary>
    DateTime? ErrorOccurredAt { get; }

    /// <summary>
    /// Whether the current error has been acknowledged (user has seen it)
    /// </summary>
    bool IsAcknowledged { get; }

    /// <summary>
    /// When the error was acknowledged
    /// </summary>
    DateTime? AcknowledgedAt { get; }

    /// <summary>
    /// Fired when the error state changes
    /// </summary>
    event EventHandler<RegisterErrorChangedEventArgs>? ErrorChanged;

    /// <summary>
    /// Acknowledges that the user has seen the current error
    /// </summary>
    void AcknowledgeError();

    /// <summary>
    /// Refreshes the error state by reading Register 80
    /// </summary>
    Task RefreshAsync();

    /// <summary>
    /// Clears the current error using the R182/R82 handshake protocol
    /// </summary>
    /// <returns>True if error was successfully cleared</returns>
    Task<bool> ClearErrorAsync();
}
