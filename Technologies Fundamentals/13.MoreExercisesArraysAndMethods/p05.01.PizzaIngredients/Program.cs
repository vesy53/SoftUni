using System;
using System.Collections.Generic;

namespace p05PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine()
                .Split(' ');
            int searchLength = int.Parse(Console.ReadLine());

            int countLength = 0;
            int countIngredients = 0;
            List<string> finalProduct = new List<string>();

            foreach (var item in ingredients)
            {
                foreach (var i in item)
                {
                    countLength++;
                }

                if (countLength == searchLength)
                {
                    Console.WriteLine($"Adding {item}.");
                    finalProduct.Add(item);
                    countIngredients++;

                    if (countIngredients == 10)
                    {
                        break;
                    }
                }

                countLength = 0;
            }

            Console.WriteLine(
                $"Made pizza with total of {countIngredients} ingredients.");
            Console.WriteLine(
                $"The ingredients are: " + string.Join(", ", finalProduct) + ".");
        }
    }
}
