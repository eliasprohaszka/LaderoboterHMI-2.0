using System.Threading.Channels;

namespace Laderoboter.Core.Services;

/// <summary>
/// Thread-sichere Request-Queue für sequentielle Roboter-Kommunikation.
/// Verhindert gleichzeitige Anfragen die den FANUC-Controller überlasten können.
/// </summary>
public interface IRobotRequestQueue : IDisposable
{
    /// <summary>
    /// Fügt eine Anfrage zur Queue hinzu und wartet auf das Ergebnis.
    /// Alle Anfragen werden sequentiell abgearbeitet.
    /// </summary>
    Task<T> EnqueueAsync<T>(Func<Task<T>> request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fügt eine Anfrage ohne Rückgabewert zur Queue hinzu.
    /// </summary>
    Task EnqueueAsync(Func<Task> request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Anzahl der wartenden Anfragen in der Queue.
    /// </summary>
    int PendingCount { get; }

    /// <summary>
    /// Ist die Queue aktiv und verarbeitet Anfragen?
    /// </summary>
    bool IsProcessing { get; }
}

/// <summary>
/// Implementierung der Request-Queue mit Channel für thread-sichere Verarbeitung.
/// </summary>
public class RobotRequestQueue : IRobotRequestQueue
{
    private readonly Channel<QueuedRequest> _channel;
    private readonly Task _processingTask;
    private readonly CancellationTokenSource _cts;
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    private int _pendingCount;
    private bool _disposed;

    // Minimale Pause zwischen Anfragen (ms) - gibt dem Controller Zeit
    private const int REQUEST_DELAY_MS = 10;

    public RobotRequestQueue()
    {
        // Unbounded Channel für maximale Flexibilität
        _channel = Channel.CreateUnbounded<QueuedRequest>(new UnboundedChannelOptions
        {
            SingleReader = true,
            SingleWriter = false
        });

        _cts = new CancellationTokenSource();
        _processingTask = ProcessQueueAsync(_cts.Token);
    }

    public int PendingCount => _pendingCount;
    public bool IsProcessing => !_processingTask.IsCompleted;

    public async Task<T> EnqueueAsync<T>(Func<Task<T>> request, CancellationToken cancellationToken = default)
    {
        if (_disposed) throw new ObjectDisposedException(nameof(RobotRequestQueue));

        var tcs = new TaskCompletionSource<object?>();
        var queuedRequest = new QueuedRequest(
            async () =>
            {
                var result = await request();
                return result;
            },
            tcs,
            cancellationToken
        );

        Interlocked.Increment(ref _pendingCount);

        try
        {
            await _channel.Writer.WriteAsync(queuedRequest, cancellationToken);
            var result = await tcs.Task;
            return (T)result!;
        }
        finally
        {
            Interlocked.Decrement(ref _pendingCount);
        }
    }

    public async Task EnqueueAsync(Func<Task> request, CancellationToken cancellationToken = default)
    {
        if (_disposed) throw new ObjectDisposedException(nameof(RobotRequestQueue));

        var tcs = new TaskCompletionSource<object?>();
        var queuedRequest = new QueuedRequest(
            async () =>
            {
                await request();
                return null;
            },
            tcs,
            cancellationToken
        );

        Interlocked.Increment(ref _pendingCount);

        try
        {
            await _channel.Writer.WriteAsync(queuedRequest, cancellationToken);
            await tcs.Task;
        }
        finally
        {
            Interlocked.Decrement(ref _pendingCount);
        }
    }

    private async Task ProcessQueueAsync(CancellationToken cancellationToken)
    {
        try
        {
            await foreach (var request in _channel.Reader.ReadAllAsync(cancellationToken))
            {
                // Prüfe ob die ursprüngliche Anfrage bereits abgebrochen wurde
                if (request.CancellationToken.IsCancellationRequested)
                {
                    request.CompletionSource.TrySetCanceled(request.CancellationToken);
                    continue;
                }

                try
                {
                    // Sequentielle Ausführung mit Semaphore (zusätzliche Sicherheit)
                    await _semaphore.WaitAsync(cancellationToken);
                    try
                    {
                        var result = await request.RequestFunc();
                        request.CompletionSource.TrySetResult(result);
                    }
                    finally
                    {
                        _semaphore.Release();
                    }

                    // Kleine Pause zwischen Anfragen
                    await Task.Delay(REQUEST_DELAY_MS, cancellationToken);
                }
                catch (OperationCanceledException) when (request.CancellationToken.IsCancellationRequested)
                {
                    request.CompletionSource.TrySetCanceled(request.CancellationToken);
                }
                catch (Exception ex)
                {
                    request.CompletionSource.TrySetException(ex);
                }
            }
        }
        catch (OperationCanceledException)
        {
            // Queue wird beendet - normal
        }
    }

    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;

        _cts.Cancel();
        _channel.Writer.Complete();

        try
        {
            _processingTask.Wait(TimeSpan.FromSeconds(2));
        }
        catch
        {
            // Ignorieren beim Shutdown
        }

        _cts.Dispose();
        _semaphore.Dispose();
    }

    private record QueuedRequest(
        Func<Task<object?>> RequestFunc,
        TaskCompletionSource<object?> CompletionSource,
        CancellationToken CancellationToken
    );
}
