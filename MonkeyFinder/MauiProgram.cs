using Microsoft.Extensions.Logging;
using MonkeyFinder.Services;
using MonkeyFinder.ViewModels;
using MonkeyFinder.Views;

namespace MonkeyFinder;

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
            });

        // Services
        builder.Services.AddSingleton<MonkeyService>();

        // ViewModels
        builder.Services.AddSingleton<MonkeysViewModel>();
        //builder.Services.AddTransient<MonkeyDetailsViewModel>();

        // Views
        builder.Services.AddSingleton<MonkeysPage>();
        builder.Services.AddTransient<MonkeyDetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}