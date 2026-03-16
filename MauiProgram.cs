using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TravelExpenseTracker.Pages;
using TravelExpenseTracker.ViewModels;

namespace TravelExpenseTracker
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
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                })
                .UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            //Dependecency Injection
            //Login VM and Page
            builder.Services
                .AddTransient<LoginViewModel>()
                .AddTransient<LoginPage>();

            //Register VM and Page
            builder.Services
                .AddTransient<RegisterViewModel>()
                .AddTransient<RegisterPage>();

            return builder.Build();
        }
    }
}
