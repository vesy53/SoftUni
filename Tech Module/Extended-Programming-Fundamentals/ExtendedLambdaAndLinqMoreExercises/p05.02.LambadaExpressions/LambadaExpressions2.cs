using System;
using System.Collections.Generic;
using System.Linq;

class LambadaExpressions2
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, string>();

        string input = Console.ReadLine();

        while (input != "lambada")
        {
            string[] inputTokens = input
                .Split(new string[] { " => " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            if (inputTokens[0] == "dance")
            {
                var result = data
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in result)
                {
                    string key = item.Key;
                    string[] value = item.Value.Split('.');

                    string selectorObject = value[0];
                    string modified = selectorObject + ".";

                    data[key] = modified + data[key];
                }
            }   
            else
            {
                string key = inputTokens[0];
                string value = inputTokens[1];

                if (!data.ContainsKey(key))
                {
                    data.Add(key, string.Empty);
                }

                data[key] = value;
            }

            input = Console.ReadLine();
        }

        foreach (var itemData in data)
        {
            string key = itemData.Key;
            string value = itemData.Value;

            Console.WriteLine($"{key} => {value}");
        }
    }
}

