using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Navigate to ActivityTrackingPage
        private async void OnTrackActivityClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActivityTrackingPage());
        }

        // Navigate to NutritionTrackingPage
        private async void OnTrackNutritionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NutritionTrackingPage());
        }

        // Navigate to SettingGoalsPage
        private async void OnSetGoalsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingGoalsPage());
        }

        // Example: Implement summary functionality
        private async void OnSummaryClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Summary", "YOUR ON IT MATEY", "OK");
        }

        // Example: Implement sharing functionality
        private async void OnSharingClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sharing", "Implement sharing features.", "OK");
        }

        // Navigate to BrowsePage
        private async void OnBrowseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrowsePage());
        }
    }
}
