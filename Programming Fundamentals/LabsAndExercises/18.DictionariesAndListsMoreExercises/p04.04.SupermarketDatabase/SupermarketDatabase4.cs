using System;
using System.Collections.Generic;
using System.Linq;

class SupermarketDatabase4
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<double, double>>();

        string input = Console.ReadLine();

        while (input.Equals("stocked") == false)
        {
            string[] products = input
                .Split();

            string name = products[0];
            double price = double.Parse(products[1]);
            double quantity = double.Parse(products[2]);

            if (!data.ContainsKey(name))
            {
                data.Add(name, new Dictionary<double, double>());
            }

            if (!data[name].ContainsKey(price))
            {
                data[name].Add(price, 0);
            }

            data[name][price] += quantity;

            input = Console.ReadLine();
        }

        double total = 0;

        foreach (var elements in data)
        {
            string name = elements.Key;
            double price = elements.Value.Keys.Last();
            double quantity = elements.Value.Values.Sum();
            double sum = quantity * price;
            total += sum;

            Console.WriteLine($"{name}: ${price:F2} * {quantity} = ${sum:F2}");
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${total:F2}");
    }
}

