﻿using Microsoft.Maui.Controls;
using System;
using Health_Tracker.Data;

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

            InitializePage();
        }

        private void InitializePage()
        {
        
            datePicker.Date = DateTime.Today;
            selectedDateLabel.Text = "Selected Date: " + datePicker.Date.ToString("MM/dd/yyyy");


            LoadActivityForSelectedDate();
        }

        private async void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            selectedDateLabel.Text = "Selected Date: " + e.NewDate.ToString("MM/dd/yyyy");

            await LoadActivityForSelectedDate();
        }

        private async void OnEditClicked(object sender, EventArgs e)
        {
            string stepCountText = stepEntry.Text;
            if (string.IsNullOrEmpty(stepCountText))
            {
                validationLabel.Text = "Please enter step count.";
                return;
            }

            if (!int.TryParse(stepCountText, out int steps) || steps < 0)
            {
                validationLabel.Text = "Invalid step count. Please enter a valid number.";
                return;
            }


            var selectedDate = datePicker.Date;
            var activity = new Activity
            {
                Date = selectedDate,
                Steps = steps
            };

            await _activityRepository.SaveActivityAsync(activity);


            stepCountLabel.Text = "Step count for selected date: " + steps.ToString();
            validationLabel.Text = "";

            await LoadActivityForSelectedDate();
        }

        private async Task LoadActivityForSelectedDate()
        {
            var selectedDate = datePicker.Date;
            var activity = await _activityRepository.GetActivityByDateAsync(selectedDate);
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
    }
}
