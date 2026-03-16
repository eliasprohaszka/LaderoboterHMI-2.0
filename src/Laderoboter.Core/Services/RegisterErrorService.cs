using Laderoboter.Core.Events;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service for monitoring Register 80 errors and handling the R182/R82 handshake protocol.
/// Reads from RegisterCacheService instead of polling directly.
/// </summary>
public class RegisterErrorService : IRegisterErrorService
{
    private readonly IRobotService _robotService;
    private readonly IRegisterCacheService _registerCache;
    private readonly ITranslationService _translationService;
    private int _currentErrorCode;
    private string? _currentErrorMessage;
    private bool _isClearingError;
    private bool _disposed;
    private DateTime? _errorOccurredAt;
    private bool _isAcknowledged;
    private DateTime? _acknowledgedAt;

    // Error codes that reset automatically (30, 40, 41)
    private static readonly HashSet<int> SelfResettingErrorCodes = [30, 40, 41];

    public RegisterErrorService(
        IRobotService robotService,
        IRegisterCacheService registerCache,
        ITranslationService translationService)
    {
        _robotService = robotService;
        _registerCache = registerCache;
        _translationService = translationService;

        // Subscribe to cache updates
        _registerCache.CacheUpdated += OnCacheUpdated;

        // Subscribe to robot status changes to clear errors when disconnected
        _robotService.StatusChanged += OnRobotStatusChanged;

        // Read initial value from cache if available (in case we missed the first CacheUpdated event)
        TryReadInitialValue();
    }

    private void TryReadInitialValue()
    {
        if (_registerCache.HasValidData)
        {
            var initialErrorCode = _registerCache.GetRegister(80);
            UpdateErrorState(initialErrorCode ?? 0);
        }
    }

    private void OnRobotStatusChanged(object? sender, RobotStatusChangedEventArgs e)
    {
        if (_disposed)
            return;

        if (!e.Status.IsConnected)
        {
            // Clear error state when disconnected
            if (_currentErrorCode != 0)
            {
                _currentErrorCode = 0;
                _currentErrorMessage = null;
                _errorOccurredAt = null;
                _isAcknowledged = false;
                _acknowledgedAt = null;
                OnErrorChanged();
            }
        }
    }

    public int CurrentErrorCode => _currentErrorCode;

    public string? CurrentErrorMessage => _currentErrorMessage;

    public bool HasActiveError => _currentErrorCode > 0;

    public bool IsClearingError => _isClearingError;

    public bool IsSelfResettingError => SelfResettingErrorCodes.Contains(_currentErrorCode);

    public DateTime? ErrorOccurredAt => _errorOccurredAt;

    public bool IsAcknowledged => _isAcknowledged;

    public DateTime? AcknowledgedAt => _acknowledgedAt;

    public event EventHandler<RegisterErrorChangedEventArgs>? ErrorChanged;

    private void OnCacheUpdated(object? sender, RegistersCacheUpdatedEventArgs e)
    {
        if (_disposed || _isClearingError)
            return;

        // Read R80 from cache
        var errorCode = _registerCache.GetRegister(80);
        UpdateErrorState(errorCode ?? 0);
    }

    public Task RefreshAsync()
    {
        if (!_robotService.IsConnected)
        {
            if (_currentErrorCode != 0)
            {
                _currentErrorCode = 0;
                _currentErrorMessage = null;
                OnErrorChanged();
            }
            return Task.CompletedTask;
        }

        // Read from cache
        var errorCode = _registerCache.GetRegister(80);
        UpdateErrorState(errorCode ?? 0);
        return Task.CompletedTask;
    }

    public async Task<bool> ClearErrorAsync()
    {
        if (!_robotService.IsConnected || !HasActiveError || _isClearingError)
            return false;

        try
        {
            _isClearingError = true;
            OnErrorChanged();

            var success = await _robotService.StartErrorClearHandshakeAsync();

            if (success)
            {
                // Force a cache refresh to get the new state
                await _registerCache.RefreshAsync();
                await RefreshAsync();
            }

            return success;
        }
        finally
        {
            _isClearingError = false;
            OnErrorChanged();
        }
    }

    public void AcknowledgeError()
    {
        if (!HasActiveError || _isAcknowledged)
            return;

        _isAcknowledged = true;
        _acknowledgedAt = DateTime.UtcNow;
        OnErrorChanged();
    }

    private void UpdateErrorState(int errorCode)
    {
        if (_currentErrorCode == errorCode)
            return;

        var previousErrorCode = _currentErrorCode;
        _currentErrorCode = errorCode;

        if (errorCode > 0)
        {
            // New error occurred - record time and reset acknowledged state
            if (previousErrorCode != errorCode)
            {
                _errorOccurredAt = DateTime.UtcNow;
                _isAcknowledged = false;
                _acknowledgedAt = null;
            }

            // Get translated error message
            var key = $"errors.{errorCode:D3}";
            _currentErrorMessage = _translationService.Translate(key);

            // If translation not found, use fallback
            if (_currentErrorMessage == key)
            {
                _currentErrorMessage = $"Error {errorCode}";
            }
        }
        else
        {
            // Error cleared
            _currentErrorMessage = null;
            _errorOccurredAt = null;
            _isAcknowledged = false;
            _acknowledgedAt = null;
        }

        OnErrorChanged();
    }

    private void OnErrorChanged()
    {
        ErrorChanged?.Invoke(this, new RegisterErrorChangedEventArgs
        {
            ErrorCode = _currentErrorCode,
            ErrorMessage = _currentErrorMessage,
            OccurredAt = _errorOccurredAt,
            IsAcknowledged = _isAcknowledged
        });
    }

    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;

        _registerCache.CacheUpdated -= OnCacheUpdated;
        _robotService.StatusChanged -= OnRobotStatusChanged;
        GC.SuppressFinalize(this);
    }
}
