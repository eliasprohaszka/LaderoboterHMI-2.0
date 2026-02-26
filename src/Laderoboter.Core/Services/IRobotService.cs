using Laderoboter.Core.Events;
using Laderoboter.Core.Models;

namespace Laderoboter.Core.Services;

public interface IRobotService : IDisposable
{
    // Connection
    Task<bool> ConnectAsync(string ipAddress, int timeout = 2000);
    Task DisconnectAsync();
    bool IsConnected { get; }
    RobotStatus Status { get; }

    // Events
    event EventHandler<RobotStatusChangedEventArgs>? StatusChanged;
    event EventHandler<RegisterChangedEventArgs>? RegisterChanged;
    event EventHandler<PaletteChangedEventArgs>? PaletteChanged;
    event EventHandler<ErrorOccurredEventArgs>? ErrorOccurred;

    // Programs
    Task<IEnumerable<string>> GetProgramsAsync();
    Task<bool> RunProgramAsync(string programName);
    Task<bool> StopProgramAsync();
    Task<bool> PauseProgramAsync();
    Task<bool> ResumeProgramAsync();
    Task<bool> ResetAsync();
    Task<bool> SetSpeedOverrideAsync(int speed);

    // Registers
    Task<int?> ReadRegisterAsync(int address);
    Task<int[]?> ReadRegistersAsync(int startAddress, int count);
    Task<bool> WriteRegisterAsync(int address, int value);

    // IO
    Task<bool?> ReadDigitalInputAsync(int address);
    Task<bool[]?> ReadDigitalInputsAsync(int startAddress, int count);
    Task<bool?> ReadDigitalOutputAsync(int address);
    Task<bool[]?> ReadDigitalOutputsAsync(int startAddress, int count);
    Task<bool> WriteDigitalOutputAsync(int address, bool value);
    Task<bool> SimulateDigitalInputAsync(int address, bool value);
    Task<bool> SimulateDigitalOutputAsync(int address, bool value);

    // IO Batch (für spezifische Adresslisten)
    Task<Dictionary<int, bool>?> ReadDigitalInputsBatchAsync(int[] addresses);
    Task<Dictionary<int, bool>?> ReadDigitalOutputsBatchAsync(int[] addresses);

    // Positioning
    Task<bool> MoveToHomeAsync();
    Task<bool> LayDownAsync();
    Task<bool> PickUpAsync();

    // Palette Data (für initialen Load - reaktive Updates via IRobotMonitor)
    PaletteData Palette1 { get; }
    PaletteData Palette2 { get; }

    // Maintenance
    Task<bool> OpenMaintenanceDoorAsync();
    Task<bool> CloseMaintenanceDoorAsync();
    Task<bool> OpenLoadDoorAsync();
    Task<bool> CloseLoadDoorAsync();
    Task<bool> OpenPaletteDoor1Async();
    Task<bool> ClosePaletteDoor1Async();
    Task<bool> OpenPaletteDoor2Async();
    Task<bool> ClosePaletteDoor2Async();

    /// <summary>
    /// Startet einen Door-Handshake: Setzt Request-Register auf 1, überwacht Status-Register,
    /// und setzt Request-Register auf 0 wenn sich Status ändert.
    /// Unterstützt: R187→R87 (Palettentür 1), R188→R88 (Palettentür 2), R189→R89 (Wartungstür)
    /// </summary>
    /// <param name="requestRegister">Request-Register (187, 188 oder 189)</param>
    /// <returns>True wenn Handshake erfolgreich gestartet wurde</returns>
    Task<bool> StartDoorHandshakeAsync(int requestRegister);
}
