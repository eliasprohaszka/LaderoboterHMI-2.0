using System.Security.Cryptography;
using System.Text;
using UnderAutomation.Fanuc;

namespace Laderoboter.Core.Services;

public static class LicenseManager
{
    private const string LicenseFileName = "license.dat";
    private const string DecryptionPassword = "x7)#CCgH98<-!!2ddfd55DF";
    private const string ExpectedCompany = "Geibel_Hotz_GmbH_Homberg_DE";
    private static bool _initialized;

    /// <summary>
    /// Lizenz-Status nach Initialisierung
    /// </summary>
    public static string LicenseStatus { get; private set; } = "Not initialized";

    /// <summary>
    /// Ist die Lizenz gültig (nicht Trial)?
    /// </summary>
    public static bool IsLicensed { get; private set; }

    /// <summary>
    /// Initialisiert die UnderAutomation Lizenz aus einer Lizenzdatei
    /// </summary>
    public static void InitUnderAutomation()
    {
        if (_initialized) return;
        _initialized = true;

        try
        {
            // Suche license.dat im Anwendungsverzeichnis
            var licenseFilePath = FindLicenseFile();

            if (licenseFilePath == null)
            {
                var licenseInfo = FanucRobot.LicenseInfo;
                LicenseStatus = $"Trial mode: {licenseInfo.EvaluationDaysLeft} days left (no license.dat found)";
                IsLicensed = false;
                Log(LicenseStatus);
                return;
            }

            var encryptedBase64 = File.ReadAllText(licenseFilePath).Trim();
            var encryptedData = Convert.FromBase64String(encryptedBase64);

            var decrypted = DecryptAES(encryptedData, DecryptionPassword);
            var parts = decrypted.Split('|');

            if (parts.Length != 2)
                throw new InvalidOperationException("Ungültiges Lizenzformat");

            // Validate company name matches
            if (parts[0] != ExpectedCompany)
                throw new InvalidOperationException($"License company mismatch: expected {ExpectedCompany}");

            FanucRobot.RegisterLicense(parts[0], parts[1]);

            // Verify license state from SDK
            var sdkLicenseInfo = FanucRobot.LicenseInfo;
            var state = sdkLicenseInfo.State.ToString();
            var daysLeft = sdkLicenseInfo.EvaluationDaysLeft;

            LicenseStatus = $"Licensed: {parts[0]} | State: {state} | DaysLeft: {daysLeft}";
            IsLicensed = sdkLicenseInfo.State == UnderAutomation.Fanuc.License.LicenseState.Licensed;
            Log(LicenseStatus);

            // Sensible Daten aus dem Speicher löschen
            Array.Clear(encryptedData, 0, encryptedData.Length);
        }
        catch (Exception ex)
        {
            var licenseInfo = FanucRobot.LicenseInfo;
            LicenseStatus = $"License error: {ex.Message} - Trial: {licenseInfo.EvaluationDaysLeft} days left";
            IsLicensed = false;
            Log(LicenseStatus);
        }
    }

    private static string? FindLicenseFile()
    {
        // Suche in verschiedenen Verzeichnissen
        var searchPaths = new[]
        {
            // Neben der ausführbaren Datei
            Path.Combine(AppContext.BaseDirectory, LicenseFileName),
            // Im aktuellen Arbeitsverzeichnis
            Path.Combine(Environment.CurrentDirectory, LicenseFileName),
            // Im LocalAppData Ordner
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Laderoboter", LicenseFileName)
        };

        foreach (var path in searchPaths)
        {
            if (File.Exists(path))
            {
                Log($"Found license at: {path}");
                return path;
            }
        }

        return null;
    }

    private static string DecryptAES(byte[] encryptedData, string password)
    {
        if (encryptedData.Length < 16)
            throw new ArgumentException("Verschlüsselte Daten zu kurz");

        using var aes = Aes.Create();

        // Schlüssel aus Passwort ableiten
        using var sha256 = SHA256.Create();
        aes.Key = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))[0..32];

        // IV sind die ersten 16 Bytes
        aes.IV = encryptedData[0..16];

        // Verschlüsselte Daten sind der Rest
        var cipherText = encryptedData[16..];

        using var decryptor = aes.CreateDecryptor();
        using var msDecrypt = new MemoryStream(cipherText);
        using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        using var srDecrypt = new StreamReader(csDecrypt);

        return srDecrypt.ReadToEnd();
    }

    private static void Log(string message)
    {
        try
        {
            var logPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Laderoboter",
                "license.log");

            Directory.CreateDirectory(Path.GetDirectoryName(logPath)!);

            var logLine = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            File.AppendAllText(logPath, logLine + Environment.NewLine);

            // Also write to debug output
            System.Diagnostics.Debug.WriteLine($"[LicenseManager] {message}");
        }
        catch
        {
            // Ignore logging errors
        }
    }
}
