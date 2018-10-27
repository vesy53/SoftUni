using System;
using System.Collections.Generic;
using System.Linq;

class DefaultValues2
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, string>();

        string[] input = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries);

        while (input[0].Equals("end") == false)
        {
            string key = input[0];
            string value = input[1];

            if (!data.ContainsKey(key))
            {
                data.Add(key, string.Empty);
            }

            data[key] = value;

            input = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries);
        }

        string defaultValue = Console.ReadLine();

        var resultNotNull = data
            .Where(x => !x.Value.Equals("null"))
            .OrderByDescending(x => x.Value.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        var resultWithNull = data
            .Where(x => x.Value.Equals("null"))
            .ToDictionary(x => x.Key, x => defaultValue);

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

            Console.WriteLine($"{key} <-> {value}");
        }
    }
}

