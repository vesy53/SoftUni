using System;
using System.Linq;
using System.Collections.Generic;

class ExamShopping2
{
    static void Main(string[] args)
    {
        Dictionary<string, int> shopsInventory = new Dictionary<string, int>();
        string[] inputProduct = Console.ReadLine()
            .Split();

        while (inputProduct[0] != "shopping" && inputProduct[1] != "time")
        {
            string product = inputProduct[1];
            int quantity = int.Parse(inputProduct[2]);

            if (!shopsInventory.ContainsKey(product))
            {
                shopsInventory.Add(product, 0);
            }

            shopsInventory[product] += quantity;

            inputProduct = Console.ReadLine().Split();
        }

        inputProduct = Console.ReadLine().Split();

        while (inputProduct[0] != "exam" && inputProduct[1] != "time")
        {
            string product = inputProduct[1];
            int quantity = int.Parse(inputProduct[2]);

            if (shopsInventory.ContainsKey(product))
            {
                if (shopsInventory[product] > 0)
                {
                    shopsInventory[product] -= quantity;
                }
                else
                {
                    Console.WriteLine($"{product} out of stock");
                }
            }
            else
            {
                Console.WriteLine($"{product} doesn't exist");
            }

            inputProduct = Console.ReadLine().Split();
        }

        Dictionary<string, int> leftProducts = shopsInventory
            .Where(p => p.Value > 0)
            .ToDictionary(p => p.Key, p => p.Value);

        foreach (KeyValuePair<string, int> inventory in leftProducts)
        {
            Console.WriteLine($"{inventory.Key} -> {inventory.Value}");
        }
    }
}

