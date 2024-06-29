using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class BmiTrackingPage : ContentPage
    {
        private const double PoundsToKilograms = 0.45359237;
        private const double InchesToMeters = 0.0254;

        public BmiTrackingPage()
        {
            InitializeComponent();

            weightUnitPicker.SelectedIndex = 0; // kg
            heightUnitPicker.SelectedIndex = 0; // cm
        }

        private void OnWeightUnitChanged(object sender, EventArgs e)
        {
            if (weightUnitPicker.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(weightEntry.Text) && double.TryParse(weightEntry.Text, out double weightLbs))
                {
                    double weightKg = weightLbs * PoundsToKilograms;
                    weightEntry.Text = weightKg.ToString("F1");
                }
            }
            else
            {
               
                if (!string.IsNullOrEmpty(weightEntry.Text) && double.TryParse(weightEntry.Text, out double weightKg))
                {
                    double weightLbs = weightKg / PoundsToKilograms;
                    weightEntry.Text = weightLbs.ToString("F1");
                }
            }
        }

        private void OnHeightUnitChanged(object sender, EventArgs e)
        {
            
            if (heightUnitPicker.SelectedIndex == 1) 
            {
               
                if (!string.IsNullOrEmpty(heightEntry.Text) && ParseFeetAndInches(heightEntry.Text, out double heightFt, out double heightIn))
                {
                    double heightCm = (heightFt * 12 + heightIn) * 2.54; 
                    heightEntry.Text = heightCm.ToString("F1");
                }
            }
          
        }

        private bool ParseFeetAndInches(string input, out double feet, out double inches)
        {
            feet = 0;
            inches = 0;

            
            if (input.Contains('\''))
            {
                
                string[] parts = input.Split('\'');
                if (parts.Length == 2 && double.TryParse(parts[0], out feet) && parts[1].Contains('"'))
                {
                    string[] inchParts = parts[1].Split('"');
                    if (inchParts.Length == 2 && double.TryParse(inchParts[0], out inches))
                    {
                        return true;
                    }
                }
            }
            else
            {
                
                string[] parts = input.Split(new[] { "ft", "in" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && double.TryParse(parts[0], out feet) && double.TryParse(parts[1], out inches))
                {
                    return true;
                }
            }

            return false;
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            if (double.TryParse(weightEntry.Text, out double weight) &&
                double.TryParse(heightEntry.Text, out double height) &&
                height > 0)
            {
                
                if (heightUnitPicker.SelectedIndex == 0)
                {
                    height /= 100;
                }

                
                double bmi = CalculateBMI(weight, height);

                
                string bmiInterpretation = InterpretBMI(bmi);

               
                bmiLabel.Text = $"Your BMI is: {bmi:F2}\n{bmiInterpretation}";

               
                AnimateBMIResult();
            }
            else
            {
                bmiLabel.Text = "Invalid input. Please enter valid weight and height.";
            }
        }

        private double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        private string InterpretBMI(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 24.9)
                return "Normal weight";
            else if (bmi < 29.9)
                return "Overweight";
            else
                return "Obese";
        }

        private async void AnimateBMIResult()
        {
            await bmiLabel.ScaleTo(1.1, 250, Easing.CubicOut);
            await bmiLabel.ScaleTo(1.0, 250, Easing.CubicIn);
        }
    }
}
