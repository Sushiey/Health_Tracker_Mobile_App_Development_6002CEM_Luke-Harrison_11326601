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
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue.ToLowerInvariant();

            foreach (View view in buttonStackLayout.Children)
            {
                if (view is Button button)
                {
                    string buttonText = button.Text.ToLowerInvariant();

                    bool isVisible = string.IsNullOrEmpty(searchText) || buttonText.Contains(searchText);

                    button.IsVisible = isVisible;
                }
            }
        }

        private async void OnSummaryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

              private async void OnSharingClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Share", "Share functionality will be implemented here", "OK");
        }

           private void OnBrowseClicked(object sender, EventArgs e)
        {
            
        }
    }
}
