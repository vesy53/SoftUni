namespace p03._01.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class FootballLeague
    {
        static void Main(string[] args)
        {
            var dataPoints = new Dictionary<string, long>();
            var dataGoals = new Dictionary<string, long>();

            string key = Console.ReadLine();
            string input = Console.ReadLine();

            key = Regex.Escape(key);

            Regex pattern = new Regex
            (
                $@".*{key}(?<countryA>[A-Za-z]*){key}.*{key}(?<countryB>[A-Za-z]*){key}.* (?<goalsA>\d*):(?<goalsB>\d*)"
            );

            while (input.Equals("final") == false)
            {
                Match match = pattern.Match(input);

                if (match.Success)
                {
                    string countryA = match.Groups["countryA"].Value.ToUpper();
                    string countryB = match.Groups["countryB"].Value.ToUpper();
                    int goalsA = int.Parse(match.Groups["goalsA"].Value);
                    int goalsB = int.Parse(match.Groups["goalsB"].Value);

                    countryA = ReversedLettersCountry(countryA);
                    countryB = ReversedLettersCountry(countryB);

                    dataPoints = FillDataPoints(dataPoints, countryA, countryB, goalsA, goalsB);
                    dataGoals = FillDataGoals(dataGoals, countryA, countryB, goalsA, goalsB);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            PrintDataPoints(dataPoints);

            Console.WriteLine("Top 3 scored goals:");

            PrintDataGoals(dataGoals);
        }

        static void PrintDataGoals(Dictionary<string, long> dataGoals)
        {
            foreach (var item in dataGoals
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Take(3))
            {
                string country = item.Key;
                long goals = item.Value;

                Console.WriteLine($"- {country} -> {goals}");
            }
        }

        static void PrintDataPoints(Dictionary<string, long> dataPoints)
        {
            int count = 0;

            foreach (var itemData in dataPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string country = itemData.Key;
                long points = itemData.Value;
                count++;

                Console.WriteLine(
                    $"{count}. {country} {points}");
            }
        }

        static Dictionary<string, long> FillDataGoals(
            Dictionary<string, long> dataGoals, 
            string countryA, 
            string countryB, 
            int goalsA, 
            int goalsB)
        {

            if (!dataGoals.ContainsKey(countryA))
            {
                dataGoals.Add(countryA, 0);
            }

            if (!dataGoals.ContainsKey(countryB))
            {
                dataGoals.Add(countryB, 0);
            }

            dataGoals[countryA] += goalsA;
            dataGoals[countryB] += goalsB;

            return dataGoals;
        }

        static Dictionary<string, long> FillDataPoints(
            Dictionary<string, long> dataPoints, 
            string countryA, 
            string countryB, 
            int goalsA, 
            int goalsB)
        {
            if (!dataPoints.ContainsKey(countryA))
            {
                dataPoints.Add(countryA, 0);
            }

            if (!dataPoints.ContainsKey(countryB))
            {
                dataPoints.Add(countryB, 0);
            }

            if (goalsA > goalsB)
            {
                dataPoints[countryA] += 3;
            }
            else if (goalsA < goalsB)
            {
                dataPoints[countryB] += 3;
            }
            else if (goalsA == goalsB)
            {
                dataPoints[countryA] += 1;
                dataPoints[countryB] += 1;
            }

            return dataPoints;
        }

        static string ReversedLettersCountry(string country)
        {
            string reversed = string.Empty;

            for (int i = country.Length - 1; i >= 0; i--)
            {
                reversed += country[i];
            }

            return reversed;
        }
    }
}
