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
            selectedDateLabel.Text = "Selected Date: " + e.NewDate.ToString("MM/dd/yyyy");
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            string stepCountText = stepEntry.Text;
            if (!string.IsNullOrEmpty(stepCountText))
            {
                stepCountLabel.Text = "Step count for selected date: " + stepCountText;
            }
            else
            {
                stepCountLabel.Text = "Step count for selected date: Not specified";
            }
        }
    }
}
