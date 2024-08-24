namespace document_analyzer.Pages;

public partial class MainTabbedPage : TabbedPage
{
    private bool _isSettingsOpened = false;

    public MainTabbedPage()
	{
		InitializeComponent();
	}

	protected override void OnCurrentPageChanged()
	{
        // Check if the current page is the Settings tab
        if (CurrentPage.Title == "Settings" && !_isSettingsOpened)
        {
            _isSettingsOpened = true;
            // Open the Flyout page for Settings
            Navigation.PushModalAsync(new SettingsFlyoutPage());

            // Optionally, reset the selected tab to avoid immediate reopening
            //CurrentPage = Children[0]; // Reset to the first tab (Home) or any other tab
            // Optionally, reset _isSettingsOpened after a delay or after returning to the tabbed page
            _isSettingsOpened = false;
        }

    }


}