using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HealthTrackerApp
{
    public partial class NutritionTrackingPage : ContentPage
    {
        private List<FoodItem> _foodItems;
        private DateTime _selectedDate;

        public NutritionTrackingPage()
        {
            InitializeComponent();
            _foodItems = new List<FoodItem>();
            foodListView.ItemsSource = _foodItems;
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            _selectedDate = e.NewDate;
            UpdateFoodIntakeForDate();
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            string caloriesText = caloriesEntry.Text;
            string foodIntakeText = foodEntry.Text;
            if (!string.IsNullOrEmpty(caloriesText) && !string.IsNullOrEmpty(foodIntakeText))
            {
                int calories = Convert.ToInt32(caloriesText);
                _foodItems.Add(new FoodItem { FoodName = foodIntakeText, Calories = calories, Date = _selectedDate });

                UpdateFoodIntakeForDate();
                ClearEntryFields();
            }
            else
            {
                foodIntakeLabel.Text = "Please enter both calories and food eaten.";
            }
        }

        private void UpdateFoodIntakeForDate()
        {
            var foodIntake = _foodItems.Where(item => item.Date.Date == _selectedDate.Date).ToList();

            if (foodIntake.Any())
            {
                foodIntakeLabel.Text = $"Food intake for {_selectedDate.ToShortDateString()}";
                foodListView.ItemsSource = foodIntake;
                int totalCalories = foodIntake.Sum(item => item.Calories);
                totalCaloriesLabel.Text = $"Total calories consumed: {totalCalories}";
            }
            else
            {
                foodIntakeLabel.Text = $"No food intake recorded for {_selectedDate.ToShortDateString()}";
                foodListView.ItemsSource = null;
                totalCaloriesLabel.Text = "Total calories consumed: 0";
            }
        }

        private void ClearEntryFields()
        {
            caloriesEntry.Text = string.Empty;
            foodEntry.Text = string.Empty;
        }
    }

    public class FoodItem
    {
        public string FoodName { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
    }
}
