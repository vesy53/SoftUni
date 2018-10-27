using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter2
{
    static void Main(string[] args)
    {
        var countriesData = new Dictionary<string, Dictionary<string, long>>();
        string input = Console.ReadLine();

        while (input.Equals("report") == false)
        {
            string[] inputTokens = input
                .Split('|');

            string city = inputTokens[0];
            string country = inputTokens[1];
            int population = int.Parse(inputTokens[2]);

            if (!countriesData.ContainsKey(country))
            {
                countriesData.Add(country, new Dictionary<string, long>());
            }

            if (!countriesData[country].ContainsKey(city))
            {
                countriesData[country].Add(city, 0);
            }

            countriesData[country][city] += population;

            input = Console.ReadLine();
        }

        countriesData = countriesData
            .OrderByDescending(x => x.Value.Values.Sum())
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var itemData in countriesData)
        {
            string country = itemData.Key;
            Dictionary<string, long> citiesData = itemData.Value;

            Console.WriteLine(
                $"{country} (total population: {citiesData.Values.Sum()})");

            foreach (var cityData in citiesData
                .OrderByDescending(x => x.Value))
            {
                string city = cityData.Key;
                long population = cityData.Value;

                Console.WriteLine(
                    $"=>{city}: {population}");
            }
        }
    }
}

