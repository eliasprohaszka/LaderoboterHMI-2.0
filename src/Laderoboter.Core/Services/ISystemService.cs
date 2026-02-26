namespace Laderoboter.Core.Services;

public interface ISystemService
{
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
