using System;
using System.Collections.Generic;
using System.Linq;

class FlattenDictionary2
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, string>>();

        string input = Console.ReadLine();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split();

            string key = inputTokens[0];
            string innerKey = inputTokens[1];

            if (inputTokens[0] != "flatten")
            {
                string innerValue = inputTokens[2];

                if (!data.ContainsKey(key))
                {
                    data[key] = new Dictionary<string, string>();
                }

                data[key][innerKey] = innerValue;
            }
            else
            {
                data[innerKey] = data[innerKey]
                    .ToDictionary(x => x.Key + x.Value, x => "flattened");
            }

            input = Console.ReadLine();
        }

        Dictionary<string, Dictionary<string, string>> result = data
            .OrderByDescending(x => x.Key.Length)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in result)
        {
            string key = item.Key;
            Dictionary<string, string> values = item
                .Value
                .Where(x => x.Value != "flattened")
                .OrderBy(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> flattenedValues = item
                .Value
                .Where(x => x.Value == "flattened")
                .ToDictionary(x => x.Key, x => x.Value);

            int count = 1;

            Console.WriteLine($"{key}");

            foreach (var value in values)
            {
                string innerKey = value.Key;
                string innerValue = value.Value;

                Console.WriteLine(
                    $"{count}. {innerKey} - {innerValue}");

                count++;
            }

            foreach (var flattenedValue in flattenedValues)
            {
                string innerKey = flattenedValue.Key;
                string innerValue = flattenedValue.Value;

                Console.WriteLine(
                    $"{count}. {innerKey}");

                count++;
            }
        }
    }
}

