namespace Laderoboter.Core.Services;

/// <summary>
/// Monitors the palette data handshake between HMI and robot using the register cache.
///
/// Handshake flow when MAIN starts with pending data (R148 = 1):
/// 1. MAIN program starts
/// 2. Robot detects R148 = 1, copies R150-R165 → R50-R65
/// 3. Robot sets R48 = 1 (confirmation that data was copied)
/// 4. This service detects R48 >= 1, resets R148 = 0, and fires HandshakeCompleted event
/// </summary>
public class PaletteHandshakeService : IPaletteHandshakeService
{
    private const int R148_MODED_PAL_STATES = 148;  // HMI -> Robot: Modified data available
    private const int R48_COPIED_PAL_STATES = 48;   // Robot -> HMI: Data has been copied

    private readonly IRobotService _robotService;
    private readonly IRegisterCacheService _registerCache;

    private bool _hasPendingData;
    private bool _disposed;

    public bool HasPendingData => _hasPendingData;

    public event EventHandler<PaletteHandshakeCompletedEventArgs>? HandshakeCompleted;

    public PaletteHandshakeService(IRobotService robotService, IRegisterCacheService registerCache)
    {
        _robotService = robotService;
        _registerCache = registerCache;

        // Subscribe to register changes
        _registerCache.RegisterChanged += OnRegisterChanged;
        _registerCache.CacheUpdated += OnCacheUpdated;
    }

    private void OnCacheUpdated(object? sender, RegistersCacheUpdatedEventArgs e)
    {
        // Check initial state of R148 when cache first loads
        var r148 = _registerCache.GetRegister(R148_MODED_PAL_STATES);
        if (r148.HasValue && r148.Value >= 1)
        {
            _hasPendingData = true;
        }
    }

    private async void OnRegisterChanged(object? sender, RegisterChangedEventArgs e)
    {
        // Track R148 changes to know if we have pending data
        if (e.Address == R148_MODED_PAL_STATES)
        {
            _hasPendingData = e.NewValue >= 1;
            Console.WriteLine($"[PaletteHandshake] R148 changed to {e.NewValue}, HasPendingData={_hasPendingData}");
        }

        // When R48 becomes >= 1, the robot has copied the data
        if (e.Address == R48_COPIED_PAL_STATES && e.NewValue >= 1)
        {
            // Only process if we have pending data (R148 = 1)
            var r148 = _registerCache.GetRegister(R148_MODED_PAL_STATES);
            if (r148.HasValue && r148.Value >= 1)
            {
                Console.WriteLine("[PaletteHandshake] R48 >= 1 detected - robot has copied palette data");

                // Complete the handshake by resetting R148 = 0
                await _robotService.WriteRegisterAsync(R148_MODED_PAL_STATES, 0);
                Console.WriteLine("[PaletteHandshake] R148 = 0 - handshake completed");

                _hasPendingData = false;

                // Fire the completion event
                HandshakeCompleted?.Invoke(this, new PaletteHandshakeCompletedEventArgs
                {
                    Timestamp = DateTime.UtcNow
                });
            }
        }
    }

    public void Dispose()
    {
        if (_disposed) return;

        _registerCache.RegisterChanged -= OnRegisterChanged;
        _registerCache.CacheUpdated -= OnCacheUpdated;
        _disposed = true;
    }
}
