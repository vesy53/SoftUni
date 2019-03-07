namespace p03._01.FootballLeague
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class FootballLeague
    {
        static void Main(string[] args)
        {
            var dataPoints = new Dictionary<string, int>();
            var dataGoals = new Dictionary<string, int>();

            string key = Console.ReadLine();
            string input = Console.ReadLine();

            key = Regex.Escape(key);

            Regex patternCountry = new Regex
            (
                $@".*{key}(?<countryA>[A-Za-z]*){key}.*{key}(?<countryB>[A-Za-z]*){key}.* (?<goalA>\d+):(?<goalB>\d+)"
            );

            while (input.Equals("final") == false)
            {
                MatchCollection matchesCountries = patternCountry.Matches(input);

                foreach (Match matchCountry in matchesCountries)
                {
                    string countryA = matchCountry.Groups["countryA"].Value.ToUpper();
                    string countryB = matchCountry.Groups["countryB"].Value.ToUpper();
                    int goalsA = int.Parse(matchCountry.Groups["goalA"].Value);
                    int goalsB = int.Parse(matchCountry.Groups["goalB"].Value);

                    countryA = ReversedCountry(countryA);
                    countryB = ReversedCountry(countryB);

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
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int count = 1;

            foreach (var dataPoint in dataPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string country = dataPoint.Key;
                int points = dataPoint.Value;

                Console.WriteLine(
                    $"{count}. {country} {points}");

                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var dataGoal in dataGoals
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Take(3))
            {
                string country = dataGoal.Key;
                int goals = dataGoal.Value;

                Console.WriteLine($"- {country} -> {goals}");
            }
        }

        static string ReversedCountry(string country)
        {
            string reversedCountry = string.Empty;

            for (int i = country.Length - 1; i >= 0; i--)
            {
                reversedCountry += country[i];
            }

            return reversedCountry;
        }
    }
}
