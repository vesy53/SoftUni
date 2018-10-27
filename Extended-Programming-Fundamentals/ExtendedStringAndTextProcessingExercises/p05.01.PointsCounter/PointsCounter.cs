namespace p05._01.PointsCounter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class PointsCounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, int>>();

            while (input.Equals("Result") == false)
            {
                string[] inputTokens = input
                    .Split('|');

                string team = string.Empty;
                string player = string.Empty;

                for (int i = 0; i < inputTokens.Length - 1; i++)
                {
                    string result = string.Empty;

                    foreach (var word in inputTokens[i])
                    {
                        char currentWord = word;

                        if (char.IsLetter(currentWord))
                        {
                            result += currentWord;
                        }
                    }

                    for (int j = 1; j < result.Length; j++)
                    {
                        char currentRev = result[j];

                        if (char.IsUpper(currentRev))
                        {
                            team = result;
                            break;
                        }
                        else
                        {
                            player = result;
                            break;
                        }
                    }
                }

                int points = int.Parse(inputTokens[2]);

                if (!data.ContainsKey(team))
                {
                    data.Add(team, new Dictionary<string, int>());
                }

                if (!data[team].ContainsKey(player))
                {
                    data[team].Add(player, 0);
                }

                data[team][player] = points;

                input = Console.ReadLine();
            }

            foreach (var item in data
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
