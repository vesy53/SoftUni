namespace p04._01.TravelMap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TravelMap
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split(" > ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string country = tokens[0];
                string townName = tokens[1];
                int travelCost = int.Parse(tokens[2]);

                if (!data.ContainsKey(country))
                {
                    data.Add(country, new Dictionary<string, int>());
                }

                if (!data[country].ContainsKey(townName))
                {
                    data[country].Add(townName, int.MaxValue);
                }

                if (data[country][townName] > travelCost)
                {
                    data[country][townName] = travelCost;
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderBy(d => d.Key))
            {
                string country = itemData.Key;
                Dictionary<string, int> townArgs = itemData.Value;

                Console.Write($"{country} -> ");

                foreach (var townArg in townArgs
                    .OrderBy(t => t.Value))
                {
                    string townName = townArg.Key;
                    int travelCost = townArg.Value;

                    Console.Write($"{townName} -> {travelCost} ");
                }

                Console.WriteLine();
            }
        }
    }
}
