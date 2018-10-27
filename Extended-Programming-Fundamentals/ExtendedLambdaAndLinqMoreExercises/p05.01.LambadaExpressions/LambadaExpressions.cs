using System;
using System.Collections.Generic;
using System.Linq;

class LambadaExpressions
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, string>>();

        string input = Console.ReadLine();

        while (input.Equals("lambada") == false)
        {
            string[] inputTokens = input
                .Split(new string[] { " => ", "." },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            if (inputTokens[0] == "dance")
            {
                data = data
                    .ToDictionary(x => x.Key, x => x.Value
                        .ToDictionary(y => y.Key,
                                      y => y.Key + "." + y.Value));//към с-стта добавяме "selectorObject" + "."
            }
            else
            {
                string key = inputTokens[0];
                string keyValues = inputTokens[1];
                string valueValues = inputTokens[2];

                if (!data.ContainsKey(key))
                {
                    data.Add(key, new Dictionary<string, string>());
                }
                //тази проверка не е необходима
                if (!data[key].ContainsKey(keyValues))
                {
                    data[key].Add(keyValues, string.Empty);
                }

                data[key][keyValues] = valueValues;
            }

            input = Console.ReadLine();
        }

        foreach (var item in data)
        {
            string key = item.Key;
            Dictionary<string, string> values = item.Value;

            Console.Write($"{key} => ");

            foreach (var valueData in values)
            {
                string selectorObject = valueData.Key;
                string property = valueData.Value;

                Console.WriteLine($"{selectorObject}.{property}");
            }
        }
    }
}

