using Microsoft.Maui.Controls;

namespace HealthTrackerApp
{
    public partial class SettingGoalsPage : ContentPage
    {
        public SettingGoalsPage()
        {
            InitializeComponent();
        }

        private void OnSaveGoalsClicked(object sender, EventArgs e)
        {
            if (int.TryParse(stepGoalEntry.Text, out int stepGoal) && int.TryParse(calorieGoalEntry.Text, out int calorieGoal))
            {

                SaveGoals(stepGoal, calorieGoal);
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter valid numeric values for step and calorie goals.", "OK");
            }
        }

        private void SaveGoals(int stepGoal, int calorieGoal)
        {

        }
    }
}
