using System;
using System.Collections.Generic;

namespace p05PizzaIngredients1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine()
                .Split(' ');
            int searchLength = int.Parse(Console.ReadLine());

            int count = 0;
            List<string> finalProducts = new List<string>();

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == searchLength)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    count++;
                    finalProducts.Add(ingredients[i]);

                    if (count >= 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(
                $"Made pizza with total of {count} ingredients.");
            Console.WriteLine(
                $"The ingredients are: " + string.Join(", ", finalProducts) + ".");
        }
    }
}
