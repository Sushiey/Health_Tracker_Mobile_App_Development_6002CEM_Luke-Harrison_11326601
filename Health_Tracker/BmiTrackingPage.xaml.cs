using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class BmiTrackingPage : ContentPage
    {
        public BmiTrackingPage()
        {
            InitializeComponent();
        }

        // Event handler for the "Calculate BMI" button
        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (double.TryParse(weightEntry.Text, out double weight) &&
                double.TryParse(heightEntry.Text, out double height) &&
                height > 0)
            {
                // Calculate BMI
                double bmi = weight / (height * height);

                // Display BMI
                bmiLabel.Text = $"Your BMI is: {bmi:F2}";
            }
            else
            {
                bmiLabel.Text = "Invalid input. Please enter valid weight and height.";
            }
        }
    }
}
