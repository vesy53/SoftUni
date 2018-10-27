using System;
using System.Linq;
using System.Collections.Generic;

class PopulationCounter
{
    static void Main(string[] args)
    {
        var countryPopulation = new Dictionary<string, long>();
        var data = new Dictionary<string, Dictionary<string, long>>();
        string input = Console.ReadLine();

        while (input.Equals("report") == false)
        {
            string[] inputTokens = input
                .Split('|');

            string city = inputTokens[0];
            string country = inputTokens[1];
            int population = int.Parse(inputTokens[2]);

            if (!data.ContainsKey(country))
            {
                data.Add(country, new Dictionary<string, long>());
                countryPopulation.Add(country, 0);
            }

            if (!data[country].ContainsKey(city))
            {
                data[country].Add(city, 0);
            }

            data[country][city] += population;
            countryPopulation[country] += population;
            
            input = Console.ReadLine();
        }

        foreach (var itemData in countryPopulation
            .OrderByDescending(x => x.Value))
        {
            string country = itemData.Key;
            long population = itemData.Value;

            Console.WriteLine(
                $"{country} (total population: {population})");

            Dictionary<string, long> cities = data[country];

            foreach (var item in cities
                .OrderByDescending(x => x.Value))
            {
                string city = item.Key;
                long populationCity = item.Value;

                Console.WriteLine($"=>{city}: {populationCity}");
            }
        }    
    }
}

