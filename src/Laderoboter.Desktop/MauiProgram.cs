using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;
using Laderoboter.Core;
using Laderoboter.Core.Interfaces;
using Laderoboter.Desktop.Services;
using Laderoboter.UI;

namespace Laderoboter.Desktop;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
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

                        // Set default window size to 1366 x 768
                        appWindow.Resize(new Windows.Graphics.SizeInt32(1366, 768));
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

        // Initialize database and translations
        try
        {
            Task.Run(async () =>
            {
                await app.Services.InitializeDatabaseAsync();
                await app.Services.InitializeTranslationsAsync();
            }).GetAwaiter().GetResult();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine($"Initialization error: {ex}");
            Console.WriteLine($"Initialization error: {ex}");
        }

        return app;
    }
}
