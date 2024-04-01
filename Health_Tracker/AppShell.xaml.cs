using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            // Disable back button functionality
            return true;
        }
    }
}
