namespace p03._03.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class FootballLeague3
    {
        static void Main(string[] args)
        {
            string key = Regex.Escape(Console.ReadLine());
            string input = Console.ReadLine();

            Regex pattern = new Regex
            (
                $@".*{key}(?<countryA>[A-Za-z]*){key}.*{key}(?<countryB>[A-Za-z]*){key}.* (?<goalsA>\d+):(?<goalsB>\d+)"
            );

            List<Team> teams = new List<Team>();

            while (input.Equals("final") == false)
            {
                Match match = pattern.Match(input);

                if (match.Success)
                {
                    string countryA = new string(match.Groups["countryA"].Value.Reverse().ToArray()).ToUpper();
                    string countryB = new string(match.Groups["countryB"].Value.Reverse().ToArray()).ToUpper();
                    int goalsA = int.Parse(match.Groups["goalsA"].Value);
                    int goalsB = int.Parse(match.Groups["goalsB"].Value);
                    int pointsA = 0;
                    int pointsB = 0;

                    if (goalsA > goalsB)
                    {
                        pointsA = 3;
                    }
                    else if (goalsA < goalsB)
                    {
                        pointsB = 3;
                    }
                    else if (goalsA == goalsB)
                    {
                        pointsA = 1;
                        pointsB = 1;
                    }

                    if (!teams.Any(x => x.Country == countryA))
                    {
                        TeamEntry(teams, countryA, pointsA, goalsA);
                    }
                    else
                    {
                        AddPointsAndGoals(teams, countryA, pointsA, goalsA);
                    }

                    if (!teams.Any(x => x.Country == countryB))
                    {
                        TeamEntry(teams, countryB, pointsB, goalsB);
                    }
                    else
                    {
                        AddPointsAndGoals(teams, countryB, pointsB, goalsB);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            PrintPoints(teams);

            Console.WriteLine("Top 3 scored goals:");

            PrintGoals(teams);
        }

        static void PrintGoals(List<Team> teams)
        {
            foreach (Team team in teams
                .OrderByDescending(x => x.Goals)
                .ThenBy(x => x.Country)
                .Take(3))
            {
                string country = team.Country;
                long goals = team.Goals;

                Console.WriteLine($"- {country} -> {goals}");
            }
        }

        static void PrintPoints(List<Team> teams)
        {
            int count = 1;

            foreach (Team team in teams
                .OrderByDescending(x => x.Points)
                .ThenBy(x => x.Country))
            {
                string country = team.Country;
                long points = team.Points;

                Console.WriteLine(
                    $"{count}. {country} {points}");

                count++;
            }
        }

        static void AddPointsAndGoals(
            List<Team> teams, 
            string country, 
            int points, 
            int goals)
        {
            teams.First(t => t.Country == country).Points += points;
            teams.First(t => t.Country == country).Goals += goals;
        }

        static void TeamEntry
            (List<Team> teams, 
            string country, 
            int points, 
            int goals)
        {
            Team currTeam = new Team
            {
                Country = country,
                Points = points,
                Goals = goals
            };

            teams.Add(currTeam);
        }
    }

    class Team
    {
        public string Country { get; set; }

        public int Points { get; set; }

        public int Goals { get; set; }
    }
}
