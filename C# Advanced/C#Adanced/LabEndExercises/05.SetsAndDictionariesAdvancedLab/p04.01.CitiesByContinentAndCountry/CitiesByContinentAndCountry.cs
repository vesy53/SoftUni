namespace p04._01.CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;

    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, List<string>>>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!data.ContainsKey(continent))
                {
                    data.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent].Add(country, new List<string>());
                }

                data[continent][country].Add(city);
            }

            foreach (var itemData in data)
            {
                string continent = itemData.Key;
                Dictionary<string, List<string>> countriesArgs = itemData.Value;

                Console.WriteLine($"{continent}:");

                foreach (var countriesArg in countriesArgs)
                {
                    string country = countriesArg.Key;
                    List<string> cities = countriesArg.Value;

                    Console.WriteLine(
                        $"  {country} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
