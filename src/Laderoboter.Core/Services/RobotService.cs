using UnderAutomation.Fanuc;
using Laderoboter.Core.Events;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

/// <summary>
/// Service für die direkte Kommunikation mit dem FANUC Roboter.
/// Für reaktives Monitoring verwenden Sie IRobotMonitor.
/// </summary>
public class RobotService : IRobotService
{
    // UnderAutomation.Fanuc License - loaded from encrypted license.dat
    private const string LICENSE_COMPANY = "Geibel_Hotz_GmbH_Homberg_DE";

    private readonly IErrorLogService _errorLog;
    private readonly IRobotRequestQueue _requestQueue;
    private FanucRobot? _robot;
    private bool _disposed;
    private bool _isConnected;

    // RegisterCache für Read-Operationen (wird nach Konstruktion gesetzt um zirkuläre Abhängigkeit zu vermeiden)
    private IRegisterCacheService? _registerCache;

    // Door Handshake Monitor
    private System.Threading.Timer? _handshakeTimer;
    private readonly object _handshakeLock = new();
    // Key = statusRegister, Value = (requestRegister, expectedValue)
    private readonly Dictionary<int, (int requestRegister, int expectedValue)> _activeHandshakes = new();
    private const int HANDSHAKE_POLL_INTERVAL_MS = 200;

    // ENTFERNT: Batch Assignments - alle Register werden jetzt über RegisterCacheService gelesen

    // Register addresses (from old app)
    private const int PALETTE_RUNTIME_START = 50;   // 50-65: Palette 1 & 2 wenn Programm läuft
    private const int PALETTE_IDLE_START = 150;     // 150-165: Palette 1 & 2 wenn Programm NICHT läuft
    private const int SHELF_RUNTIME_START = 66;     // 66-93: Regal (7x4=28 Positionen) wenn Programm läuft
    private const int SHELF_IDLE_START = 166;       // 166-193: Regal wenn Programm NICHT läuft
    private const int SHELF_POSITION_COUNT = 28;    // 7 Reihen x 4 Spalten = 28 Positionen
    private const int SEQUENCE_START = 101;
    private const int MODE_REGISTER_1 = 48;
    private const int MODE_REGISTER_2 = 148;
    private const int DOOR_REGISTER = 87;
    private const int LOAD_REGISTER = 88;
    private const int AUTOSTOP_REGISTER_1 = 86;
    private const int AUTOSTOP_REGISTER_2 = 186;
    private const int LAYDOWN_REGISTER_1 = 75;
    private const int LAYDOWN_REGISTER_2 = 175;
    private const int PALETTE_DOOR1_REGISTER_1 = 87;
    private const int PALETTE_DOOR1_REGISTER_2 = 187;

    public RobotService(ISettingsService settings, IErrorLogService errorLog, IRobotRequestQueue requestQueue)
    {
        _errorLog = errorLog;
        _requestQueue = requestQueue;
        Status = new RobotStatus();
        Palette1 = new PaletteData { PaletteNumber = 1 };
        Palette2 = new PaletteData { PaletteNumber = 2 };

        // Initialize license from encrypted file
        LicenseManager.InitUnderAutomation();
        InitializePalettes();
    }

    private void InitializePalettes()
    {
        for (int i = 0; i < 8; i++)
        {
            Palette1.Workpieces.Add(new WorkpieceStatus
            {
                Position = i + 1,
                RegisterAddress = PALETTE_RUNTIME_START + i,
                State = WorkpieceState.Unused
            });

            Palette2.Workpieces.Add(new WorkpieceStatus
            {
                Position = i + 1,
                RegisterAddress = PALETTE_RUNTIME_START + 8 + i,
                State = WorkpieceState.Unused
            });
        }
    }

    private void InitializeBatchAssignments()
    {
        // DEAKTIVIERT: Batch-Assignments wurden entfernt.
        // Alle Register werden jetzt zentral über den RegisterCacheService gelesen,
        // um SNPX-Kommunikationsfehler durch parallele Anfragen zu vermeiden.
        // Der RegisterCacheService liest alle 200 Register in einem einzigen Batch.
    }

    private void DisposeBatchAssignments()
    {
        // ENTFERNT: Batch-Assignments werden nicht mehr verwendet
    }

    public bool IsConnected => _isConnected && _robot != null;
    public RobotStatus Status { get; private set; }
    public PaletteData Palette1 { get; private set; }
    public PaletteData Palette2 { get; private set; }

    /// <summary>
    /// Setzt den RegisterCacheService für Read-Operationen.
    /// Wird nach Konstruktion aufgerufen um zirkuläre Abhängigkeit zu vermeiden.
    /// </summary>
    public void SetRegisterCache(IRegisterCacheService registerCache)
    {
        _registerCache = registerCache;
    }

    public event EventHandler<RobotStatusChangedEventArgs>? StatusChanged;
    public event EventHandler<RegisterChangedEventArgs>? RegisterChanged;
    public event EventHandler<PaletteChangedEventArgs>? PaletteChanged;
    public event EventHandler<ErrorOccurredEventArgs>? ErrorOccurred;

    public async Task<bool> ConnectAsync(string connectionPath, int timeout = 2000)
    {
        try
        {
            _robot = new FanucRobot();

            // Configure connection parameters for v4.4.0 API
            // ConnectionParameters accepts both IP addresses and RoboGuide paths
            // For RoboGuide: Use the path to the Robot_1 folder (not localhost/127.0.0.1)
            // The SDK reads services.txt from that folder to determine correct ports
            var parameters = new ConnectionParameters();
            parameters.Address = connectionPath;

            parameters.Snpx.Enable = true;

            parameters.Telnet.Enable = true;
            parameters.Telnet.TelnetKclPassword = "ADMIN"; // Default KCL password for RoboGuide

            parameters.Ftp.Enable = true;
            parameters.Ftp.FtpUser = "";
            parameters.Ftp.FtpPassword = "";

            // Connect returns void in v4.4.0, use try/catch for error handling
            await Task.Run(() => _robot.Connect(parameters));

            // Check connection status - check all protocols
            bool snpxConnected = _robot.Snpx?.Connected ?? false;
            bool telnetConnected = _robot.Telnet?.Connected ?? false;
            bool ftpConnected = _robot.Ftp?.Connected ?? false;

            _isConnected = _robot.Enabled; // Use general Enabled property

            if (_isConnected)
            {
                // Initialize batch assignments for fast register reading
                InitializeBatchAssignments();

                Status.IsConnected = true;
                Status.IpAddress = connectionPath;
                Status.LastUpdated = DateTime.UtcNow;
                OnStatusChanged();
                return true;
            }
            else
            {
                // Build detailed error message showing which protocols failed
                var failedProtocols = new System.Collections.Generic.List<string>();
                if (!(_robot.Snpx?.Connected ?? false)) failedProtocols.Add("SNPX");
                if (!(_robot.Telnet?.Connected ?? false)) failedProtocols.Add("Telnet");
                if (!(_robot.Ftp?.Connected ?? false)) failedProtocols.Add("FTP");

                Status.ErrorMessage = $"Connection failed. Protocols not connected: {string.Join(", ", failedProtocols)}. " +
                    $"For RoboGuide, ensure it's running and use the Robot folder path (e.g., C:\\Workcells\\Robot_1).";
                await _errorLog.LogAsync($"Connection failed: {Status.ErrorMessage}",
                    ErrorSeverity.Error, ErrorSource.Robot);
                return false;
            }
        }
        catch (Exception ex)
        {
            _isConnected = false;
            Status.ErrorMessage = ex.Message;
            await _errorLog.LogAsync($"Connection error: {ex.Message}",
                ErrorSeverity.Error, ErrorSource.Robot);
            return false;
        }
    }

    public Task DisconnectAsync()
    {
        DisposeBatchAssignments();

        if (_robot != null)
        {
            _robot.Disconnect();
            _robot = null;
        }

        _isConnected = false;
        Status.IsConnected = false;
        Status.LastUpdated = DateTime.UtcNow;
        OnStatusChanged();

        return Task.CompletedTask;
    }

    public async Task<IEnumerable<string>> GetProgramsAsync()
    {
        if (_robot == null || !IsConnected)
            return Enumerable.Empty<string>();

        try
        {
            // Use FTP GetProgramStates to get all loaded programs            
            var states = _robot.Ftp.GetProgramStates();
            return states.TaskStates
                .Select(t => t.Name)
                .Where(n => !string.IsNullOrEmpty(n))
                .ToList();
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to get programs: {ex.Message}",
                ErrorSeverity.Warning, ErrorSource.Robot);
            return Enumerable.Empty<string>();
        }
    }

    public async Task<bool> RunProgramAsync(string programName)
    {
        if (_robot == null || !IsConnected) return false;

        try
        {
            var result = _robot.Telnet.Run(programName);
            Status.IsRunning = result.Succeed;
            Status.CurrentProgram = result.Succeed ? programName : null;
            OnStatusChanged();
            return result.Succeed;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to run program: {ex.Message}",
                ErrorSeverity.Error, ErrorSource.Robot);
            return false;
        }
    }

    public async Task<bool> StopProgramAsync()
    {
        if (_robot == null || !IsConnected) return false;

        try
        {
            var result = _robot.Telnet.Abort();
            if (result.Succeed)
            {
                Status.IsRunning = false;
                Status.CurrentProgram = null;
                OnStatusChanged();
            }
            return result.Succeed;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to stop program: {ex.Message}",
                ErrorSeverity.Error, ErrorSource.Robot);
            return false;
        }
    }

    public async Task<bool> PauseProgramAsync()
    {
        if (_robot == null || !IsConnected) return false;

        try
        {
            var result = _robot.Telnet.Pause();
            return result.Succeed;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to pause program: {ex.Message}",
                ErrorSeverity.Error, ErrorSource.Robot);
            return false;
        }
    }

    public async Task<bool> ResumeProgramAsync()
    {
        if (_robot == null || !IsConnected) return false;

        try
        {
            var result = _robot.Telnet.Continue();
            return result.Succeed;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to resume program: {ex.Message}",
                ErrorSeverity.Error, ErrorSource.Robot);
            return false;
        }
    }

    public async Task<bool> ResetAsync()
    {
        if (_robot == null || !IsConnected) return false;

        try
        {
            var result = _robot.Telnet.Reset();
            if (result.Succeed)
            {
                Status.IsRunning = false;
                Status.CurrentProgram = null;
                OnStatusChanged();
            }
            return result.Succeed;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to reset: {ex.Message}",
                ErrorSeverity.Error, ErrorSource.Robot);
            return false;
        }
    }

    public async Task<bool> SetSpeedOverrideAsync(int speed)
    {
        if (_robot == null || !IsConnected) return false;

        try
        {
            // Use System Variable $MCR.$GENOVERRIDE for speed override
            _robot.Snpx.IntegerSystemVariables.Write("$MCR.$GENOVERRIDE", speed);
            Status.SpeedOverride = speed;
            OnStatusChanged();
            return true;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to set speed: {ex.Message}",
                ErrorSeverity.Warning, ErrorSource.Robot);
            return false;
        }
    }

    public Task<int?> GetSpeedOverrideAsync()
    {
        if (_robot == null || !IsConnected) return Task.FromResult<int?>(null);

        try
        {
            int value = _robot.Snpx.IntegerSystemVariables.Read("$MCR.$GENOVERRIDE");
            return Task.FromResult<int?>(value);
        }
        catch
        {
            return Task.FromResult<int?>(null);
        }
    }

    public Task<int?> ReadRegisterAsync(int address)
    {
        // Lese aus dem RegisterCache statt direkt über SNPX
        if (_registerCache != null && _registerCache.HasValidData)
        {
            return Task.FromResult(_registerCache.GetRegister(address));
        }

        // Fallback wenn Cache nicht verfügbar
        return Task.FromResult<int?>(null);
    }

    public Task<int[]?> ReadRegistersAsync(int startAddress, int count)
    {
        // Lese aus dem RegisterCache statt direkt über SNPX
        if (_registerCache != null && _registerCache.HasValidData)
        {
            return Task.FromResult(_registerCache.GetRegisters(startAddress, count));
        }

        // Fallback wenn Cache nicht verfügbar
        return Task.FromResult<int[]?>(null);
    }

    public async Task<bool> WriteRegisterAsync(int address, int value)
    {
        if (_robot == null || !IsConnected) return false;

        return await _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                _robot.Snpx.NumericRegisters.Write(address, (float)value);
                return true;
            }
            catch (Exception ex)
            {
                await _errorLog.LogAsync($"Failed to write register R[{address}]: {ex.Message}",
                    ErrorSeverity.Warning, ErrorSource.Robot);
                return false;
            }
        });
    }

    public Task<bool?> ReadDigitalInputAsync(int address)
    {
        if (_robot == null || !IsConnected) return Task.FromResult<bool?>(null);

        return _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                bool value = _robot.Snpx.SDI.Read(address);
                return (bool?)value;
            }
            catch
            {
                return (bool?)null;
            }
        });
    }

    public Task<bool[]?> ReadDigitalInputsAsync(int startAddress, int count)
    {
        if (_robot == null || !IsConnected) return Task.FromResult<bool[]?>(null);

        return _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                // Batch-Read für bessere Performance
                bool[] values = _robot.Snpx.SDI.Read(startAddress, (ushort)count);
                return (bool[]?)values;
            }
            catch
            {
                return (bool[]?)null;
            }
        });
    }

    public Task<bool?> ReadDigitalOutputAsync(int address)
    {
        if (_robot == null || !IsConnected) return Task.FromResult<bool?>(null);

        return _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                bool value = _robot.Snpx.SDO.Read(address);
                return (bool?)value;
            }
            catch
            {
                return (bool?)null;
            }
        });
    }

    public Task<bool[]?> ReadDigitalOutputsAsync(int startAddress, int count)
    {
        if (_robot == null || !IsConnected) return Task.FromResult<bool[]?>(null);

        return _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                // Batch-Read für bessere Performance
                bool[] values = _robot.Snpx.SDO.Read(startAddress, (ushort)count);
                return (bool[]?)values;
            }
            catch
            {
                return (bool[]?)null;
            }
        });
    }

    public async Task<bool> WriteDigitalOutputAsync(int address, bool value)
    {
        if (_robot == null || !IsConnected) return false;

        return await _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                _robot.Snpx.SDO.Write(address, value);
                return true;
            }
            catch (Exception ex)
            {
                await _errorLog.LogAsync($"Failed to write DO[{address}]: {ex.Message}",
                    ErrorSeverity.Warning, ErrorSource.Robot);
                return false;
            }
        });
    }

    public async Task<bool> SimulateDigitalInputAsync(int address, bool value)
    {
        if (_robot == null || !IsConnected) return false;

        return await _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                // SDI.Write simulates an input value
                _robot.Snpx.SDI.Write(address, value);
                return true;
            }
            catch (Exception ex)
            {
                await _errorLog.LogAsync($"Failed to simulate DI[{address}]: {ex.Message}",
                    ErrorSeverity.Warning, ErrorSource.Robot);
                return false;
            }
        });
    }

    public async Task<bool> SimulateDigitalOutputAsync(int address, bool value)
    {
        if (_robot == null || !IsConnected) return false;

        return await _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                _robot.Snpx.SDO.Write(address, value);
                return true;
            }
            catch (Exception ex)
            {
                await _errorLog.LogAsync($"Failed to simulate DO[{address}]: {ex.Message}",
                    ErrorSeverity.Warning, ErrorSource.Robot);
                return false;
            }
        });
    }

    public Task<Dictionary<int, bool>?> ReadDigitalInputsBatchAsync(int[] addresses)
    {
        if (_robot == null || !IsConnected || addresses.Length == 0)
            return Task.FromResult<Dictionary<int, bool>?>(null);

        return _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                // Bestimme den Bereich der zu lesenden Adressen
                int minAddress = addresses.Min();
                int maxAddress = addresses.Max();
                ushort count = (ushort)(maxAddress - minAddress + 1);

                // Lese alle Werte im Bereich mit einem Batch-Read
                bool[] allValues = _robot.Snpx.SDI.Read(minAddress, count);

                var result = new Dictionary<int, bool>();
                foreach (var address in addresses)
                {
                    int index = address - minAddress;
                    if (index >= 0 && index < allValues.Length)
                    {
                        result[address] = allValues[index];
                    }
                }
                return (Dictionary<int, bool>?)result;
            }
            catch
            {
                return (Dictionary<int, bool>?)null;
            }
        });
    }

    public Task<Dictionary<int, bool>?> ReadDigitalOutputsBatchAsync(int[] addresses)
    {
        if (_robot == null || !IsConnected || addresses.Length == 0)
            return Task.FromResult<Dictionary<int, bool>?>(null);

        return _requestQueue.EnqueueAsync(async () =>
        {
            try
            {
                // Bestimme den Bereich der zu lesenden Adressen
                int minAddress = addresses.Min();
                int maxAddress = addresses.Max();
                ushort count = (ushort)(maxAddress - minAddress + 1);

                // Lese alle Werte im Bereich mit einem Batch-Read
                bool[] allValues = _robot.Snpx.SDO.Read(minAddress, count);

                var result = new Dictionary<int, bool>();
                foreach (var address in addresses)
                {
                    int index = address - minAddress;
                    if (index >= 0 && index < allValues.Length)
                    {
                        result[address] = allValues[index];
                    }
                }
                return (Dictionary<int, bool>?)result;
            }
            catch
            {
                return (Dictionary<int, bool>?)null;
            }
        });
    }

    public async Task<bool> MoveToHomeAsync()
    {
        return await RunProgramAsync("HOME");
    }

    public async Task<bool> LayDownAsync()
    {
        return await WriteRegisterAsync(LAYDOWN_REGISTER_1, 1) &&
               await WriteRegisterAsync(LAYDOWN_REGISTER_2, 1);
    }

    public async Task<bool> PickUpAsync()
    {
        return await WriteRegisterAsync(LAYDOWN_REGISTER_1, 2) &&
               await WriteRegisterAsync(LAYDOWN_REGISTER_2, 2);
    }

    public async Task<bool> OpenMaintenanceDoorAsync()
    {
        return await WriteRegisterAsync(DOOR_REGISTER, 1);
    }

    public async Task<bool> CloseMaintenanceDoorAsync()
    {
        return await WriteRegisterAsync(DOOR_REGISTER, 0);
    }

    public async Task<bool> OpenLoadDoorAsync()
    {
        return await WriteRegisterAsync(LOAD_REGISTER, 1);
    }

    public async Task<bool> CloseLoadDoorAsync()
    {
        return await WriteRegisterAsync(LOAD_REGISTER, 0);
    }

    public async Task<bool> OpenPaletteDoor1Async()
    {
        return await WriteRegisterAsync(PALETTE_DOOR1_REGISTER_1, 1);
    }

    public async Task<bool> ClosePaletteDoor1Async()
    {
        return await WriteRegisterAsync(PALETTE_DOOR1_REGISTER_1, 0);
    }

    public async Task<bool> OpenPaletteDoor2Async()
    {
        return await WriteRegisterAsync(PALETTE_DOOR1_REGISTER_2, 1);
    }

    public async Task<bool> ClosePaletteDoor2Async()
    {
        return await WriteRegisterAsync(PALETTE_DOOR1_REGISTER_2, 0);
    }

    private void OnStatusChanged()
    {
        StatusChanged?.Invoke(this, new RobotStatusChangedEventArgs { Status = Status });
    }

    public async Task<bool> StartDoorHandshakeAsync(int requestRegister)
    {
        if (_robot == null || !IsConnected) return false;

        // Mapping: Request-Register → Status-Register und erwarteter Wert
        // Wartungstür: R189 → R89, erwartet 2
        // Palettentür 1: R187 → R87, erwartet 1
        // Palettentür 2: R188 → R88, erwartet 1
        int statusRegister = requestRegister switch
        {
            187 => 87,  // Palettentür 1
            188 => 88,  // Palettentür 2
            189 => 89,  // Wartungstür
            _ => throw new ArgumentException($"Ungültiges Request-Register: {requestRegister}. Erlaubt: 187, 188, 189")
        };

        // Erwarteter Wert wenn Tür freigegeben: 1 für Palette, 2 für Wartung
        int expectedValue = requestRegister == 189 ? 2 : 1;

        try
        {
            // Zuerst prüfen ob Tür bereits freigegeben
            var currentValue = await ReadRegisterAsync(statusRegister);
            if (currentValue != null && currentValue.Value == expectedValue)
            {
                // Tür ist bereits freigegeben - nichts tun
                return true;
            }

            // Request-Register auf 1 setzen um Handshake zu starten
            var success = await WriteRegisterAsync(requestRegister, 1);
            if (!success) return false;

            // Handshake zur Überwachung registrieren
            lock (_handshakeLock)
            {
                _activeHandshakes[statusRegister] = (requestRegister, expectedValue);

                // Timer starten falls noch nicht aktiv
                if (_handshakeTimer == null)
                {
                    _handshakeTimer = new System.Threading.Timer(
                        HandshakeTimerCallback,
                        null,
                        HANDSHAKE_POLL_INTERVAL_MS,
                        HANDSHAKE_POLL_INTERVAL_MS);
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Door handshake failed for R[{requestRegister}]: {ex.Message}",
                ErrorSeverity.Warning, ErrorSource.Robot);
            return false;
        }
    }

    private async void HandshakeTimerCallback(object? state)
    {
        if (_robot == null || !IsConnected) return;

        List<(int statusRegister, int requestRegister)> completedHandshakes = new();

        // Kopie der aktiven Handshakes erstellen
        Dictionary<int, (int requestRegister, int expectedValue)> handshakesToCheck;
        lock (_handshakeLock)
        {
            if (_activeHandshakes.Count == 0)
            {
                // Keine aktiven Handshakes - Timer stoppen
                _handshakeTimer?.Dispose();
                _handshakeTimer = null;
                return;
            }
            handshakesToCheck = new Dictionary<int, (int, int)>(_activeHandshakes);
        }

        foreach (var kvp in handshakesToCheck)
        {
            int statusRegister = kvp.Key;
            int requestRegister = kvp.Value.requestRegister;
            int expectedValue = kvp.Value.expectedValue;

            try
            {
                var currentValue = await ReadRegisterAsync(statusRegister);
                if (currentValue != null && currentValue.Value == expectedValue)
                {
                    // Erwarteter Wert erreicht - Handshake abschließen
                    completedHandshakes.Add((statusRegister, requestRegister));
                }
            }
            catch
            {
                // Lesefehler ignorieren, beim nächsten Poll erneut versuchen
            }
        }

        // Abgeschlossene Handshakes bearbeiten
        foreach (var (statusRegister, requestRegister) in completedHandshakes)
        {
            try
            {
                // Request-Register auf 0 zurücksetzen
                await WriteRegisterAsync(requestRegister, 0);
            }
            catch
            {
                // Schreibfehler ignorieren
            }

            lock (_handshakeLock)
            {
                _activeHandshakes.Remove(statusRegister);

                // Timer stoppen wenn keine Handshakes mehr aktiv
                if (_activeHandshakes.Count == 0)
                {
                    _handshakeTimer?.Dispose();
                    _handshakeTimer = null;
                }
            }
        }
    }

    public async Task<List<RobotAlarm>> GetAlarmsAsync()
    {
        if (_robot == null || !IsConnected)
            return [];

        try
        {
            var errorList = _robot.Ftp.GetAllErrorsList();
            var alarms = new List<RobotAlarm>();

            if (errorList?.Items != null)
            {
                // Use FilterActiveAlarms() to get only active (non-reset) alarms
                var activeAlarms = errorList.FilterActiveAlarms();

                int id = 0;
                foreach (var item in activeAlarms)
                {
                    alarms.Add(new RobotAlarm
                    {
                        Id = id++,
                        ErrorCode = item.ErrorCode ?? string.Empty,
                        Message = item.Message ?? string.Empty,
                        RawText = item.Text,
                        OccurredAt = item.OccurringTime,
                        IsReset = false
                    });
                }
            }

            return alarms;
        }
        catch (Exception ex)
        {
            await _errorLog.LogAsync($"Failed to get alarms: {ex.Message}",
                ErrorSeverity.Warning, ErrorSource.Robot);
            return [];
        }
    }

    public async Task<bool> ClearAlarmsAsync()
    {
        // Use the same reset mechanism as the normal RESET button
        return await ResetAsync();
    }

    // Register 80 constants for error handling
    private const int ERROR_REGISTER = 80;
    private const int ERROR_CLEAR_TRIGGER = 182;  // R182: Trigger to clear error
    private const int ERROR_CLEAR_CONFIRM = 82;   // R82: Robot confirmation
    private const int ERROR_CLEAR_TIMEOUT_MS = 30000;  // 30 seconds timeout

    public async Task<int?> GetErrorRegisterAsync()
    {
        return await ReadRegisterAsync(ERROR_REGISTER);
    }

    public async Task<bool> StartErrorClearHandshakeAsync()
    {
        if (_robot == null || !IsConnected) return false;

        try
        {
            // Step 1: Set R182 = 1 (trigger error clear)
            var success = await WriteRegisterAsync(ERROR_CLEAR_TRIGGER, 1);
            if (!success)
            {
                await _errorLog.LogAsync("Failed to write R182=1 for error clear handshake",
                    ErrorSeverity.Warning, ErrorSource.Robot);
                return false;
            }

            // Step 2: Poll R82 until it becomes 1 (robot acknowledgment)
            var startTime = DateTime.UtcNow;
            while ((DateTime.UtcNow - startTime).TotalMilliseconds < ERROR_CLEAR_TIMEOUT_MS)
            {
                await Task.Delay(200);

                var r82Value = await ReadRegisterAsync(ERROR_CLEAR_CONFIRM);
                if (r82Value == 1)
                {
                    // Step 3: Robot acknowledged, set R182 = 0 to complete handshake
                    await WriteRegisterAsync(ERROR_CLEAR_TRIGGER, 0);
                    return true;
                }
            }

            // Timeout - reset R182 anyway and return failure
            await WriteRegisterAsync(ERROR_CLEAR_TRIGGER, 0);
            await _errorLog.LogAsync("Error clear handshake timed out waiting for R82=1",
                ErrorSeverity.Warning, ErrorSource.Robot);
            return false;
        }
        catch (Exception ex)
        {
            // Try to reset R182 on error
            try { await WriteRegisterAsync(ERROR_CLEAR_TRIGGER, 0); } catch { }

            await _errorLog.LogAsync($"Error clear handshake failed: {ex.Message}",
                ErrorSeverity.Error, ErrorSource.Robot);
            return false;
        }
    }

    public void Dispose()
    {
        if (_disposed) return;

        _handshakeTimer?.Dispose();
        _handshakeTimer = null;

        if (_robot != null)
        {
            _robot.Disconnect();
            _robot = null;
        }

        _isConnected = false;
        _disposed = true;
        GC.SuppressFinalize(this);
    }
}
