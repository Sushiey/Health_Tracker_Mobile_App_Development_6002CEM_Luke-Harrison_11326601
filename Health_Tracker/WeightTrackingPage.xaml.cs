using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class WeightTrackingPage : ContentPage
    {
        public WeightTrackingPage()
        {
            InitializeComponent();
        }
        
        private void OnSaveWeightClicked(object sender, EventArgs e)
        {
            if (double.TryParse(weightEntry.Text, out double weight))
            {
                SaveWeight(weight);

                lastWeightLabel.Text = $"Last saved weight: {weight} kg";
            }
            else
            {
                lastWeightLabel.Text = "Invalid input. Please enter a valid weight.";
            }
        }

        private void SaveWeight(double weight)
        {
        }
    }
}
