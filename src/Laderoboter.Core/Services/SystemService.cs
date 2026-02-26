using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;

namespace Laderoboter.Core.Services;

public class SystemService : ISystemService
{
    private readonly ILogger<SystemService> _logger;

    public SystemService(ILogger<SystemService> logger)
    {
        _logger = logger;
    }

    public async Task<bool> ShutdownAsync(int delaySeconds = 15)
    {
        try
        {
            _logger.LogInformation("Initiating system shutdown with {Delay} seconds delay", delaySeconds);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Windows: shutdown /s /t <seconds>
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = $"/s /t {delaySeconds}",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                process.Start();
                await process.WaitForExitAsync();

                if (process.ExitCode == 0)
                {
                    _logger.LogInformation("Shutdown command executed successfully");
                    return true;
                }
                else
                {
                    var error = await process.StandardError.ReadToEndAsync();
                    _logger.LogError("Shutdown command failed: {Error}", error);
                    return false;
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Linux: shutdown -h +<minutes>
                var minutes = Math.Max(1, delaySeconds / 60);
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = $"-h +{minutes}",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                await process.WaitForExitAsync();
                return process.ExitCode == 0;
            }

            _logger.LogWarning("Shutdown not supported on this platform");
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initiate shutdown");
            return false;
        }
    }

    public async Task<bool> RestartAsync(int delaySeconds = 15)
    {
        try
        {
            _logger.LogInformation("Initiating system restart with {Delay} seconds delay", delaySeconds);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Windows: shutdown /r /t <seconds>
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = $"/r /t {delaySeconds}",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                process.Start();
                await process.WaitForExitAsync();

                if (process.ExitCode == 0)
                {
                    _logger.LogInformation("Restart command executed successfully");
                    return true;
                }
                else
                {
                    var error = await process.StandardError.ReadToEndAsync();
                    _logger.LogError("Restart command failed: {Error}", error);
                    return false;
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Linux: shutdown -r +<minutes>
                var minutes = Math.Max(1, delaySeconds / 60);
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = $"-r +{minutes}",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                await process.WaitForExitAsync();
                return process.ExitCode == 0;
            }

            _logger.LogWarning("Restart not supported on this platform");
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to initiate restart");
            return false;
        }
    }

    public async Task<bool> CancelShutdownAsync()
    {
        try
        {
            _logger.LogInformation("Cancelling pending shutdown/restart");

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Windows: shutdown /a
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = "/a",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true
                    }
                };

                process.Start();
                await process.WaitForExitAsync();

                if (process.ExitCode == 0)
                {
                    _logger.LogInformation("Shutdown cancelled successfully");
                    return true;
                }
                else
                {
                    var error = await process.StandardError.ReadToEndAsync();
                    _logger.LogWarning("Cancel shutdown returned non-zero: {Error}", error);
                    // Still return true as the shutdown might already have been cancelled
                    return true;
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Linux: shutdown -c
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "shutdown",
                        Arguments = "-c",
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                await process.WaitForExitAsync();
                return true;
            }

            _logger.LogWarning("Cancel shutdown not supported on this platform");
            return false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to cancel shutdown");
            return false;
        }
    }
}
