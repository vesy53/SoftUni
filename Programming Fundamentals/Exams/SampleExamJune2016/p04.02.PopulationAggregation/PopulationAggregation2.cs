namespace p04._02.PopulationAggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PopulationAggregation2
    {
        static void Main(string[] args)
        {
            var countryCount = new SortedDictionary<string, int>();
            var townPopulation = new Dictionary<string, long>();

            string input = Console.ReadLine();

            while (input.Equals("stop") == false)
            {
                string[] populationArgs = input
                    .Split('\\')
                    .ToArray();
                long populationsCount = long.Parse(populationArgs[2]);
                populationArgs[0] = RemoveProhibitedSymbols(populationArgs[0]);
                populationArgs[1] = RemoveProhibitedSymbols(populationArgs[1]);
                string countryName = string.Empty;
                string townName = string.Empty;

                if (char.IsUpper(populationArgs[0], 0))
                {
                    countryName = populationArgs[0];
                    townName = populationArgs[1];
                }
                else
                {
                    townName = populationArgs[0];
                    countryName = populationArgs[1];
                }

                if (!countryCount.ContainsKey(countryName))
                {
                    countryCount.Add(countryName, 0);
                }

                countryCount[countryName]++;

                if (!townPopulation.ContainsKey(townName))
                {
                    townPopulation.Add(townName, 0);
                }

                townPopulation[townName] = populationsCount;

                input = Console.ReadLine();
            }

            PrintCountry(countryCount);

            var topTowns = townPopulation
                .OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);

            PrintTopTowns(topTowns);
        }

        static void PrintTopTowns(Dictionary<string, long> topTowns)
        {
            foreach (var town in topTowns)
            {
                string city = town.Key;
                long population = town.Value;

                Console.WriteLine($"{city} -> {population}");
            }
        }

        static void PrintCountry(SortedDictionary<string, int> countryCount)
        {
            foreach (var countryData in countryCount)
            {
                string country = countryData.Key;
                int count = countryData.Value;

                Console.WriteLine($"{country} -> {count}");
            }
        }

        static string RemoveProhibitedSymbols(string populationArgs)
        {
            char[] symbols = "@#$&0123456789".ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                if (populationArgs.Contains(symbols[i]))
                {
                    populationArgs = populationArgs
                        .Replace(symbols[i].ToString(), string.Empty);
                }
            }

            return populationArgs;
        }
    }
}
