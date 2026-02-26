namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für NFC/RFID-Kartenleser
/// </summary>
public interface INfcService : IDisposable
{
    /// <summary>
    /// Event bei Erkennung einer Karte (UID als Hex-String)
    /// </summary>
    event EventHandler<string>? OnCardDetected;

    /// <summary>
    /// Event bei Entfernung einer Karte
    /// </summary>
    event EventHandler? OnCardRemoved;

    /// <summary>
    /// Event bei Fehlern
    /// </summary>
    event EventHandler<string>? OnError;

    /// <summary>
    /// Gibt an, ob der Service aktiv auf Karten lauscht
    /// </summary>
    bool IsListening { get; }

    /// <summary>
    /// Gibt an, ob ein Reader verbunden ist
    /// </summary>
    bool IsReaderConnected { get; }

    /// <summary>
    /// Startet das Lauschen auf Karten
    /// </summary>
    void StartListening();

    /// <summary>
    /// Stoppt das Lauschen auf Karten
    /// </summary>
    void StopListening();
}
