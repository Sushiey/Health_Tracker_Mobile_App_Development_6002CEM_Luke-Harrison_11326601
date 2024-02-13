using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class WeightTrackingPage : ContentPage
    {
        public WeightTrackingPage()
        {
            InitializeComponent();
        }

        // Event handler for the "Save Weight" button
        private void OnSaveWeightClicked(object sender, EventArgs e)
        {
            if (double.TryParse(weightEntry.Text, out double weight))
            {
                // Save the weight
                // Replace this with your actual implementation to save weight data
                // For example, you could use Xamarin.Essentials Preferences or a database
                SaveWeight(weight);

                // Display the last saved weight
                lastWeightLabel.Text = $"Last saved weight: {weight} kg";
            }
            else
            {
                lastWeightLabel.Text = "Invalid input. Please enter a valid weight.";
            }
        }

        // Method to save the weight (replace with actual implementation)
        private void SaveWeight(double weight)
        {
            // Replace this method with your actual implementation to save weight data
            // For example, you could use Xamarin.Essentials Preferences or a database
            // This is just a placeholder
        }
    }
}
