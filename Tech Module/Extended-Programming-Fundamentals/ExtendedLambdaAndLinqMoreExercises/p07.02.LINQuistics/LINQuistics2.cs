﻿using System;
using System.Collections.Generic;
using System.Linq;

class LINQuistics2
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "exit")
        {
            string [] inputTokens = input
                .Split(new string[] { ".", "()" },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string collection = inputTokens[0];
            string[] methods = inputTokens
                .Skip(1)
                .ToArray();
            int number;

            if (methods.Length > 0)
            {
                foreach (var method in methods)
                {
                    if (!data.ContainsKey(collection))
                    {
                        data.Add(collection, new List<string>());
                    }

                    if (!data[collection].Contains(method))
                    {
                        data[collection].Add(method);
                    }
                }
            }
            else if (int.TryParse(collection, out number))
            {
                if (data.Count > 0)
                {
                    var collectionWithMostMethods = data
                    .OrderByDescending(collectionData => collectionData.Value.Count)
                    .First();

                    var methodsToPrint = collectionWithMostMethods.Value
                        .OrderBy(method => method.Length)
                        .Take(number);

                    PrintMethods(methodsToPrint);
                }
            }
            else if (data.ContainsKey(collection))
            {
                var methodsToPrint = data[collection]
                    .OrderByDescending(method => method.Length)
                    .ThenByDescending(method => method.Distinct().Count());

                PrintMethods(methodsToPrint);
            }

            input = Console.ReadLine();
        }

        string[] commandTokens = Console.ReadLine()
            .Split();

        string methodToCheck = commandTokens[0];
        string selection = commandTokens[1];

        var collectionsToPrint = data
               .Where(d => d.Value.Contains(methodToCheck))
               .OrderByDescending(d => d.Value.Count)
               .ThenByDescending(d => d.Value.OrderBy(m => m.Length).First().Length);

        foreach (var collectionData in collectionsToPrint)
        {
            string collection = collectionData.Key;
            List<string> methods = collectionData.Value;

            var orderedMethods = methods
                .OrderByDescending(m => m.Length);

            Console.WriteLine(collection);

            if (selection == "all")
            {
                PrintMethods(orderedMethods);
            }
        }
    }

    static void PrintMethods(IEnumerable<string> methods)
    {
        foreach (var method in methods)
        {
            Console.WriteLine($"* {method}");
        }
    }
}

