using Microsoft.Maui.Controls;
using System;

namespace HealthTrackerApp
{
    public partial class BrowsePage : ContentPage
    {
        public BrowsePage()
        {
            InitializeComponent();
        }

        // Event handlers for button clicks (you can add your logic here)
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

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Add your search logic here
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            // Placeholder for search logic
            // You can filter the list based on the entered text and update the UI accordingly
        }

        // Placeholder method for the Summary button
        private void OnSummaryClicked(object sender, EventArgs e)
        {
            // Implement logic for summary button clicked
        }

        // Placeholder method for the Sharing button
        private void OnSharingClicked(object sender, EventArgs e)
        {
            // Implement logic for sharing button clicked
        }

        // Placeholder method for the Browse button
        private void OnBrowseClicked(object sender, EventArgs e)
        {
            // Implement logic for browse button clicked
        }
    }
}
