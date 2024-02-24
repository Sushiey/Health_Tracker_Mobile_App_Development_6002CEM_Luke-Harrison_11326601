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

        private async void OnSetRemindersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SetRemindersPage());
        }

        private async void OnBmiTrackingClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BmiTrackingPage());
        }

        private async void OnWeightTrackingClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeightTrackingPage());
        }

        private async void OnSettingGoalsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingGoalsPage());
        }
    }
}
