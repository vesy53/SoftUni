namespace p04._01.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnonymousCache
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input.Equals("thetinggoesskrra") == false)
            {
                string[] tokens = input
                    .Split(new string[] { " -> ", " | " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    string dataSet = tokens[0];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }

                    if (cache.ContainsKey(dataSet))
                    {
                        data[dataSet] = cache[dataSet];
                    }
                }
                else if (tokens.Length == 3)
                {
                    string dataKey = tokens[0];
                    int dataSize = int.Parse(tokens[1]);
                    string dataSet = tokens[2];

                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, 0);
                        data[dataSet][dataKey] = dataSize;
                    }
                    else
                    {
                        if (!cache.ContainsKey(dataSet))
                        {
                            cache.Add(dataSet, new Dictionary<string, long>());
                        }

                        cache[dataSet].Add(dataKey, 0);
                        cache[dataSet][dataKey] = dataSize;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderByDescending(x => x.Value.Values.Sum())
                .Take(1))
            {
                string dataSet = itemData.Key;
                Dictionary<string, long> dataElements = itemData.Value;
                long sum = itemData.Value.Values.Sum();

                Console.WriteLine(
                    $"Data Set: {dataSet}, Total Size: {sum}");

                foreach (var item in dataElements)
                {
                    string dataKey = item.Key;

                    Console.WriteLine($"$.{dataKey}");
                }
            }
        }
    }
}
