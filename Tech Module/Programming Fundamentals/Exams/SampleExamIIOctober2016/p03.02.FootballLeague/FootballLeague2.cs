namespace p03._02.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class FootballLeague2
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
                        Team currTeam = new Team
                        {
                            Country = countryA,
                            Points = pointsA,
                            Goals = goalsA
                        };

                        teams.Add(currTeam);
                    }
                    else
                    {
                        teams.First(t => t.Country == countryA).Points += pointsA;
                        teams.First(t => t.Country == countryA).Goals += goalsA;
                    }

                    if (!teams.Any(x => x.Country == countryB))
                    {
                        Team currTeam = new Team
                        {
                            Country = countryB,
                            Points = pointsB,
                            Goals = goalsB
                        };

                        teams.Add(currTeam);
                    }
                    else
                    {
                        teams.First(t => t.Country == countryB).Points += pointsB;
                        teams.First(t => t.Country == countryB).Goals += goalsB;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

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

            Console.WriteLine("Top 3 scored goals:");

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
    }

    class Team
    {
        public string Country { get; set; }
        public int Points { get; set; }
        public int Goals { get; set; }
    }
}
