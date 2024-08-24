namespace document_analyzer.Pages;

public partial class MasterDetailContainer : FlyoutPage
{
	public MasterDetailContainer()
	{
		InitializeComponent();
	}

    

    private async void OnDashboardButtonClicked(object sender, EventArgs e)
    {
        var navigationPage = (NavigationPage)Detail;
        await navigationPage.Navigation.PushAsync(new DashboardPage());
        IsPresented = false; // Close the flyout menu
    }

    private async void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        Preferences.Set("IsLoggedIn", false);
        Application.Current.MainPage = new NavigationPage(new LoginPage());
        IsPresented = false; // Close the flyout menu
    }
}

