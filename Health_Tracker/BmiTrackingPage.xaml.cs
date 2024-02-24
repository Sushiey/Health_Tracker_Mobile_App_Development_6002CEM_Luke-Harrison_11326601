using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class BmiTrackingPage : ContentPage
    {
        public BmiTrackingPage()
        {
            InitializeComponent();
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (double.TryParse(weightEntry.Text, out double weight) &&
                double.TryParse(heightEntry.Text, out double height) &&
                height > 0)
            {
                double bmi = weight / (height * height);

                bmiLabel.Text = $"Your BMI is: {bmi:F2}";
            }
            else
            {
                bmiLabel.Text = "Invalid input. Please enter valid weight and height.";
            }
        }
    }
}
