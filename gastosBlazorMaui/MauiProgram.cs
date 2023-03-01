using gastosBlazorMaui.Data;
using gastosBlazorMaui.Pages;
using Microsoft.Extensions.Logging;

namespace gastosBlazorMaui;

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

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		builder.Services.AddHttpClient();
		builder.Services.AddSingleton<WeatherForecastService>();
		try
		{
			// Aquí se crea la instancia de la aplicación
			var app = builder.Build();

			return app;
		}
		catch (Exception ex)
		{
			var exlog = ex.Message;

		}
		return builder.Build();
	}

}
