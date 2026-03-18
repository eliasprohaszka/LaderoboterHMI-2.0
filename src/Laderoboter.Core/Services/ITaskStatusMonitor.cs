using Laderoboter.Core.Events;

namespace Laderoboter.Core.Services;

/// <summary>
/// Monitors the FANUC robot task status via SNPX to detect if MAIN program is running.
/// This enables automatic switching between runtime registers (R50-65) and idle registers (R150-165).
/// </summary>
public interface ITaskStatusMonitor
{
    /// <summary>
    /// Indicates if the MAIN program is currently running (not paused, not stopped).
    /// </summary>
    bool IsMainProgramRunning { get; }

    /// <summary>
    /// Indicates if the MAIN program is currently paused.
    /// </summary>
    bool IsMainProgramPaused { get; }

    /// <summary>
    /// The name of the currently running program (if any).
    /// </summary>
    string? CurrentProgramName { get; }

    /// <summary>
    /// Fired when the MAIN program status changes (started, stopped, paused, resumed).
    /// </summary>
    event EventHandler<MainProgramStatusChangedEventArgs>? MainProgramStatusChanged;

    /// <summary>
    /// Start monitoring task status. Should be called after robot connection is established.
    /// </summary>
    void Start();

    /// <summary>
    /// Stop monitoring task status. Should be called when robot disconnects.
    /// </summary>
    void Stop();
}
