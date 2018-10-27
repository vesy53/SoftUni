using System;
using System.Collections.Generic;
using System.Linq;

class CottageScraper 
{
    static void Main(string[] args)
    {
        var data = new List<KeyValuePair<string, double>>();

        string input = Console.ReadLine();

        while (input.Equals("chop chop") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string woodsType = inputTokens[0];
            int woodsHeight = int.Parse(inputTokens[1]);

            data.Add(new KeyValuePair<string, double>(woodsType, woodsHeight));

            input = Console.ReadLine();
        }

        string needsTree = Console.ReadLine();
        int neededMinLength = int.Parse(Console.ReadLine());

        double pricePerMeter = Math.Round(data
            .Sum(x => x.Value) / data.Count, 2);

        double usedLogs = data
             .Where(x => x.Key == needsTree)
             .Where(x => x.Value >= neededMinLength)
             .Sum(x => x.Value);

        usedLogs = Math.Round(usedLogs * pricePerMeter, 2);

        double unneededsLogs = data
            .Where(x => x.Key == needsTree)
            .Where(x => x.Value < neededMinLength)
            .Sum(x => x.Value);

        double unusedLogs = data
            .Where(x => x.Key != needsTree)
            .Sum(x => x.Value);

        double result = unusedLogs + unneededsLogs;

        double total = Math
            .Round((result * pricePerMeter * 0.25), 2);

        double subTotal = Math.Round(usedLogs + total, 2);

        Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
        Console.WriteLine($"Used logs price: ${usedLogs:F2}");
        Console.WriteLine($"Unused logs price: ${total:F2}");
        Console.WriteLine($"CottageScraper subtotal: ${subTotal:F2}");
    }
}

