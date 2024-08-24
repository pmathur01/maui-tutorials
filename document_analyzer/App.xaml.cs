using document_analyzer.Pages;

namespace document_analyzer;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();

        if (IsUserLoggedIn())
        {
            MainPage = new FlyoutPage();


        }
        else
        {
            MainPage = new NavigationPage(new LoginPage());
        }


    }


    private bool IsUserLoggedIn()
    {
        return Preferences.Get("IsLoggedIn", false);
    }
}

