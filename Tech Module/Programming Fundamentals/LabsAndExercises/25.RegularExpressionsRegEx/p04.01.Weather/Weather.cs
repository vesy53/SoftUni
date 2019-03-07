namespace p04._01.Weather
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Weather
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"(?<nameCity>[A-Z]{2})(?<temp>\d+\.\d+)(?<type>[A-Za-z]+)(?=\|)"
            );

            string input = Console.ReadLine();

            var data = new Dictionary<string, KeyValuePair<double, string>>();

            while (input.Equals("end") == false)
            {
                Match match = pattern.Match(input);

                if (match.Success == false)
                {
                    input = Console.ReadLine();

                    continue;
                }

                string city = match.Groups["nameCity"].Value;
                double temperature = double.Parse(match.Groups["temp"].Value);
                string weather = match.Groups["type"].Value;

                if (!data.ContainsKey(city))
                {
                    data.Add(city, new KeyValuePair<double, string>(temperature, weather));
                }
                else
                {
                    data[city] = new KeyValuePair<double, string>(temperature, weather);
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderBy(x => x.Value.Key))
            {
                string city = itemData.Key;
                double temperature = itemData.Value.Key;
                string type = itemData.Value.Value;

                Console.WriteLine($"{city} => {temperature:F2} => {type}");
            }
        }
    }
}
