using DataBase;
using Microsoft.Extensions.Logging;
using pharmacy.Pages;

namespace pharmacy
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // create data base 
            DBContext dBContext = new DBContext();
            dBContext.Database.EnsureCreated();
            
           // dBContext.Database.EnsureCreated(); 


            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
           

            return builder.Build();
        }
    }
}
