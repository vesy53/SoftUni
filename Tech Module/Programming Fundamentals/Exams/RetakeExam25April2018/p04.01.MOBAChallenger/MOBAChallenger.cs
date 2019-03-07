namespace p04._01.MOBAChallenger
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class MOBAChallenger
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] tokens = input
                        .Split(" -> ");
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (!data.ContainsKey(player))
                    {
                        data.Add(player, new Dictionary<string, int>());
                    }

                    if (!data[player].ContainsKey(position))
                    {
                        data[player].Add(position, 0);
                    }

                    if (data[player][position] < skill)
                    {
                        data[player][position] = skill;
                    }
                }
                else if (input.Contains("vs"))
                {
                    string[] tokens = input
                        .Split(" vs ");
                    string firstPlayer = tokens[0];
                    string secondPlayer = tokens[1];

                    if (data.ContainsKey(firstPlayer) && 
                        data.ContainsKey(secondPlayer))
                    {
                        string[] firstPlayerPositions = data[firstPlayer].Keys.ToArray();

                        foreach (var item in data[secondPlayer].Keys)
                        {
                            if (firstPlayerPositions.Contains(item))
                            {
                                int totalSkillsFP = data[firstPlayer].Values.Sum();
                                int totalSkillsSP = data[secondPlayer].Values.Sum();

                                if (totalSkillsFP > totalSkillsSP)
                                {
                                    data.Remove(secondPlayer);
                                    break;
                                }
                                else if (totalSkillsFP < totalSkillsSP)
                                {
                                    data.Remove(firstPlayer);
                                    break;
                                }
                            }
                        }
                        
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key))
            {
                string player = itemData.Key;
                Dictionary<string, int> arguments = itemData.Value;
                int totalSkills = arguments.Values.Sum();

                Console.WriteLine($"{player}: {totalSkills} skill");

                foreach (var argument in arguments
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    string position = argument.Key;
                    int skill = argument.Value;

                    Console.WriteLine($"- {position} <::> {skill}");
                }
            }
        }
    }
}
