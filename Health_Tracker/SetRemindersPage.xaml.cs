using Microsoft.Maui.Controls;
using System;

namespace HealthTrackerApp
{
    public partial class SetRemindersPage : ContentPage
    {
        public SetRemindersPage()
        {
            InitializeComponent();
        }

        private void OnSaveReminderClicked(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string title = TitleEntry.Text;
            DateTime date = DatePicker.Date;
            TimeSpan time = TimePicker.Time;

            // Combine date and time to create the reminder datetime
            DateTime reminderDateTime = date.Date + time;

            // Here, you can handle saving the reminder, such as adding it to a list or storing it in a database
            // For now, let's just display a message
            DisplayAlert("Reminder Set", $"Reminder Title: {title}\nReminder DateTime: {reminderDateTime}", "OK");
        }
    }
}
