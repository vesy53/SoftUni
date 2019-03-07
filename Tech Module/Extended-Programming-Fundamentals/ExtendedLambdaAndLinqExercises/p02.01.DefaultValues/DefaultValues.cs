using System;
using System.Collections.Generic;
using System.Linq;

class DefaultValues
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, string>();

        string input = Console.ReadLine();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string key = inputTokens[0];
            string value = inputTokens[1];

            if (!data.ContainsKey(key))
            {
                data.Add(key, string.Empty);
            }

            data[key] = value;

            input = Console.ReadLine();
        }

        string defaultValue = Console.ReadLine();

        var resultNotNull = data
            .Where(x => x.Value != "null")
            .OrderByDescending(x => x.Value.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        var resultWithNull = data
            .Where(x => x.Value == "null")
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in resultNotNull)
        {
            string key = item.Key;
            string value = item.Value;

            Console.WriteLine($"{key} <-> {value}");
        }

        foreach (var item in resultWithNull)
        {
            string key = item.Key;
            string value = item.Value;

            Console.WriteLine($"{key} <-> {defaultValue}");
        }
    }
}

