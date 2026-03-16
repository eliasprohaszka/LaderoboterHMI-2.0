namespace Laderoboter.Core.Services;

/// <summary>
/// Event arguments for register value changes
/// </summary>
public class RegisterChangedEventArgs : EventArgs
{
    /// <summary>
    /// The register address that changed
    /// </summary>
    public int Address { get; init; }

    /// <summary>
    /// The previous value (null if first read)
    /// </summary>
    public int? OldValue { get; init; }

    /// <summary>
    /// The new value
    /// </summary>
    public int NewValue { get; init; }
}

/// <summary>
/// Event arguments for batch register updates
/// </summary>
public class RegistersCacheUpdatedEventArgs : EventArgs
{
    public DateTime UpdatedAt { get; init; }
    public int RegisterCount { get; init; }

    /// <summary>
    /// List of registers that changed in this update
    /// </summary>
    public IReadOnlyList<RegisterChangedEventArgs> ChangedRegisters { get; init; } = [];
}

/// <summary>
/// Service that caches robot register values.
/// Reads all registers once per second and fires events when values change.
/// This is the SINGLE source of truth for register values - no polling needed elsewhere.
/// </summary>
public interface IRegisterCacheService : IDisposable
{
    /// <summary>
    /// Gets a cached register value. Returns null if not available or robot not connected.
    /// </summary>
    int? GetRegister(int address);

    /// <summary>
    /// Gets multiple cached register values.
    /// </summary>
    int[]? GetRegisters(int startAddress, int count);

    /// <summary>
    /// Whether the cache has valid data
    /// </summary>
    bool HasValidData { get; }

    /// <summary>
    /// Last time the cache was updated
    /// </summary>
    DateTime LastUpdateTime { get; }

    /// <summary>
    /// Fired when the cache is updated (every second).
    /// Contains list of changed registers.
    /// </summary>
    event EventHandler<RegistersCacheUpdatedEventArgs>? CacheUpdated;

    /// <summary>
    /// Fired when a specific register value changes.
    /// Subscribe to this for reactive updates.
    /// </summary>
    event EventHandler<RegisterChangedEventArgs>? RegisterChanged;

    /// <summary>
    /// Forces an immediate cache refresh
    /// </summary>
    Task RefreshAsync();
}
