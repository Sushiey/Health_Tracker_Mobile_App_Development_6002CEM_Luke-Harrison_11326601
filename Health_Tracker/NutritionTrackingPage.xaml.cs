using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace HealthTrackerApp
{
    public partial class NutritionTrackingPage : ContentPage
    {
        private List<FoodItem> foodItems;

        public NutritionTrackingPage()
        {
            InitializeComponent();
            foodItems = new List<FoodItem>();
            foodListView.ItemsSource = foodItems;
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime selectedDate = e.NewDate;
            foodIntakeLabel.Text = "Food intake for selected date: " + selectedDate.ToShortDateString();
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            string caloriesText = caloriesEntry.Text;
            string foodIntakeText = foodEntry.Text;
            if (!string.IsNullOrEmpty(caloriesText) && !string.IsNullOrEmpty(foodIntakeText))
            {
                foodIntakeLabel.Text = $"Food intake for selected date:\nCalories: {caloriesText}\nFood eaten: {foodIntakeText}";

                foodItems.Add(new FoodItem { FoodName = foodIntakeText, Calories = Convert.ToInt32(caloriesText) });

                foodListView.ItemsSource = null;
                foodListView.ItemsSource = foodItems;

                int totalCalories = 0;
                foreach (var item in foodItems)
                {
                    totalCalories += item.Calories;
                }
                totalCaloriesLabel.Text = $"Total calories consumed: {totalCalories}";
            }
            else
            {
                foodIntakeLabel.Text = "Please enter both calories and food eaten.";
            }
        }
    }

    public class FoodItem
    {
        public string FoodName { get; set; }
        public int Calories { get; set; }
    }
}
