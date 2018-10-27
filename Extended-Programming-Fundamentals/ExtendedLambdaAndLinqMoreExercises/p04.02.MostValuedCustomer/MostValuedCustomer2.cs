using System;
using System.Collections.Generic;
using System.Linq;

class MostValuedCustomer2
{
    static void Main(string[] args)
    {
        var productsData = new Dictionary<string, double>();
        var customersData = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "Shop is open")
        {
            string[] inputTokens = input
                .Split();

            string productName = inputTokens[0];
            double price = double.Parse(inputTokens[1]);

            productsData[productName] = price;

            input = Console.ReadLine();
        }

        string command = Console.ReadLine();

        while (command != "Print")
        {
            string[] commandTokens = command
                .Split(new string[] { ": ", ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            if (commandTokens[0] == "Discount")
            {
                var discountedProducts = productsData
                        .OrderByDescending(x => x.Value)
                        .Take(3)
                        .Select(x =>
                            new KeyValuePair<string, double>(x.Key, x.Value * 0.9));

                foreach (var discountedProduct in discountedProducts)
                {
                    string productName = discountedProduct.Key;
                    double price = discountedProduct.Value;

                    productsData[productName] = price;
                    //second method
                    //productsData[discountedProduct.Key] = discountedProduct.Value;
                }
            }
            else
            {
                string customerName = commandTokens[0];

                if (!customersData.ContainsKey(customerName))
                {
                    customersData.Add(customerName, new List<string>());
                }

                for (int i = 1; i < commandTokens.Length; i++)
                {
                    string productsName = commandTokens[i];

                    if (productsData.ContainsKey(productsName))
                    {
                        customersData[customerName].Add(productsName);
                    }
                }
            }

            command = Console.ReadLine();
        }


        var topCustomer = customersData
            .OrderByDescending(x => x.Value.Sum(product => productsData[product]))
            .First();

        string name = topCustomer.Key;
        List<string> productsBought = topCustomer.Value;
        Console.WriteLine($"Biggest spender: {name}");
        Console.WriteLine("^Products bought:");

        double total = productsBought
            .Sum(x => productsData[x]);
        var orderedProducts = productsBought
            .Distinct()
            .OrderByDescending(x => productsData[x]);

        foreach (var product in orderedProducts)
        {
            Console.WriteLine(
                $"^^^{product}: {productsData[product]:F2}");
        }

        Console.WriteLine($"Total: {total:F2}");
    }
}

