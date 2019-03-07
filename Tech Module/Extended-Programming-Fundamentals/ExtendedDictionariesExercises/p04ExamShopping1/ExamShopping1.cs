using System;
using System.Collections.Generic;
using System.Linq;

class ExamShopping1
{
    static void Main(string[] args)
    {
        Dictionary<string, int> shoppingList = new Dictionary<string, int>();
        string command = Console.ReadLine();

        while (command != "shopping time")
        {
            string[] currentStock = command.Split();
            string product = currentStock[1];
            int quantity = int.Parse(currentStock[2]);

            if (!shoppingList.ContainsKey(product))
            {
                shoppingList.Add(product, 0);
            }

            shoppingList[product] += quantity;

            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "exam time")
        {
            string[] currentStock = command.Split();
            string product = currentStock[1];
            int quantity = int.Parse(currentStock[2]);

            if (shoppingList.ContainsKey(product))
            {
                if (shoppingList[product] == 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else
                {
                    shoppingList[product] -= quantity;

                    if (shoppingList[product] < 0)
                    {
                        shoppingList[product] = 0;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{product} doesn't exist");
            }

            command = Console.ReadLine();
        }

        foreach (KeyValuePair<string, int> inventory in shoppingList)
        {
            if (inventory.Value > 0)
            {
                Console.WriteLine($"{inventory.Key} -> {inventory.Value}");
            }
        }
    }
}

