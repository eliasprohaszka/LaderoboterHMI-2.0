namespace Laderoboter.Core.Services;

/// <summary>
/// Event args for when the autostop handshake is completed
/// </summary>
public class AutostopHandshakeCompletedEventArgs : EventArgs
{
    public DateTime Timestamp { get; init; } = DateTime.UtcNow;
}

/// <summary>
/// Service that monitors the autostop handshake between HMI and robot.
///
/// Handshake flow:
/// 1. HMI sets R186 = 1 (autostop request)
/// 2. Robot program detects R186 = 1, stops gracefully, and sets R86 = 1 (confirmation)
/// 3. This service detects R86 = 1, resets R186 = 0, and fires HandshakeCompleted event
/// </summary>
public interface IAutostopHandshakeService : IDisposable
{
    /// <summary>
    /// Whether an autostop is currently in progress (R186 = 1, waiting for R86 = 1)
    /// </summary>
    bool IsAutostopActive { get; }

    /// <summary>
    /// Initiates an autostop by setting R186 = 1 and starting to monitor R86
    /// </summary>
    /// <returns>True if R186 was successfully set</returns>
    Task<bool> StartAutostopAsync();

    /// <summary>
    /// Cancels a pending autostop by resetting R186 = 0
    /// </summary>
    Task CancelAutostopAsync();

    /// <summary>
    /// Fired when the handshake is completed (R86 = 1 detected, R186 reset to 0)
    /// </summary>
    event EventHandler<AutostopHandshakeCompletedEventArgs>? HandshakeCompleted;
}
