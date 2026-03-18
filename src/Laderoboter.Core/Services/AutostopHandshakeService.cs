namespace Laderoboter.Core.Services;

/// <summary>
/// Monitors the autostop handshake between HMI and robot using the register cache.
///
/// Handshake flow:
/// 1. HMI sets R186 = 1 (autostop request)
/// 2. Robot program detects R186 = 1, stops gracefully, and sets R86 = 1 (confirmation)
/// 3. This service detects R86 = 1, resets R186 = 0, and fires HandshakeCompleted event
/// </summary>
public class AutostopHandshakeService : IAutostopHandshakeService
{
    private const int AUTOSTOP_REQUEST_REGISTER = 186;  // HMI -> Robot
    private const int AUTOSTOP_CONFIRM_REGISTER = 86;   // Robot -> HMI

    private readonly IRobotService _robotService;
    private readonly IRegisterCacheService _registerCache;

    private bool _isAutostopActive;
    private bool _disposed;

    public bool IsAutostopActive => _isAutostopActive;

    public event EventHandler<AutostopHandshakeCompletedEventArgs>? HandshakeCompleted;

    public AutostopHandshakeService(IRobotService robotService, IRegisterCacheService registerCache)
    {
        _robotService = robotService;
        _registerCache = registerCache;

        // Subscribe to register changes
        _registerCache.RegisterChanged += OnRegisterChanged;
    }

    public async Task<bool> StartAutostopAsync()
    {
        if (_isAutostopActive)
        {
            Console.WriteLine("[AutostopHandshake] Autostop already active");
            return true;
        }

        Console.WriteLine("[AutostopHandshake] Starting autostop - setting R186 = 1");

        var result = await _robotService.WriteRegisterAsync(AUTOSTOP_REQUEST_REGISTER, 1);

        if (result)
        {
            _isAutostopActive = true;
            Console.WriteLine("[AutostopHandshake] R186 = 1 set successfully, waiting for R86 = 1");
        }
        else
        {
            Console.WriteLine("[AutostopHandshake] Failed to set R186 = 1");
        }

        return result;
    }

    public async Task CancelAutostopAsync()
    {
        if (!_isAutostopActive)
        {
            return;
        }

        Console.WriteLine("[AutostopHandshake] Cancelling autostop - resetting R186 = 0");

        await _robotService.WriteRegisterAsync(AUTOSTOP_REQUEST_REGISTER, 0);
        _isAutostopActive = false;
    }

    private async void OnRegisterChanged(object? sender, RegisterChangedEventArgs e)
    {
        // Only process R86 changes when autostop is active
        if (!_isAutostopActive || e.Address != AUTOSTOP_CONFIRM_REGISTER)
        {
            return;
        }

        // R86 = 1 means robot has confirmed the stop
        if (e.NewValue == 1)
        {
            Console.WriteLine("[AutostopHandshake] R86 = 1 detected - robot confirmed stop");

            // Complete the handshake by resetting R186 = 0
            await _robotService.WriteRegisterAsync(AUTOSTOP_REQUEST_REGISTER, 0);
            Console.WriteLine("[AutostopHandshake] R186 = 0 - handshake completed");

            _isAutostopActive = false;

            // Fire the completion event
            HandshakeCompleted?.Invoke(this, new AutostopHandshakeCompletedEventArgs
            {
                Timestamp = DateTime.UtcNow
            });
        }
    }

    public void Dispose()
    {
        if (_disposed) return;

        _registerCache.RegisterChanged -= OnRegisterChanged;
        _disposed = true;
    }
}
