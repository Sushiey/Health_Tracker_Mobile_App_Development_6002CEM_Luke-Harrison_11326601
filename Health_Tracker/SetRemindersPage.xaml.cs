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
            string title = TitleEntry.Text;
            DateTime date = DatePicker.Date;
            TimeSpan time = TimePicker.Time;
            
            DateTime reminderDateTime = date.Date + time;

            DisplayAlert("Reminder Set", $"Reminder Title: {title}\nReminder DateTime: {reminderDateTime}", "OK");
        }
    }
}
