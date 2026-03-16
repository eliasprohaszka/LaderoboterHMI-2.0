using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Laderoboter.Core;
using Laderoboter.Core.Interfaces;
using Laderoboter.Core.Services;
using Laderoboter.Desktop.Services;
using Laderoboter.UI;

namespace Laderoboter.Desktop;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        // Initialize license early
        LicenseManager.InitUnderAutomation();

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .ConfigureLifecycleEvents(events =>
            {
#if WINDOWS
                events.AddWindows(windows => windows
                    .OnWindowCreated(window =>
                    {
                        var handle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                        var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(handle);
                        var appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);

                        // Set default window size to 768 x 1366 (vertical orientation)
                        appWindow.Resize(new Windows.Graphics.SizeInt32(768, 1366));
                    }));
#endif
            });

        builder.Services.AddMauiBlazorWebView();

        // Add Laderoboter Core services (Robot, Settings, ErrorLog, Database)
        builder.Services.AddLaderoboterCore();

        // Add NFC Reader service
        builder.Services.AddSingleton<INfcService, NfcReaderService>();

        // Add UI services
        builder.Services.AddLaderoboterUI();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        var app = builder.Build();

        // Initialize database, translations, and service connections
        try
        {
            Task.Run(async () =>
            {
                await app.Services.InitializeDatabaseAsync();
                await app.Services.InitializeTranslationsAsync();
            }).GetAwaiter().GetResult();

            // Initialisiere Service-Verbindungen (löst zirkuläre Abhängigkeiten)
            app.Services.InitializeServiceConnections();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Initialization error: {ex}");
            Console.WriteLine($"Initialization error: {ex}");
        }

        return app;
    }
}
