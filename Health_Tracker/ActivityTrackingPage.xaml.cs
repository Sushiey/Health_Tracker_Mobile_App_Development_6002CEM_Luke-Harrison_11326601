using Microsoft.Maui.Controls;
using System;
using Health_Tracker.Data;
using Health_Tracker;

namespace HealthTrackerApp
{
    public partial class ActivityTrackingPage : ContentPage
    {
        private readonly ActivityRepository _activityRepository;

        public ActivityTrackingPage()
        {
            InitializeComponent();

            string dbPath = AppDatabase.GetDbPath();
            var db = new AppDatabase(dbPath);
            _activityRepository = new ActivityRepository(dbPath);
        }

        private async void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            selectedDateLabel.Text = "Selected Date: " + e.NewDate.ToString("MM/dd/yyyy");

            // Load activity for the selected date
            var activity = await _activityRepository.GetActivityByDateAsync(e.NewDate);
            if (activity != null)
            {
                stepEntry.Text = activity.Steps.ToString();
                stepCountLabel.Text = "Step count for selected date: " + activity.Steps.ToString();
            }
            else
            {
                stepEntry.Text = string.Empty;
                stepCountLabel.Text = "Step count for selected date: Not specified";
            }
        }

        private async void OnEditClicked(object sender, EventArgs e)
        {
            string stepCountText = stepEntry.Text;
            if (!string.IsNullOrEmpty(stepCountText))
            {
                int steps = Convert.ToInt32(stepCountText);

                // Save or update activity for the selected date
                var selectedDate = datePicker.Date;
                var activity = new Activity
                {
                    Date = selectedDate,
                    Steps = steps
                };

                await _activityRepository.SaveActivityAsync(activity);

                // Update step count label
                stepCountLabel.Text = "Step count for selected date: " + steps.ToString();
            }
            else
            {
                stepCountLabel.Text = "Step count for selected date: Not specified";
            }
        }
    }
}
