using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSummaryIconClicked(object sender, EventArgs e)
        {
            
        }

        
        private void OnSummaryClicked(object sender, EventArgs e)
        {

        }

        private void OnSharingClicked(object sender, EventArgs e)
        {

        }

        private async void OnBrowseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BrowsePage());
        }
    }
}
