using System;
using System.Collections.Generic;
using System.Linq;

class SoftUniBeerPong
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, long>>();

        string input = Console.ReadLine();

        while (input.Equals("stop the game") == false)
        {
            string[] inputTokens = input
                .Split('|');

            string playerName = inputTokens[0];
            string teamName = inputTokens[1];
            int points = int.Parse(inputTokens[2]);

            if (!data.ContainsKey(teamName))
            {
                data.Add(teamName, new Dictionary<string, long>());
            }

            if (data[teamName].Count < 3)
            {
                data[teamName].Add(playerName, points);                                          
            }

            input = Console.ReadLine();
        }

        var orderedData = data
            .Where(x => x.Value.Count == 3)
            .OrderByDescending(x => x.Value.Sum(playerRecord => playerRecord.Value));

        int counter = 1;

        foreach (var itemData in orderedData)
        {
            string teamName = itemData.Key;
            Dictionary<string, long> playersData = itemData.Value;

            Console.WriteLine(
                $"{counter}. {teamName}; Players:");

            foreach (var playerData in playersData
                .OrderByDescending(x => x.Value))
            {
                string name = playerData.Key;
                long points = playerData.Value;

                Console.WriteLine($"###{name}: {points}");
            }

            counter++;
        }
    }
}

