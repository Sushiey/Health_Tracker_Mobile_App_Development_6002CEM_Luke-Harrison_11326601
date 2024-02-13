using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
