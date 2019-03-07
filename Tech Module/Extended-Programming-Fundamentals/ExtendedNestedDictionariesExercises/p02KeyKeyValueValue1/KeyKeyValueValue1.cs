using System;
using System.Collections.Generic;

class KeyKeyValueValue1
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
        string searchKey = Console.ReadLine();
        string searchValue = Console.ReadLine();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split(new string[] { " => " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string key = inputTokens[0];
            string[] values = inputTokens[1]
                .Split(';');

            if (key.Contains(searchKey))
            {
                data.Add(key, new List<string>());

                foreach (var value in values)
                {
                    if (value.Contains(searchValue))
                    {
                        data[key].Add(value);
                    }
                }
            }
        }

        foreach (var itemData in data)
        {
            string key = itemData.Key;
            List<string> value = itemData.Value;

            Console.WriteLine($"{key}:");

            foreach (var itemValue in value)
            {
                Console.WriteLine($"-{itemValue}");
            }
        }
    }
}

