namespace p04._02.Weather
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Weather2
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"(?<nameCity>[A-Z]{2})(?<temp>\d+\.\d+)(?<type>[A-Za-z]+)(?=\|)"
            );

            string input = Console.ReadLine();

            var data = new Dictionary<string, WeatherAverage>();

            while (input.Equals("end") == false)
            {
                MatchCollection matches = pattern.Matches(input);

                foreach (Match item in matches)
                {
                    string city = item.Groups["nameCity"].Value;
                    double temperature = double.Parse(item.Groups["temp"].Value);
                    string type = item.Groups["type"].Value;

                    WeatherAverage currentWeather = new WeatherAverage
                    (
                        temperature,
                        type
                    );

                    if (!data.ContainsKey(city))
                    {
                        data.Add(city, currentWeather);
                    }
                    else
                    {
                        data[city] = currentWeather;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderBy(x => x.Value.Temperature))
            {
                string city = itemData.Key;
                double temp = itemData.Value.Temperature;
                string type = itemData.Value.Type;

                Console.WriteLine($"{city} => {temp} => {type}");
            }
        }
    }

    class WeatherAverage
    {
        public double Temperature { get; set; }
        public string Type { get; set; }

        public WeatherAverage(
            double temperature, 
            string type)
        {
            this.Temperature = temperature;
            this.Type = type;
        }
    }
}
