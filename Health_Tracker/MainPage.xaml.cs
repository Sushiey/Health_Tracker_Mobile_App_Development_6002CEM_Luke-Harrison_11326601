// MainPage.xaml.cs

using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Event handler for the "Track Activity" button
        private async void OnTrackActivityClicked(object sender, EventArgs e)
        {
            // Navigate to the activity tracking page
            await Navigation.PushAsync(new ActivityTrackingPage());
        }

        // Event handler for the "Track Nutrition" button
        private async void OnTrackNutritionClicked(object sender, EventArgs e)
        {
            // Navigate to the nutrition tracking page
            await Navigation.PushAsync(new NutritionTrackingPage());
        }

        // Event handler for the "Set Reminders" button
        private async void OnSetRemindersClicked(object sender, EventArgs e)
        {
            // Navigate to the reminders page
            await Navigation.PushAsync(new SetRemindersPage());
        }

        // Event handler for the "BMI Tracking" button
        private async void OnBmiTrackingClicked(object sender, EventArgs e)
        {
            // Navigate to the BMI tracking page
            await Navigation.PushAsync(new BmiTrackingPage());
        }

        // Event handler for the "Weight Tracking" button
        private async void OnWeightTrackingClicked(object sender, EventArgs e)
        {
            // Navigate to the weight tracking page
            await Navigation.PushAsync(new WeightTrackingPage());
        }

        // Event handler for the "Setting Goals" button
        private async void OnSettingGoalsClicked(object sender, EventArgs e)
        {
            // Navigate to the setting goals page
            await Navigation.PushAsync(new SettingGoalsPage());
        }
    }
}
