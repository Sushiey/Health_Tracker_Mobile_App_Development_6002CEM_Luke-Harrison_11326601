using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTrackActivityClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActivityTrackingPage());
        }

        private async void OnTrackNutritionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NutritionTrackingPage());
        }

        private async void OnSetGoalsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingGoalsPage());
        }

        private async void OnSummaryClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Summary", "YOUR ON IT MATEY", "OK");
        }

        private async void OnSharingClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sharing", "Implement sharing features.", "OK");
        }

        private async void OnBrowseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrowsePage());
        }
    }
}
