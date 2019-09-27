using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge_Repository
{
    public class Menu                      
    {
        public Menu()
        {

        }
        public Menu(int mealNumber, string mealName, string mealDescription, string mealIngredients, float mealPrice)
        {
            var MealNumber = mealNumber;
            var MealName = mealName;
            var MealDescription = mealDescription;
            var MealIngredients = mealIngredients;
            var MealPrice = mealPrice;
        }
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public float MealPrice { get; set; }

    }
}
