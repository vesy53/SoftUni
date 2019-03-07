using System;
using System.Collections.Generic;
using System.Linq;

class CottageScraper2
{
    static void Main(string[] args)
    {
        var data = new List<KeyValuePair<string, int>>();

        string input = Console.ReadLine();

        while (input != "chop chop")
        {
            string[] inputTokens = input
                .Split(new string[] { " -> " },
                       StringSplitOptions
                       .RemoveEmptyEntries);

            string type = inputTokens[0];
            int height = int.Parse(inputTokens[1]);

            data.Add(new KeyValuePair<string, int>(type, height));

            input = Console.ReadLine();
        }

        string neededType = Console.ReadLine();
        int minHeight = int.Parse(Console.ReadLine());

        double pricePerMeter = Math
            .Round(data.Average(kvp => kvp.Value), 2);

        double usedLogsPrice = data
               .Where(x => x.Key == neededType && x.Value >= minHeight)
               .Sum(x => x.Value);

        double unusedLogsPrice = data
            .Where(x => x.Key != neededType || x.Value < minHeight)
            .Sum(x => x.Value);

        usedLogsPrice *= pricePerMeter;
        unusedLogsPrice *= (pricePerMeter * 0.25);

        usedLogsPrice = Math.Round(usedLogsPrice, 2);
        unusedLogsPrice = Math.Round(unusedLogsPrice, 2);
        double totalPrice = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

        Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
        Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
        Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
        Console.WriteLine($"CottageScraper subtotal: ${totalPrice:F2}");
    }
}

