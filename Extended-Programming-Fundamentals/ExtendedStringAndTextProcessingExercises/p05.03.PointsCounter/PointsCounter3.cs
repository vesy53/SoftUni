namespace p05._03.PointsCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PointsCounter3
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<Player>>();

            string input = Console.ReadLine();

            while (input.Equals("Result") == false)
            {
                string[] tokens = input
                    .Split('|');

                string teamName;
                string playerName;
                int pointsMade = int.Parse(tokens[2]);

                if (IsTeamName(tokens[0]))
                {
                    teamName = tokens[0];
                    playerName = tokens[1];
                }
                else
                {
                    teamName = tokens[1];
                    playerName = tokens[0];
                }

                teamName = Unpollute(teamName);
                playerName = Unpollute(playerName);

                if (!data.ContainsKey(teamName))
                {
                    data.Add(teamName, new List<Player>());
                }

                Player currentPlayer = new Player
                (
                    playerName,
                    pointsMade
                );

                if (!data[teamName].Contains(currentPlayer))
                {
                    data[teamName].Add(currentPlayer);
                }
                else
                {
                    int index = data[teamName].IndexOf(currentPlayer);
                    data[teamName][index] = currentPlayer;
                }

                input = Console.ReadLine();
            }

            var orderedData = data
                .OrderByDescending(t => t.Value.Sum(p => p.Points));

            foreach (var teamData in orderedData)
            {
                string teamName = teamData.Key;
                List<Player> players = teamData.Value;

                int totalPoints = players.Sum(p => p.Points);
                Player bestPlayer = players
                    .OrderByDescending(p => p.Points)
                    .First();

                Console.WriteLine($"{teamName} => {totalPoints}");
                Console.WriteLine(
                    $"Most points scored by {bestPlayer.Name}");
            }
        }

        static string Unpollute(string input)
        {
            input = input.Replace("@", "");
            input = input.Replace("%", "");
            input = input.Replace("$", "");
            input = input.Replace("*", "");

            return input;
        }

        private static bool IsTeamName(string input)
        {
            foreach (char symbol in input)
            {
                if (char.IsLower(symbol))
                {
                    return false;
                }
            }

            return true;
        }
    }

    class Player
    {
        public string Name { get; set; }

        public int Points { get; set; }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player other = (Player)obj;

                return this.Name == other.Name;
            }

            return false;
        }
    }
}
