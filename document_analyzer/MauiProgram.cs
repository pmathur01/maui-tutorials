using CommunityToolkit.Maui;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace document_analyzer;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>().ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
			builder.UseMauiCompatibility();
			builder.UseMauiCommunityToolkit();

			builder = registerDependencyServices(builder);
			builder = regsiterPages(builder);

		return builder.Build();
	}

	private static MauiAppBuilder registerDependencyServices(MauiAppBuilder builder){
			return builder;
	}

	private static MauiAppBuilder regsiterPages(MauiAppBuilder builder){
			return builder;
	}
}

