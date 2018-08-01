using System;
using System.Collections.Generic;
using System.Linq;

class SupermarketDatabase2
{
    static void Main(string[] args)
    {
        Dictionary<string, List<decimal>> data = new Dictionary<string, List<decimal>>();

        List<string> input = Console.ReadLine()
            .Split()
            .ToList();

        while (input[0].Equals("stocked") == false)
        {
            string nameProduct = input[0];
            decimal price = decimal.Parse(input[1]);
            int quantity = int.Parse(input[2]);

            if (!data.ContainsKey(nameProduct))
            {
                data.Add(nameProduct, new List<decimal>());
                data[nameProduct].Add(0);
                data[nameProduct].Add(0);
            }

            data[nameProduct][0] = price;
            data[nameProduct][1] += quantity;

            input = Console.ReadLine()
                .Split()
                .ToList();
        }
        decimal grandTotal = 0;

        foreach (var itemData in data)
        {
            string name = itemData.Key;
            List<decimal> priceAndQuantity = itemData.Value;

            Console.Write($"{name}: $");

            for (int i = 0; i < priceAndQuantity.Count - 1; i += 2)
            {
                decimal price = priceAndQuantity[i];
                decimal quantity = priceAndQuantity[i + 1];
                decimal total = price * quantity;
                grandTotal += total;

                Console.WriteLine($"{price:F2} * {quantity} = ${total}");
            }
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${grandTotal}");
    }
}

