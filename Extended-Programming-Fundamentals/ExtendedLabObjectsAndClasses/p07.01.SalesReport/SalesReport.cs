using System;
using System.Linq;
using System.Collections.Generic;

class SalesReport
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<Sale> sales = new List<Sale>();

        for (int i = 0; i < num; i++)
        {
            Sale report = ReadSale();

            sales.Add(report);
        }

        List<string> towns = sales
            .Select(x => x.Town)
            .Distinct()
            .OrderBy(town => town)
            .ToList();

        foreach (var town in towns)
        {
            double currentSum = sales
                .Where(x => x.Town == town)
                .Sum(x => x.Price * x.Quantity);

            Console.WriteLine($"{town} -> {currentSum:F2}");
        }
    }

    static Sale ReadSale()
    {
        string[] input = Console.ReadLine()
            .Split();

        Sale inputTokens = new Sale
        {
            Town = input[0],
            Product = input[1],
            Price = double.Parse(input[2]),
            Quantity = double.Parse(input[3])
        };

        return inputTokens;
    }
}

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public double Quantity { get; set; }
}