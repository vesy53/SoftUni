using System;
using System.Collections.Generic;

class GroupContinentsCountriesAndCities
{
    static void Main(string[] args)
    {
        var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
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
                continentsData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
            }

            if (!continentsData[continent].ContainsKey(contry))
            {
                continentsData[continent].Add(contry, new SortedSet<string>());
            }

            continentsData[continent][contry].Add(city);
        }

        foreach (var item in continentsData)
        {
            string continent = item.Key;
            SortedDictionary<string, SortedSet<string>> countries = item.Value;

            Console.WriteLine($"{continent}:");

            foreach (var countryData in countries)
            {
                string country = countryData.Key;
                SortedSet<string> cities = countryData.Value;

                Console.WriteLine("  {0} -> {1}",
                    country,
                    string.Join(", ", cities));
            }
        }
    }
}

