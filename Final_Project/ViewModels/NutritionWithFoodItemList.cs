using Final_Project.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.ViewModels
{
    public class NutritionWithFoodItemList
    {
       
        public int? id { get; set; }
        public int Calories { get; set; }

        public decimal Fat { get; set; } 

        public decimal Carbohydrates { get; set; }

        public decimal Fiber { get; set; } 
        public decimal Sugar { get; set; } 

        public decimal Protein { get; set; }
        public int FoodItemID { get; set; }
        public virtual List<FoodItem> FoodItems { get; set; }
    }
}

