using Laderoboter.Core.Interfaces;
using PCSC;
using PCSC.Exceptions;
using PCSC.Monitoring;

namespace Laderoboter.Desktop.Services;

/// <summary>
/// NFC/RFID-Kartenleser-Service mit PC/SC
/// </summary>
public class NfcReaderService : INfcService
{
    private ISCardMonitor? _monitor;
    private ISCardContext? _context;
    private string? _lastCardUid;
    private int _listenerRefCount;
    private readonly object _lock = new();
    private bool _disposed;

    public event EventHandler<string>? OnCardDetected;
    public event EventHandler? OnCardRemoved;
    public event EventHandler<string>? OnError;

    public bool IsListening { get; private set; }
    public bool IsReaderConnected { get; private set; }

    public void StartListening()
    {
        lock (_lock)
        {
            _listenerRefCount++;

            if (_listenerRefCount > 1)
                return;

            try
            {
                _context = ContextFactory.Instance.Establish(SCardScope.System);
                var readerNames = _context.GetReaders();

                var nfcReader = readerNames.FirstOrDefault(r =>
                    r.Contains("ACR", StringComparison.OrdinalIgnoreCase) ||
                    r.Contains("NFC", StringComparison.OrdinalIgnoreCase) ||
                    r.Contains("PICC", StringComparison.OrdinalIgnoreCase));

                if (nfcReader == null && readerNames.Length > 0)
                {
                    nfcReader = readerNames[0];
                }

                if (nfcReader == null)
                {
                    IsReaderConnected = false;
                    OnError?.Invoke(this, "Kein NFC-Reader gefunden");
                    return;
                }

                IsReaderConnected = true;

                _monitor = MonitorFactory.Instance.Create(SCardScope.System);
                _monitor.CardInserted += OnCardInserted;
                _monitor.CardRemoved += OnCardRemovedHandler;
                _monitor.MonitorException += OnMonitorException;

                _monitor.Start(nfcReader);
                IsListening = true;
            }
            catch (Exception ex)
            {
                IsReaderConnected = false;
                IsListening = false;
                OnError?.Invoke(this, $"NFC-Fehler: {ex.Message}");
            }
        }
    }

    public void StopListening()
    {
        lock (_lock)
        {
            _listenerRefCount--;

            if (_listenerRefCount > 0)
                return;

            _listenerRefCount = 0;

            try
            {
                if (_monitor != null)
                {
                    _monitor.CardInserted -= OnCardInserted;
                    _monitor.CardRemoved -= OnCardRemovedHandler;
                    _monitor.MonitorException -= OnMonitorException;
                    _monitor.Cancel();
                    _monitor.Dispose();
                    _monitor = null;
                }

                _context?.Dispose();
                _context = null;

                IsListening = false;
                _lastCardUid = null;
            }
            catch (Exception ex)
            {
                OnError?.Invoke(this, $"Fehler beim Stoppen: {ex.Message}");
            }
        }
    }

    private void OnCardInserted(object sender, CardStatusEventArgs e)
    {
        try
        {
            var uid = ReadCardUid(e.ReaderName);
            if (uid != null && uid != _lastCardUid)
            {
                _lastCardUid = uid;
                OnCardDetected?.Invoke(this, uid);
            }
        }
        catch (Exception ex)
        {
            OnError?.Invoke(this, $"Fehler beim Lesen der Karte: {ex.Message}");
        }
    }

    private void OnCardRemovedHandler(object sender, CardStatusEventArgs e)
    {
        _lastCardUid = null;
        OnCardRemoved?.Invoke(this, EventArgs.Empty);
    }

    private void OnMonitorException(object sender, PCSCException ex)
    {
        IsReaderConnected = false;
        IsListening = false;
        OnError?.Invoke(this, $"Monitor-Fehler: {ex.Message}");
    }

    private string? ReadCardUid(string readerName)
    {
        try
        {
            using var context = ContextFactory.Instance.Establish(SCardScope.System);
            using var reader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any);

            // APDU command to get UID: FF CA 00 00 00
            byte[] getUidCommand = { 0xFF, 0xCA, 0x00, 0x00, 0x00 };
            byte[] receiveBuffer = new byte[256];
            var bytesReceived = reader.Transmit(getUidCommand, receiveBuffer);

            if (bytesReceived >= 2)
            {
                // Check status bytes (last 2 bytes should be 0x90 0x00 for success)
                var sw1 = receiveBuffer[bytesReceived - 2];
                var sw2 = receiveBuffer[bytesReceived - 1];

                if (sw1 == 0x90 && sw2 == 0x00)
                {
                    // Extract UID (all bytes except last 2)
                    var uid = new byte[bytesReceived - 2];
                    Array.Copy(receiveBuffer, uid, bytesReceived - 2);
                    return BitConverter.ToString(uid).Replace("-", ":");
                }
            }

            return null;
        }
        catch (Exception ex)
        {
            OnError?.Invoke(this, $"Fehler beim Lesen der UID: {ex.Message}");
            return null;
        }
    }

    public void Dispose()
    {
        if (_disposed)
            return;

        _disposed = true;

        lock (_lock)
        {
            _listenerRefCount = 1;
        }

        StopListening();
    }
}
