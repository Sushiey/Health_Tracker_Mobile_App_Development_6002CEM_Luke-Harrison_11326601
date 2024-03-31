using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSummaryIconClicked(object sender, EventArgs e)
        {
            // Implement logic for summary icon clicked
        }

        private async void OnSummaryClicked(object sender, EventArgs e)
        {
            // Implement logic for summary button clicked
        }

        private async void OnSharingClicked(object sender, EventArgs e)
        {
            // Implement logic for sharing button clicked
        }

        private async void OnBrowseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrowsePage());
        }
    }
}
