using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ScratchMAUI.ViewModel;

namespace ScratchMAUI
{
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
                .UseMauiCommunityToolkit();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>(); 
            builder.Services.AddSingleton<ITextToSpeech>(TextToSpeech.Default);
            builder.Services.AddTransient<CategoryfactViewModel>();
            builder.Services.AddTransient<CategoryFactsPage>();
            builder.Services.AddTransient<FactDetailViewModel>();
            builder.Services.AddTransient<FactDetailPage>();
            
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
