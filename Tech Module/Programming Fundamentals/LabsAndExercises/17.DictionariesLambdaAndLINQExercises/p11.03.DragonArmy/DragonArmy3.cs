using System;
using System.Collections.Generic;
using System.Linq;

class DragonArmy3
{
    static void Main(string[] args)
    {
        var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine()
                .Split();

            string dragonType = input[0];
            string dragonName = input[1];

            int damage = int.TryParse(input[2], out damage) ? damage : 45;
            int health = int.TryParse(input[3], out health) ? health : 250;
            int armor = int.TryParse(input[4], out armor) ? armor : 10;

            if (!dragons.ContainsKey(dragonType))
            {
                dragons.Add(dragonType, new SortedDictionary<string, int[]>());
            }

            if (!dragons[dragonType].ContainsKey(dragonName))
            {
                dragons[dragonType].Add(dragonName, new int[3]);
            }

            dragons[dragonType][dragonName][0] = damage;
            dragons[dragonType][dragonName][1] = health;
            dragons[dragonType][dragonName][2] = armor;
        }

        foreach (var dragon in dragons)
        {
            string type = dragon.Key;
            SortedDictionary<string, int[]> dragonsStats = dragon.Value;

            var damageAverage = dragon.Value.Select(x => x.Value[0]).ToArray().Average();
            var healthAverage = dragon.Value.Select(x => x.Value[1]).ToArray().Average();
            var armorAverage = dragon.Value.Select(x => x.Value[2]).ToArray().Average();

            Console.WriteLine(
                $"{type}::({damageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");

            foreach (var dragonStat in dragonsStats)
            {
                string name = dragonStat.Key;
                int[] stat = dragonStat.Value;

                int damage = stat[0];
                int health = stat[1];
                int armor = stat[2];

                Console.WriteLine(
                    $"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
            }
        }
    }
}

