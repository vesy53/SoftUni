namespace p02._02.MakeASalad
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MakeASalad
    {
        static void Main(string[] args)
        {
            string[] vegetablesInput = Console.ReadLine()
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToArray();

            int[] caloriesInput = Console.ReadLine()
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> saladCalories = new Stack<int>(caloriesInput);
            Queue<string> vegetables = new Queue<string>(vegetablesInput);

            Queue<int> salads = new Queue<int>();

            while (saladCalories.Any() && 
                   vegetables.Any())
            {
                int currentCalorie = saladCalories.Peek();

                while (currentCalorie > 0 && 
                       vegetables.Any())
                {
                    string currentVegetable = vegetables.Dequeue();

                    if (currentVegetable == "tomato")
                    {
                        currentCalorie -= 80;
                    }
                    else if (currentVegetable == "carrot")
                    {
                        currentCalorie -= 136;
                    }
                    else if (currentVegetable == "lettuce")
                    {
                        currentCalorie -= 109;
                    }
                    else if (currentVegetable == "potato")
                    {
                        currentCalorie -= 215;
                    }
                }

                salads.Enqueue(saladCalories.Pop());
            }

            Console.WriteLine(string.Join(" ", salads));

            if (saladCalories.Any())
            {
                Console.WriteLine(string.Join(" ", saladCalories));
            }
            else if (vegetables.Any())
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }
        }
    }
}