namespace p03._02.FootballLeague
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class FootballLeague2
    {
        static void Main(string[] args)
        {
            var dataTeams = new Dictionary<string, Team>();

            string key = Console.ReadLine();

            string escapedKey = Regex.Escape(key);
            Regex pattern = new Regex
            (
               string.Format(
                   @"{0}(?<teamA>[a-zA-Z]*){0}.*{0}(?<teamB>[a-zA-Z]*){0}[^ ]* (?<goalsA>\d+):(?<goalsB>\d+)",
                   //@"{0}(?<teamA>[A-Za-z]*){0}(.*){0}(?<teamB>[A-Za-z]*){0}(.*) (?<goalsA>\d+)\:(?<goalsB>\d+)",
                   escapedKey)
            );

            string input = Console.ReadLine();

            while (input.Equals("final") == false)
            {
                MatchCollection matchesTeam = pattern.Matches(input);

                foreach (Match matchTeam in matchesTeam)
                {
                    string teamA = matchTeam.Groups["teamA"].Value.ToUpper();
                    string teamB = matchTeam.Groups["teamB"].Value.ToUpper();
                    int goalsA = int.Parse(matchTeam.Groups["goalsA"].Value);
                    int goalsB = int.Parse(matchTeam.Groups["goalsB"].Value);

                    string reverseA = TakeReverseTeamName(teamA);
                    string reverseB = TakeReverseTeamName(teamB);

                    if (!dataTeams.ContainsKey(reverseA))
                    {
                        dataTeams.Add(reverseA, new Team(0, 0));
                    }

                    if (!dataTeams.ContainsKey(reverseB))
                    {
                        dataTeams.Add(reverseB, new Team(0, 0));
                    }

                    dataTeams[reverseA].Goals += goalsA;
                    dataTeams[reverseB].Goals += goalsB;

                    if (goalsA == goalsB)
                    {
                        dataTeams[reverseA].Points += 1;
                        dataTeams[reverseB].Points += 1;
                    }
                    else if (goalsA > goalsB)
                    {
                        dataTeams[reverseA].Points += 3;
                    }
                    else if (goalsA < goalsB)
                    {
                        dataTeams[reverseB].Points += 3;
                    }
                }

                input = Console.ReadLine();
            }

            var orderByPoints = dataTeams
                .OrderByDescending(x => x.Value.Points)
                .ThenBy(x => x.Key);

            var topThreeByGoals = dataTeams
                .OrderByDescending(x => x.Value.Goals)
                .ThenBy(x => x.Key)
                .Take(3);

            int count = 1;

            Console.WriteLine("League standings:");

            foreach (var order in orderByPoints)
            {
                string teamName = order.Key;
                int points = order.Value.Points;

                Console.WriteLine($"{count}. {teamName} {points}");

                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var topThree in topThreeByGoals)
            {
                string teamName = topThree.Key;
                int goals = topThree.Value.Goals;

                Console.WriteLine($"- {teamName} -> {goals}");
            }
        }

        static string TakeReverseTeamName(string team)
        {
            string reverse = string.Empty;

            for (int i = team.Length - 1; i >= 0; i--)
            {
                reverse += team[i];
            }

            return reverse;
        }
    }

    class Team
    {
        public int Goals { get; set; }
        public int Points { get; set; }

        public Team(int goals, int points)
        {
            this.Goals = goals;
            this.Points = points;
        }
    }
}
