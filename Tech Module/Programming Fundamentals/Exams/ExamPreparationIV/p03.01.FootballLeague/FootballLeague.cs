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
            var teamsPoints = new Dictionary<string, int>();
            var teamsGoals = new Dictionary<string, int>();

            string key = Console.ReadLine();

            string escapedKey = Regex.Escape(key);
            Regex pattern = new Regex
            (
               string.Format
               (@"({0})(?<teamA>[A-Za-z]*)({0})(.*)({0})(?<teamB>[A-Za-z]*)({0})(.*) (?<goalsA>[0-9]+)\:(?<goalsB>[0-9]+)",
                    escapedKey)
            );

            string input = Console.ReadLine();

            while (input.Equals("final") == false)
            { 
                MatchCollection matchesTeams = pattern.Matches(input);

                foreach (Match matchesTeam in matchesTeams)
                {
                    string teamA = matchesTeam.Groups["teamA"].Value.ToUpper();
                    string teamB = matchesTeam.Groups["teamB"].Value.ToUpper();
                    int goalsA = int.Parse(matchesTeam.Groups["goalsA"].Value);
                    int goalsB = int.Parse(matchesTeam.Groups["goalsB"].Value);

                    string reverseTeamA = TakeReverseString(teamA);
                    string reverseTeamB = TakeReverseString(teamB);

                    if (!teamsGoals.ContainsKey(reverseTeamA))
                    {
                        teamsGoals.Add(reverseTeamA, 0);
                    }

                    if (!teamsGoals.ContainsKey(reverseTeamB))
                    {
                        teamsGoals.Add(reverseTeamB, 0);
                    }

                    teamsGoals[reverseTeamA] += goalsA;
                    teamsGoals[reverseTeamB] += goalsB;

                    if (!teamsPoints.ContainsKey(reverseTeamA))
                    {
                        teamsPoints.Add(reverseTeamA, 0);
                    }

                    if (!teamsPoints.ContainsKey(reverseTeamB))
                    {
                        teamsPoints.Add(reverseTeamB, 0);
                    }

                    if (goalsA == goalsB)
                    {
                        teamsPoints[reverseTeamA] += 1;
                        teamsPoints[reverseTeamB] += 1;
                    }
                    else if (goalsA > goalsB)
                    {
                        teamsPoints[reverseTeamA] += 3;
                    }
                    else if (goalsA < goalsB)
                    {
                        teamsPoints[reverseTeamB] += 3;
                    }
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int count = 0;

            foreach (var team in teamsPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string country = team.Key;
                long points = team.Value;
                count++;

                Console.WriteLine($"{count}. {country} {points}");
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var item in teamsGoals
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Take(3))
            {
                string team = item.Key;
                long goals = item.Value;

                Console.WriteLine($"- {team} -> {goals}");
            }
        }

        static string TakeReverseString(string team)
        {
            string reverse = string.Empty;

            for (int i = team.Length - 1; i >= 0; i--)
            {
                reverse += team[i];
            }

            return reverse;
        }
    }
}
