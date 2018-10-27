namespace p04._01.PopulationAggregation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PopulationAggregation
    {
        static void Main(string[] args)
        {
            var dataCounts = new Dictionary<string, int>();
            var dataCities = new Dictionary<string, long>();

            string input = Console.ReadLine();

            while (input.Equals("stop") == false)
            {
                string[] tokens = input
                    .Split('\\');
                string firstTokens = tokens[0];
                string secondTokens = tokens[1];
                long population = long.Parse(tokens[2]);

                string newFirstTokens = TakeLetters(firstTokens);
                string newSecondTokens = TakeLetters(secondTokens);

                if (newFirstTokens[0] >= 65 && newFirstTokens[0] <= 90)
                {
                    string country = newFirstTokens;
                    string city = newSecondTokens;

                    CreateDictionaryCities(dataCities, city, population);
                    CreateDictionaryCounts(dataCounts, country);
                }
                else
                {
                    string city = newFirstTokens;
                    string country = newSecondTokens;

                    CreateDictionaryCities(dataCities, city, population);
                    CreateDictionaryCounts(dataCounts, country);
                }

                input = Console.ReadLine();
            }

            PrintDictionaryCounts(dataCounts);
            PrintDictionaryCities(dataCities);
        }

        static string TakeLetters(string inputTokens)
        {
            inputTokens = inputTokens.Replace("@", string.Empty);
            inputTokens = inputTokens.Replace("#", string.Empty);
            inputTokens = inputTokens.Replace("$", string.Empty);
            inputTokens = inputTokens.Replace("&", string.Empty);

            for (int i = 0; i <= 9; i++)
            {
                inputTokens = inputTokens.Replace(i.ToString(), string.Empty);
            }

            return inputTokens;
        }

        private static void PrintDictionaryCities(
            Dictionary<string, long> dataCities)
        {
            foreach (var itemData in dataCities
                .OrderByDescending(x => x.Value)
                .Take(3))
            {
                string city = itemData.Key;
                long population = itemData.Value;

                Console.WriteLine($"{city} -> {population}");
            }
        }

        static void PrintDictionaryCounts(Dictionary<string, int> dataCounts)
        {
            foreach (var data in dataCounts
                .OrderBy(x => x.Key))
            {
                string country = data.Key;
                int count = data.Value;

                Console.WriteLine($"{country} -> {count}");
            }
        }

        static void CreateDictionaryCounts(
            Dictionary<string, int> dataCounts,
            string country)
        {
            if (!dataCounts.ContainsKey(country))
            {
                dataCounts.Add(country, 0);
            }

            dataCounts[country]++;
        }

        static void CreateDictionaryCities(
            Dictionary<string, long> dataCities, 
            string city, 
            long population)
        {
            if (!dataCities.ContainsKey(city))
            {
                dataCities.Add(city, 0);
            }

            dataCities[city] = population;
        }
    }
}
