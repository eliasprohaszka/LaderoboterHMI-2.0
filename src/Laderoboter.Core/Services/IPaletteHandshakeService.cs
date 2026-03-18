namespace Laderoboter.Core.Services;

/// <summary>
/// Event args for when palette data handshake completes.
/// </summary>
public class PaletteHandshakeCompletedEventArgs : EventArgs
{
    public DateTime Timestamp { get; set; }
}

/// <summary>
/// Monitors the palette data handshake between HMI and robot using the register cache.
///
/// This service handles the case when:
/// 1. MAIN program was NOT running when workpiece status was changed (R148 = 1 was set)
/// 2. MAIN program STARTS
/// 3. Robot copies R150-R165 → R50-R65 and sets R48 = 1
/// 4. This service detects R48 = 1 and resets R148 = 0 (acknowledge)
///
/// Register protocol:
/// - R148 = 1: HMI signals that modified data is available in R150-R165
/// - R149 = 1: HMI signals modification in progress (only used during active write)
/// - R48 = 1: Robot signals that it has copied data from R150-R165 to R50-R65
/// </summary>
public interface IPaletteHandshakeService : IDisposable
{
    /// <summary>
    /// Whether there is pending data waiting for robot to copy (R148 = 1).
    /// </summary>
    bool HasPendingData { get; }

    /// <summary>
    /// Fired when the robot has copied the palette data and handshake is complete.
    /// </summary>
    event EventHandler<PaletteHandshakeCompletedEventArgs>? HandshakeCompleted;
}
