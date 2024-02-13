using Microsoft.Maui.Controls;
using System;

namespace HealthTrackerApp
{
    public partial class ActivityTrackingPage : ContentPage
    {
        public ActivityTrackingPage()
        {
            InitializeComponent();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            // Update the selected date label with the chosen date from the DatePicker
            selectedDateLabel.Text = "Selected Date: " + e.NewDate.ToString("MM/dd/yyyy");
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            // Implement your logic here for editing step count
            // For example, you can retrieve the step count from the entry field
            string stepCountText = stepEntry.Text;
            if (!string.IsNullOrEmpty(stepCountText))
            {
                // Update the step count label
                stepCountLabel.Text = "Step count for selected date: " + stepCountText;
            }
            else
            {
                // Handle case where step count is empty
                stepCountLabel.Text = "Step count for selected date: Not specified";
            }
        }
    }
}
