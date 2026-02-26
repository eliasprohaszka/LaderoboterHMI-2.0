namespace Laderoboter.Core.Interfaces;

/// <summary>
/// Service für Passwort-Hashing und -Verifizierung
/// </summary>
public interface IPasswordService
{
    /// <summary>
    /// Hasht ein Passwort mit PBKDF2 und Salt
    /// </summary>
    string HashPassword(string password);

    /// <summary>
    /// Verifiziert ein Passwort gegen einen gespeicherten Hash
    /// </summary>
    bool VerifyPassword(string password, string hash);

    /// <summary>
    /// Hasht einen RFID-Tag
    /// </summary>
    string HashRfidTag(string rfidUid);

    /// <summary>
    /// Verifiziert einen RFID-Tag gegen einen gespeicherten Hash
    /// </summary>
    bool VerifyRfidTag(string rfidUid, string storedHash);
}
