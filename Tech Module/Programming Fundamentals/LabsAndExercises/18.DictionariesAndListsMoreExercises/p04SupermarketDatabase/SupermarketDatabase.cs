using System;
using System.Collections.Generic;
using System.Linq;

class SupermarketDatabase
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, decimal>();
        var dataQuantity = new Dictionary<string, int>();

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
                data.Add(nameProduct, 0);
                dataQuantity.Add(nameProduct, 0);
            }

            data[nameProduct] = price;
            dataQuantity[nameProduct] += quantity;

            input = Console.ReadLine()
                .Split()
                .ToList();
        }

        decimal total = 0;

        foreach (var element in data)
        {
            string name = element.Key;
            decimal price = element.Value;
            decimal sum = price * dataQuantity[name];
            total += price * dataQuantity[name];

            Console.WriteLine(
                $"{name}: ${price:F2} * {dataQuantity[name]} = ${sum:F2}");         
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Grand Total: ${total:F2}");
    }
}

