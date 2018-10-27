using System;
using System.Collections.Generic;
using System.Linq;

class CottageScraper3
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, List<int>>();

        string input = Console.ReadLine();

        int count = 0;
        double total = 0.0;

        while (input.Equals("chop chop") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string treesType = inputTokens[0];
            int length = int.Parse(inputTokens[1]);

            if (!data.ContainsKey(treesType))
            {
                data.Add(treesType, new List<int>());
            }

            data[treesType].Add(length);

            total += length;
            count++;

            input = Console.ReadLine();
        }

        string neededType = Console.ReadLine();
        int minLength = int.Parse(Console.ReadLine());

        double pricePerMeter = Math.Round(total / count, 2);

        double usedLogs = data  //or data[neededType]
            .Where(x => x.Key == neededType)
            .SelectMany(x => x.Value)
            .Where(x => x >= minLength)
            .Sum();

        double unneded = data
            .Where(x => x.Key == neededType)
            .SelectMany(x => x.Value)
            .Where(x => x < minLength)
            .Sum();

        double unusedLogs = data
            .Where(x => x.Key != neededType)
            .SelectMany(x => x.Value)
            .Sum();

        usedLogs = Math.Round(usedLogs * pricePerMeter, 2);
        unusedLogs += unneded;
        unusedLogs = Math.Round(unusedLogs * pricePerMeter * 0.25, 2);
        double subTotal = usedLogs + unusedLogs;

        Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
        Console.WriteLine($"Used logs price: ${usedLogs:F2}");
        Console.WriteLine($"Unused logs price: ${unusedLogs:F2}");
        Console.WriteLine($"CottageScraper subtotal: ${subTotal:F2}");
    }
}

