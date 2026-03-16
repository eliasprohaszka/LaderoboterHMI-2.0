using UnderAutomation.Fanuc;

namespace Laderoboter.Core.Services;

/// <summary>
/// Caches all robot registers (1-200) and fires events when values change.
/// Reads DIRECTLY from SDK once per second - no queue needed.
/// This is the SINGLE source of truth for register values.
/// </summary>
public class RegisterCacheService : IRegisterCacheService
{
    private readonly IRobotService _robotService;
    private System.Threading.Timer? _refreshTimer;
    private readonly object _cacheLock = new();
    private readonly object _refreshLock = new();

    // Cache storage - we read registers 1-200
    private const int REGISTER_START = 1;
    private const int REGISTER_COUNT = 200;
    private const int REFRESH_INTERVAL_MS = 1000; // 1 second
    private const int INITIAL_DELAY_AFTER_CONNECT_MS = 1500; // Warte nach Connect bevor erster Read

    private int[]? _cachedValues;
    private int[]? _previousValues; // For change detection
    private DateTime _lastUpdateTime;
    private bool _disposed;
    private bool _timerStarted;

    // Direct SDK access
    private dynamic? _registerBatch;

    public RegisterCacheService(IRobotService robotService)
    {
        _robotService = robotService;

        // Subscribe to connection changes - Timer startet erst bei Connect
        _robotService.StatusChanged += OnRobotStatusChanged;
    }

    public bool HasValidData
    {
        get
        {
            lock (_cacheLock)
            {
                return _cachedValues != null && _robotService.IsConnected;
            }
        }
    }

    public DateTime LastUpdateTime
    {
        get
        {
            lock (_cacheLock)
            {
                return _lastUpdateTime;
            }
        }
    }

    public event EventHandler<RegistersCacheUpdatedEventArgs>? CacheUpdated;
    public event EventHandler<RegisterChangedEventArgs>? RegisterChanged;

    public int? GetRegister(int address)
    {
        if (address < REGISTER_START || address >= REGISTER_START + REGISTER_COUNT)
            return null;

        lock (_cacheLock)
        {
            if (_cachedValues == null)
                return null;

            int index = address - REGISTER_START;
            return _cachedValues[index];
        }
    }

    public int[]? GetRegisters(int startAddress, int count)
    {
        if (startAddress < REGISTER_START || startAddress + count > REGISTER_START + REGISTER_COUNT)
            return null;

        lock (_cacheLock)
        {
            if (_cachedValues == null)
                return null;

            int startIndex = startAddress - REGISTER_START;
            var result = new int[count];
            Array.Copy(_cachedValues, startIndex, result, 0, count);
            return result;
        }
    }

    public Task RefreshAsync()
    {
        RefreshCacheDirect();
        return Task.CompletedTask;
    }

    private void OnRobotStatusChanged(object? sender, Events.RobotStatusChangedEventArgs e)
    {
        Console.WriteLine($"[RegisterCacheService] StatusChanged: IsConnected={e.Status.IsConnected}, _timerStarted={_timerStarted}");

        if (e.Status.IsConnected)
        {
            if (!_timerStarted)
            {
                // Verbindung hergestellt - Timer mit Verzögerung starten
                // Gibt dem Roboter Zeit sich zu stabilisieren bevor wir SNPX-Reads machen
                _timerStarted = true;
                _refreshTimer = new System.Threading.Timer(
                    RefreshTimerCallback,
                    null,
                    TimeSpan.FromMilliseconds(INITIAL_DELAY_AFTER_CONNECT_MS),
                    TimeSpan.FromMilliseconds(REFRESH_INTERVAL_MS));

                Console.WriteLine($"[RegisterCacheService] Timer gestartet mit {INITIAL_DELAY_AFTER_CONNECT_MS}ms Initial-Delay");
            }
        }
        else
        {
            // Verbindung getrennt - Timer stoppen und Cache leeren
            if (_refreshTimer != null)
            {
                _refreshTimer.Dispose();
                _refreshTimer = null;
            }
            _timerStarted = false;

            lock (_cacheLock)
            {
                _cachedValues = null;
                _previousValues = null;
                _registerBatch = null;
            }

            Console.WriteLine("[RegisterCacheService] Timer gestoppt, Cache geleert");
        }
    }

    private void RefreshTimerCallback(object? state)
    {
        if (_disposed || !_robotService.IsConnected)
            return;

        // Use lock to prevent overlapping refreshes
        if (!Monitor.TryEnter(_refreshLock))
            return; // Skip if already refreshing

        try
        {
            RefreshCacheDirect();
        }
        finally
        {
            Monitor.Exit(_refreshLock);
        }
    }

    private void RefreshCacheDirect()
    {
        if (!_robotService.IsConnected)
        {
            Console.WriteLine("[RegisterCacheService] Not connected, skipping refresh");
            return;
        }

        try
        {
            // Access the robot directly via reflection
            var robotField = _robotService.GetType().GetField("_robot",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (robotField == null)
            {
                Console.WriteLine("[RegisterCacheService] Could not find _robot field via reflection");
                return;
            }

            var robot = robotField.GetValue(_robotService) as FanucRobot;
            if (robot == null)
            {
                Console.WriteLine("[RegisterCacheService] Robot is null");
                return;
            }
            if (robot.Snpx == null || !robot.Snpx.Connected)
            {
                Console.WriteLine("[RegisterCacheService] Snpx not connected");
                return;
            }

            // Create batch assignment if needed (immer neu erstellen bei Reconnect)
            // Das Batch muss zum aktuellen Robot-Objekt gehören
            if (_registerBatch == null)
            {
                Console.WriteLine("[RegisterCacheService] Erstelle neues BatchAssignment");
                _registerBatch = robot.Snpx.NumericRegisters.CreateBatchAssignment(REGISTER_START, REGISTER_COUNT);
            }

            // Direct SDK read
            float[] floatValues = _registerBatch.Read();

            if (floatValues == null || floatValues.Length != REGISTER_COUNT)
                return;

            // Convert to int array
            var newValues = new int[REGISTER_COUNT];
            for (int i = 0; i < REGISTER_COUNT; i++)
            {
                newValues[i] = (int)floatValues[i];
            }

            // Detect changes
            var changedRegisters = new List<RegisterChangedEventArgs>();

            lock (_cacheLock)
            {
                for (int i = 0; i < REGISTER_COUNT; i++)
                {
                    int address = REGISTER_START + i;
                    int newValue = newValues[i];
                    int? oldValue = _previousValues?[i];

                    // First read or value changed
                    if (_previousValues == null || _previousValues[i] != newValue)
                    {
                        changedRegisters.Add(new RegisterChangedEventArgs
                        {
                            Address = address,
                            OldValue = oldValue,
                            NewValue = newValue
                        });
                    }
                }

                // Update cache
                _previousValues = _cachedValues;
                _cachedValues = newValues;
                _lastUpdateTime = DateTime.UtcNow;
            }

            // Fire individual RegisterChanged events for each changed register
            foreach (var change in changedRegisters)
            {
                RegisterChanged?.Invoke(this, change);
            }

            // Fire batch update event
            CacheUpdated?.Invoke(this, new RegistersCacheUpdatedEventArgs
            {
                UpdatedAt = _lastUpdateTime,
                RegisterCount = REGISTER_COUNT,
                ChangedRegisters = changedRegisters
            });
        }
        catch (Exception ex)
        {
            // SDK error - clear batch so it gets recreated
            _registerBatch = null;
            Console.WriteLine($"[RegisterCacheService] Error reading registers: {ex.Message}");
        }
    }

    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;

        _refreshTimer?.Dispose();
        _robotService.StatusChanged -= OnRobotStatusChanged;

        lock (_cacheLock)
        {
            _cachedValues = null;
            _previousValues = null;
            _registerBatch = null;
        }

        GC.SuppressFinalize(this);
    }
}
