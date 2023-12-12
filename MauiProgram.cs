namespace Ionel_Maxian_Lab7;

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
			.ConfigureEssentials(essentials =>
			{
				essentials.UseMapServiceToken("pCGziGISdMJ3Acm4Rxpf~g-yf_IP_iiZLK5vDpXLLlg~Aj5lnlWt9mms5SuOSooVS-vT7_ixY_u8rzurMcAvCs8gtkjFl61ABDk6_0H-DL-2");
			});

		return builder.Build();
	}
}
