using System;
using System.Collections.Generic;
using System.Linq;

class DefaultValues3
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
           .Where(x => !x.Value.Equals("null"))
           .OrderByDescending(x => x.Value.Length)
           .ToDictionary(x => x.Key, x => x.Value);

        var resultWithNull = data
            .Where(x => x.Value.Equals("null"))
            .ToDictionary(x => x.Key, x => defaultValue);

        var result = resultNotNull
            .Concat(resultWithNull)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in result)
        {
            string key = item.Key;
            string value = item.Value;

            Console.WriteLine($"{key} <-> {value}");
        }
    }
}

