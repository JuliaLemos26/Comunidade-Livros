using ComunidadeLivros.Services;
using ComunidadeLivros.Shared.Data;
using ComunidadeLivros.Shared.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ComunidadeLivros
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
                });

            //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            var connectionString = $@"Server=gyf\\SQLEXPRESS;Database=LivrosComunidade;user id=livros;password=123456;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Add device-specific services used by the ComunidadeLivros.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddScoped<IGeneroService, GeneroService>();
            builder.Services.AddScoped<IMidiaService, MidiaService>();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
