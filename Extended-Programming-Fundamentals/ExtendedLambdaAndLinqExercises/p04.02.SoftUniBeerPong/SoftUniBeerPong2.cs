using System;
using System.Linq;
using System.Collections.Generic;

class SoftUniBeerPong2
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();

        while (input != "stop the game")
        {
            string[] inputTokens = input
                .Split('|');

            string playersName = inputTokens[0];
            string teamName = inputTokens[1];
            int points = int.Parse(inputTokens[2]);

            if (!data.ContainsKey(teamName))
            {
                data.Add(teamName, new Dictionary<string, int>());
            }

            if (data[teamName].Count < 3)
            {
                data[teamName].Add(playersName, points);
            }

            input = Console.ReadLine();
        }

        int count = 1;

        foreach (var itemData in data
            .Where(x => x.Value.Count == 3)
            .OrderByDescending(x => x.Value.Values.Sum()))
        {
            string teamName = itemData.Key;
            Dictionary<string, int> playersData = itemData.Value;

            Console.WriteLine($"{count}. {teamName}; Players:");

            foreach (var playerData in playersData
                .OrderByDescending(x => x.Value))
            {
                string playerName = playerData.Key;
                int points = playerData.Value;

                Console.WriteLine($"###{playerName}: {points}");
            }

            count++;
        }
    }
}

