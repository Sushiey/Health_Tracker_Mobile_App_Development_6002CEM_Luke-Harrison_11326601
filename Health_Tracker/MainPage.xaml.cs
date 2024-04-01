using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Remove async keyword if no asynchronous operations are performed
        private void OnSummaryIconClicked(object sender, EventArgs e)
        {
            // Implement logic for summary icon clicked
        }

        // Remove async keyword if no asynchronous operations are performed
        private void OnSummaryClicked(object sender, EventArgs e)
        {
            // Implement logic for summary button clicked
        }

        // Remove async keyword if no asynchronous operations are performed
        private void OnSharingClicked(object sender, EventArgs e)
        {
            // Implement logic for sharing button clicked
        }

        // Keep the async keyword if you're awaiting an asynchronous operation like Navigation
        private async void OnBrowseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrowsePage());
        }
    }
}
