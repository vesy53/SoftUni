using System;
using System.Collections.Generic;

class SupermarketDatabase3
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, decimal>>();

        string[] input = Console.ReadLine()
            .Split();

        while (input[0] != "stocked")
        {
            string name = input[0];
            decimal price = decimal.Parse(input[1]);
            decimal quantity = decimal.Parse(input[2]);

            if (!data.ContainsKey(name))
            {
                data.Add(name, new Dictionary<string, decimal>());
                data[name]["Price"] = 0;
                data[name]["Quantity"] = 0;
            }

            data[name]["Price"] = price;
            data[name]["Quantity"] += quantity;

            input = Console.ReadLine()
                .Split();
        }

        decimal result = 0;

        foreach (var element in data)
        {
            string name = element.Key;
            Dictionary<string, decimal> priceAndQuantity = element.Value;

            decimal currentPrice = priceAndQuantity["Price"];
            decimal currentQuantity = priceAndQuantity["Quantity"];
            decimal sum = currentPrice * currentQuantity;

            result += sum;

            Console.WriteLine(
                $"{name}: ${currentPrice:F2} * {currentQuantity} = ${sum:F2}");
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${result:F2}");
    }
}

