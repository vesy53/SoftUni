namespace p04._03.Weather
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"(?<nameCity>[A-Z]{2})(?<temp>\d+\.\d+)(?<type>[A-Za-z]+)(?=\|)"
            );

            string input = Console.ReadLine();

            List<Weather> weather = new List<Weather>();

            while (input.Equals("end") == false)
            {
                MatchCollection matches = pattern.Matches(input);

                foreach (Match item in matches)
                {
                    string city = item.Groups["nameCity"].Value;
                    double temperature = double.Parse(item.Groups["temp"].Value);
                    string type = item.Groups["type"].Value;

                    Weather currentWeather = new Weather
                    (
                        city,
                        temperature,
                        type
                    );

                    weather.Add(currentWeather);
                }

                input = Console.ReadLine();
            }

            foreach (var item in weather)
            {
                string city = item.City;
                double temperature = item.Temperature;
                string type = item.Type;

                Console.WriteLine(
                    $"{city} => {temperature} => {type}");
            }
        }
    }

    class Weather
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public string Type { get; set; }

        public Weather(
            string city,
            double temperature,
            string type)
        {
            this.City = city;
            this.Temperature = temperature;
            this.Type = type;
        }
    }
}
