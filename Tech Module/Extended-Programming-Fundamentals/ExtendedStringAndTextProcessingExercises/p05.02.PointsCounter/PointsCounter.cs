namespace p05._02.PointsCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PointsCounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dataTeams = new Dictionary<string, Dictionary<string, int>>();

            string teamName = string.Empty;
            string playerName = string.Empty;

            while (input.Equals("Result") == false)
            {
                input = input
                    .Replace("@", string.Empty)
                    .Replace("%", string.Empty)
                    .Replace("$", string.Empty)
                    .Replace("*", string.Empty);

                string[] inputTokens = input
                    .Split('|');

                if (inputTokens[0].Last() > 96)
                {
                    teamName = inputTokens[1];
                    playerName = inputTokens[0];
                }
                else
                {
                    teamName = inputTokens[0];
                    playerName = inputTokens[1];
                }

                int points = int.Parse(inputTokens[2]);

                if (!dataTeams.ContainsKey(teamName))
                {
                    dataTeams.Add(teamName, new Dictionary<string, int>());
                }

                dataTeams[teamName][playerName] = points;

                input = Console.ReadLine();
            }

            foreach (var item in dataTeams
                .OrderByDescending(x => x.Value.Values.Sum()))
            {
                string team = item.Key;
                Dictionary<string, int> playersPoint = item.Value;

                int totalSum = item.Value.Values.Sum();

                Console.WriteLine($"{team} => {totalSum}");

                foreach (var playerPoint in playersPoint
                    .OrderByDescending(x => x.Value)
                    .Take(1))
                {
                    string player = playerPoint.Key;
                    int point = playerPoint.Value;

                    Console.WriteLine(
                        $"Most points scored by {player}");
                }
            }
        }
    }
}
