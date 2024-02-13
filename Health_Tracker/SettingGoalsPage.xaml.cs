using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class SettingGoalsPage : ContentPage
    {
        public SettingGoalsPage()
        {
            InitializeComponent();
        }

        // Event handler for the "Save Goals" button
        private void OnSaveGoalsClicked(object sender, EventArgs e)
        {
            if (int.TryParse(stepGoalEntry.Text, out int stepGoal) && int.TryParse(calorieGoalEntry.Text, out int calorieGoal))
            {
                // Save the goals
                // Replace this with your actual implementation to save goals data
                // For example, you could use Xamarin.Essentials Preferences or a database
                SaveGoals(stepGoal, calorieGoal);
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter valid numeric values for step and calorie goals.", "OK");
            }
        }

        // Method to save the goals (replace with actual implementation)
        private void SaveGoals(int stepGoal, int calorieGoal)
        {
            // Replace this method with your actual implementation to save goals data
            // For example, you could use Xamarin.Essentials Preferences or a database
            // This is just a placeholder
        }
    }
}
