using System;
using System.Collections.Generic;

class CitiesByContinentAndCountry
{
    static void Main(string[] args)
    {
        var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] inputTokens = Console.ReadLine()
                .Split();
            string continent = inputTokens[0];
            string contry = inputTokens[1];
            string city = inputTokens[2];

            if (!continentsData.ContainsKey(continent))
            {
                continentsData.Add(continent, new Dictionary<string, List<string>>());
            }

            if (!continentsData[continent].ContainsKey(contry))
            {
                continentsData[continent].Add(contry, new List<string>());
            }

            continentsData[continent][contry].Add(city);
        }

        foreach (var item in continentsData)
        {
            string continent = item.Key;
            Dictionary<string, List<string>> contries = item.Value;

            Console.WriteLine($"{continent}:");

            foreach (var countryData in contries)
            {
                string country = countryData.Key;
                List<string> city = countryData.Value;

                Console.WriteLine("  {0} -> {1}",
                    country,
                    string.Join(", ", city));
            }
        }
    }
}

