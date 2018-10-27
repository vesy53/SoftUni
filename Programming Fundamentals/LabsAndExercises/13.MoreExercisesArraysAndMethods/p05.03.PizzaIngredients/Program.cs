using System;
using System.Collections.Generic;

namespace p05PizzaIngredients2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine()
                .Split(' ');
            int searchLength = int.Parse(Console.ReadLine());

            int count = 0;
            List<string> finalsProducts = new List<string>();

            for (int i = 0; i < ingredients.Length && count < 10; i++)
            {
                if (ingredients[i].Length == searchLength)
                {
                    count++;
                    finalsProducts.Add(ingredients[i]);

                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
            }

            Console.WriteLine(
                $"Made pizza with total of {count} ingredients.");
            Console.WriteLine(
                $"The ingredients are: " + string.Join(", ", finalsProducts) + ".");
        }
    }
}
