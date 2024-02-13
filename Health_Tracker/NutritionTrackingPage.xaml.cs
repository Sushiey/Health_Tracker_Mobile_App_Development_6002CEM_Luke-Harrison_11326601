// NutritionTrackingPage.xaml.cs

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
            // Implement logic to retrieve food intake for the selected date
            // For demonstration purposes, let's display a message with the selected date
            foodIntakeLabel.Text = "Food intake for selected date: " + selectedDate.ToShortDateString();
        }

        private void OnEditClicked(object sender, EventArgs e)
        {
            // Implement your logic here for saving or editing food intake
            // For example, you can retrieve the calories and food eaten from the entry fields
            string caloriesText = caloriesEntry.Text;
            string foodIntakeText = foodEntry.Text;
            if (!string.IsNullOrEmpty(caloriesText) && !string.IsNullOrEmpty(foodIntakeText))
            {
                // Update the food intake label
                foodIntakeLabel.Text = $"Food intake for selected date:\nCalories: {caloriesText}\nFood eaten: {foodIntakeText}";

                // Add the food item to the list
                foodItems.Add(new FoodItem { FoodName = foodIntakeText, Calories = Convert.ToInt32(caloriesText) });

                // Update the list view
                foodListView.ItemsSource = null;
                foodListView.ItemsSource = foodItems;

                // Calculate total calories consumed for the selected date
                int totalCalories = 0;
                foreach (var item in foodItems)
                {
                    totalCalories += item.Calories;
                }
                totalCaloriesLabel.Text = $"Total calories consumed: {totalCalories}";
            }
            else
            {
                // Handle case where calories or food intake is empty
                foodIntakeLabel.Text = "Please enter both calories and food eaten.";
            }
        }
    }

    // Model class for food items
    public class FoodItem
    {
        public string FoodName { get; set; }
        public int Calories { get; set; }
    }
}
