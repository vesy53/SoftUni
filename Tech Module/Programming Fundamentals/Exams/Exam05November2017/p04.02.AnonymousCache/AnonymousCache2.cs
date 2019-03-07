namespace p04._02.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AnonymousCache2
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input.Equals("thetinggoesskrra") == false)
            {
                string[] inputSplit = input
                    .Split(" ->|".ToCharArray(),
                        StringSplitOptions
                        .RemoveEmptyEntries);

                if (inputSplit.Length > 1)
                {
                    string dataKey = inputSplit[0];
                    long dataSize = long.Parse(inputSplit[1]);
                    string dataSet = inputSplit[2];

                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<string, long>());
                    }

                    data[dataSet][dataKey] = dataSize;
                }

                input = Console.ReadLine();
            }

            if (data.Count > 1)
            {
                var dataSetWithMaxSize = data
                    .OrderByDescending(x => x.Value.Sum(a => a.Value))
                    .First();

                Console.WriteLine($"Data Set: {dataSetWithMaxSize.Key}," +
                    $" Total Size: {dataSetWithMaxSize.Value.Sum(a => a.Value)}");

                foreach (var inner in dataSetWithMaxSize.Value)
                {
                    string dataSet = inner.Key;

                    Console.WriteLine($"$.{dataSet}");
                }
            }
        }
    }
}
