#if IOS
using ButtonRendererCrashRepro.Platforms.iOS;
#endif
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace ButtonRendererCrashRepro;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCompatibility()
			.ConfigureMauiHandlers(handlers =>
			{
#if IOS
					handlers.AddCompatibilityRenderer(
						typeof(AppButton),
						typeof(AppButtonRenderer));
#endif
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
