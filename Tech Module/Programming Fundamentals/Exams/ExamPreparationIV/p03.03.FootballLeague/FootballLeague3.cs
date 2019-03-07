namespace p03._03.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FootballLeague3
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, List<long>>();

            string key = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "final")
            {
                string[] tokens = command
                    .Split(' ');
                string teamA = tokens[0];
                int startIndex = teamA.IndexOf(key);
                int endIndex = teamA.LastIndexOf(key);
                string homeTeam = teamA
                    .Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] homeTeamArray = homeTeam.ToUpper().ToCharArray();
                Array.Reverse(homeTeamArray);
                homeTeam = new string(homeTeamArray);

                string teamB = tokens[1];
                startIndex = teamB.IndexOf(key);
                endIndex = teamB.LastIndexOf(key);
                string awayTeam = teamB
                    .Substring(startIndex + key.Length, endIndex - startIndex - key.Length);
                char[] awayTeamArray = awayTeam.ToUpper().ToCharArray();
                Array.Reverse(awayTeamArray);
                awayTeam = new string(awayTeamArray);

                long[] goals = tokens[2]
                    .Split(':')
                    .Select(long.Parse)
                    .ToArray();
                long homeTeamGoals = goals[0];
                long awayTeamGoals = goals[1];

                long pointsForHomeTeam;
                long pointsForAwayTeam;

                if (homeTeamGoals > awayTeamGoals)
                {
                    pointsForHomeTeam = 3;
                    pointsForAwayTeam = 0;
                }
                else if (homeTeamGoals < awayTeamGoals)
                {
                    pointsForHomeTeam = 0;
                    pointsForAwayTeam = 3;
                }
                else
                {
                    pointsForHomeTeam = 1;
                    pointsForAwayTeam = 1;
                }

                if (teams.ContainsKey(homeTeam))
                {
                    teams[homeTeam][0] += pointsForHomeTeam;
                    teams[homeTeam][1] += homeTeamGoals;
                }
                else
                {
                    teams[homeTeam] = new List<long>();
                    teams[homeTeam].Add(pointsForHomeTeam);
                    teams[homeTeam].Add(homeTeamGoals);
                }

                if (teams.ContainsKey(awayTeam))
                {
                    teams[awayTeam][0] += pointsForAwayTeam;
                    teams[awayTeam][1] += awayTeamGoals;
                }
                else
                {
                    teams[awayTeam] = new List<long>();
                    teams[awayTeam].Add(pointsForAwayTeam);
                    teams[awayTeam].Add(awayTeamGoals);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            int count = 1;

            foreach (var pair in teams
                .OrderByDescending(x => x.Value[0])
                .ThenBy(t => t.Key))
            {
                string name = pair.Key;
                long points = pair.Value[0];

                Console.WriteLine($"{count}. {name} {points}");

                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var pair in teams
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key)
                .Take(3))
            {
                string name = pair.Key;
                long goals = pair.Value[1];

                Console.WriteLine($"- {name} -> {goals}");
            }
        }
    }
}
