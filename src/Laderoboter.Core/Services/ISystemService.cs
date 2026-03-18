namespace Laderoboter.Core.Services;

public interface ISystemService
{
    /// <summary>
    /// Gets the application version from the entry assembly.
    /// </summary>
    string ApplicationVersion { get; }

    /// <summary>
    /// Gets the application copyright from the entry assembly.
    /// </summary>
    string ApplicationCopyright { get; }

    /// <summary>
    /// Initiates a system shutdown with the specified delay in seconds.
    /// </summary>
    Task<bool> ShutdownAsync(int delaySeconds = 15);

    /// <summary>
    /// Initiates a system restart with the specified delay in seconds.
    /// </summary>
    Task<bool> RestartAsync(int delaySeconds = 15);

    /// <summary>
    /// Cancels a pending shutdown or restart.
    /// </summary>
    Task<bool> CancelShutdownAsync();
}
