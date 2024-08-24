namespace document_analyzer.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}


    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Simple validation (replace with real authentication logic)
        if (username == "user" && password == "password")
        {
            ErrorLabel.IsVisible = false;
            //   await Navigation.PushAsync(new MasterDetailContainer());
            // Navigate to the Tabbed Page
            // await Navigation.PushAsync(new MainTabbedPage());

            await Navigation.PushAsync(new MainFlyoutPage());

        }
        else
        {
            ErrorLabel.Text = "Invalid username or password";
            ErrorLabel.IsVisible = true;
        }
    }

}
