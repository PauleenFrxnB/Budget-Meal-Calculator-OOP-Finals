using System;

namespace Budget_Meal_Calculator_OOP_Finals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] Menu = { "Hamsilog", "Hotsilog", "Silog", "Porksilog", "Longsilog", "Tapsilog", "Tocisilog" };
            int[] Prices = { 50, 55, 60, 70, 80, 90, 100 };

            Console.WriteLine("Budget Meal Calculator");
            Console.Write("Enter budget: ");
            int Budget = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            bool Restart = true;
            while (Restart)
            {
                if (Budget >= 50 && Budget <= 100)
                {
                    DisplayMeals(Menu, Prices, 0, 2);
                    Console.Write("Pick your silog Meal: ");
                    int Meal = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (Meal == 1 || Meal == 2)
                    {
                        Recipe.DisplayRecipe(Menu, Meal - 1);
                        DisplayMealCount(Budget, Prices[Meal - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else if (Budget >= 101 && Budget <= 200)
                {
                    DisplayMeals(Menu, Prices, 2, 4);
                    Console.Write("Pick your silog Meal: ");
                    int Meal = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (Meal == 3 || Meal == 4)
                    {
                        Recipe.DisplayRecipe(Menu, Meal - 1);
                        DisplayMealCount(Budget, Prices[Meal - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else if (Budget >= 201 && Budget <= 300)
                {
                    DisplayMeals(Menu, Prices, 4, 7);
                    Console.Write("Pick your silog Meal: ");
                    int Meal = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (Meal >= 5 && Meal <= 7)
                    {
                        Recipe.DisplayRecipe(Menu, Meal - 1);
                        DisplayMealCount(Budget, Prices[Meal - 1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Amount");
                }

                Console.Write("Do you want to enter another Budget? Y/N: ");
                string response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    Console.Write("Enter budget: ");
                    Budget = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    Restart = false;
                }
            }
        }

        static void DisplayMeals(string[] Menu, int[] Prices, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.WriteLine($"{i + 1} - {Menu[i]} (P{Prices[i]})");
            }
        }

        static void DisplayMealCount(int budget, int price)
        {
            int count = budget / price;
            Console.WriteLine($"You can buy {count} meal(s) with your budget of {budget}.");
        }
    }
}