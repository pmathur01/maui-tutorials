namespace document_analyzer.Pages;

public partial class MainFlyoutPage : FlyoutPage
{
       private bool _isFlyoutOpened = false;
    public MainFlyoutPage()
    {
        InitializeComponent();

        // Subscribe to the CurrentPageChanged event of the TabbedPage
        var tabbedPage = (TabbedPage)((NavigationPage)Detail).RootPage;
        tabbedPage.CurrentPageChanged += OnCurrentPageChanged;

        // Subscribe to the IsPresentedChanged event
        this.IsPresentedChanged += MainFlyoutPage_IsPresentedChanged;
    }


   
   
        // Method to show the flyout when the Settings tab appears
      /*  private void OnSettingsAppearing(object sender, EventArgs e)
        {
            // Check if the Flyout is already opened to avoid the loop
            if (!_isFlyoutOpened)
            {
                _isFlyoutOpened = true;

                // Show the flyout menu
                IsPresented = true;

            // Reset the selected tab to avoid looping
            //((TabbedPage)((NavigationPage)Detail).RootPage).CurrentPage = ((TabbedPage)((NavigationPage)Detail).RootPage).Children[0];
            //tabbedPage.
        }
        }*/


    // Event handler for when the current tab is changed
    private void OnCurrentPageChanged(object sender, EventArgs e)
    {
        var tabbedPage = (TabbedPage)sender;

        // Check if the current page is the Home tab
        
         if (tabbedPage.CurrentPage.Title == "Settings")
        {
            // Show the Flyout if it’s not already open
            if (!_isFlyoutOpened)
            {
                _isFlyoutOpened = true;

                // Show the flyout menu
                IsPresented = true;
            }

            // Prevent further interaction until Flyout is closed
            _isFlyoutOpened = false;
        }
        else
        {
            // Reset the flyout flag if the user moves away from the Settings tab
            _isFlyoutOpened = false;
            // Hide the flyout menu
            IsPresented = false;
        }
    }



    // Override OnIsPresentedChanged to handle flyout visibility changes
    private void MainFlyoutPage_IsPresentedChanged(object sender, EventArgs e)
    {

        // Reset the flag when the flyout is closed
        if (!IsPresented)
        {
            _isFlyoutOpened = false;
        }
    }
    // Close the Flyout
    private async void OnCloseButtonClicked(object sender, EventArgs e)
        {
            IsPresented = false; // Close the flyout
            _isFlyoutOpened = false; // Reset the flag when closing the flyout
        }
}
