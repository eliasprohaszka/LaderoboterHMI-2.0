using System.Reflection;
using Laderoboter.Core.Events;
using UnderAutomation.Fanuc;
using FanucTaskStatus = UnderAutomation.Fanuc.Common.TaskStatus;

namespace Laderoboter.Core.Services;

/// <summary>
/// Monitors FANUC robot task status via FTP GetProgramStates to detect if MAIN program is running.
/// Uses reflection to access the FanucRobot instance from IRobotService.
/// </summary>
public class TaskStatusMonitor : ITaskStatusMonitor, IDisposable
{
    private const int POLL_INTERVAL_MS = 1000; // Poll every 1 second
    private const int INITIAL_DELAY_MS = 1000; // Wait 1 second after connect before first poll
    private const string MAIN_PROGRAM_NAME = "main";

    private readonly IRobotService _robotService;
    private readonly object _lockObject = new();

    private Timer? _pollTimer;
    private bool _isMonitoring;
    private bool _disposed;

    // Current state
    private bool _isMainProgramRunning;
    private bool _isMainProgramPaused;
    private string? _currentProgramName;

    public bool IsMainProgramRunning => _isMainProgramRunning;
    public bool IsMainProgramPaused => _isMainProgramPaused;
    public string? CurrentProgramName => _currentProgramName;

    public event EventHandler<MainProgramStatusChangedEventArgs>? MainProgramStatusChanged;

    public TaskStatusMonitor(IRobotService robotService)
    {
        _robotService = robotService;
    }

    public void Start()
    {
        lock (_lockObject)
        {
            if (_isMonitoring || _disposed)
                return;

            _isMonitoring = true;
            Console.WriteLine("[TaskStatusMonitor] Starting task status monitoring via FTP...");

            // Start polling timer with initial delay
            _pollTimer = new Timer(
                OnPollTimer,
                null,
                TimeSpan.FromMilliseconds(INITIAL_DELAY_MS),
                TimeSpan.FromMilliseconds(POLL_INTERVAL_MS)
            );
        }
    }

    public void Stop()
    {
        lock (_lockObject)
        {
            if (!_isMonitoring)
                return;

            _isMonitoring = false;
            _pollTimer?.Dispose();
            _pollTimer = null;

            // Reset state
            UpdateState(false, false, null);

            Console.WriteLine("[TaskStatusMonitor] Task status monitoring stopped");
        }
    }

    private void OnPollTimer(object? state)
    {
        if (!_isMonitoring || _disposed)
            return;

        try
        {
            PollTaskStatus();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[TaskStatusMonitor] Error polling task status: {ex.Message}");
        }
    }

    private void PollTaskStatus()
    {
        if (!_robotService.IsConnected)
        {
            // Not connected - reset state if needed
            if (_isMainProgramRunning || _isMainProgramPaused || _currentProgramName != null)
            {
                UpdateState(false, false, null);
            }
            return;
        }

        // Access the robot directly via reflection
        var robot = GetRobotViaReflection();
        if (robot == null || robot.Ftp == null || !robot.Ftp.Connected)
        {
            return;
        }

        try
        {
            // Use FTP GetProgramStates like the old app
            var states = robot.Ftp.GetProgramStates();

            if (states?.TaskStates == null)
            {
                UpdateState(false, false, null);
                return;
            }

            // Find MAIN program in task states
            var mainTask = states.TaskStates
                .FirstOrDefault(t => t.Name != null &&
                    t.Name.Equals(MAIN_PROGRAM_NAME, StringComparison.OrdinalIgnoreCase));

            if (mainTask == null)
            {
                UpdateState(false, false, null);
                return;
            }

            bool isRunning = mainTask.Status == FanucTaskStatus.Running;
            bool isPaused = mainTask.Status == FanucTaskStatus.Paused;
            string? programName = mainTask.Name;

            UpdateState(isRunning, isPaused, programName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[TaskStatusMonitor] Error reading task status via FTP: {ex.Message}");
        }
    }

    private void UpdateState(bool isRunning, bool isPaused, string? programName)
    {
        bool stateChanged = _isMainProgramRunning != isRunning ||
                           _isMainProgramPaused != isPaused ||
                           _currentProgramName != programName;

        if (!stateChanged)
            return;

        _isMainProgramRunning = isRunning;
        _isMainProgramPaused = isPaused;
        _currentProgramName = programName;

        Console.WriteLine($"[TaskStatusMonitor] State changed: Running={isRunning}, Paused={isPaused}, Program={programName ?? "null"}");

        // Fire event
        MainProgramStatusChanged?.Invoke(this, new MainProgramStatusChangedEventArgs
        {
            IsRunning = isRunning,
            IsPaused = isPaused,
            ProgramName = programName
        });
    }

    private FanucRobot? GetRobotViaReflection()
    {
        try
        {
            var robotField = _robotService.GetType().GetField("_robot",
                BindingFlags.NonPublic | BindingFlags.Instance);

            if (robotField == null)
            {
                return null;
            }

            return robotField.GetValue(_robotService) as FanucRobot;
        }
        catch
        {
            return null;
        }
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        _disposed = true;
        Stop();
    }
}
