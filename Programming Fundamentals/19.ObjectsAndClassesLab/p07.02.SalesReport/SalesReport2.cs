using System;
using System.Collections.Generic;

class SalesReport2
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        var data = new SortedDictionary<string, double>();

        for (int i = 0; i < num; i++)
        {
            Sale currentSale = Sale.ReadSale();

            string nameTown = currentSale.Town;
            double currentSum = currentSale.Price * currentSale.Quantity;

            if (!data.ContainsKey(nameTown))
            {
                data.Add(nameTown, 0);
            }

            data[nameTown] += currentSum;
        }

        foreach (var itemData in data)
        {
            string town = itemData.Key;
            double sum = itemData.Value;

            Console.WriteLine($"{town} -> {sum:F2}");
        }
    }
}

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }

    public static Sale ReadSale()
    {
        string[] input = Console.ReadLine()
            .Split();

        Sale report = new Sale
        {
            Town = input[0],
            Product = input[1],
            Price = double.Parse(input[2]),
            Quantity = double.Parse(input[3])
        };

        return report;
    }
}