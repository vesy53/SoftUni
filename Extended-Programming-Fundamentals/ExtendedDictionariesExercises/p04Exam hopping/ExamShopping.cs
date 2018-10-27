using System;
using System.Collections.Generic;

class ExamShopping
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

        foreach (KeyValuePair<string, int> inventory in shopsInventory)
        {
            if (inventory.Value >= 1)
            {
                Console.WriteLine($"{inventory.Key} -> {inventory.Value}");
            }
        }
    }
}

