using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Meal_Calculator_OOP_Finals
{
    public static class Recipe
    {
        public static void DisplayRecipe(string[] Menu, int index)
        {
            switch (index)
            {
                case 0:
                    Console.WriteLine($"Recipe for {Menu[0]}");
                    Console.WriteLine("Ingredients: Ham, egg, garlic rice.");
                    break;
                case 1:
                    Console.WriteLine($"Recipe for {Menu[1]}");
                    Console.WriteLine("Ingredients: Hotdog, egg, garlic rice.");
                    break;
                case 2:
                    Console.WriteLine($"Recipe for {Menu[2]}");
                    Console.WriteLine("Ingredients: Fried egg, garlic rice.");
                    break;
                case 3:
                    Console.WriteLine($"Recipe for {Menu[3]}");
                    Console.WriteLine("Ingredients: Pork chop, egg, garlic rice.");
                    break;
                case 4:
                    Console.WriteLine($"Recipe for {Menu[4]}");
                    Console.WriteLine("Ingredients: Longganisa, egg, garlic rice.");
                    break;
                case 5:
                    Console.WriteLine($"Recipe for {Menu[5]}");
                    Console.WriteLine("Ingredients: Beef tapa, egg, garlic rice.");
                    break;
                case 6:
                    Console.WriteLine($"Recipe for {Menu[6]}");
                    Console.WriteLine("Ingredients: Tocino, egg, garlic rice.");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}