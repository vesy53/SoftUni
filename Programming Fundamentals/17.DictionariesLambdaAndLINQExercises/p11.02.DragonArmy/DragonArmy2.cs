using System;
using System.Collections.Generic;
using System.Linq;

class DragonArmy2
{
    static void Main(string[] args)
    {
        var dragons = new Dictionary<string, SortedDictionary<string, List<int>>>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] input = Console.ReadLine()
                .Split();

            string typeDragon = input[0];
            string nameDragon = input[1];
            int damage = int.TryParse(input[2], out damage) ? damage : 45;
            int health = int.TryParse(input[3], out health) ? health : 250;
            int armor = int.TryParse(input[4], out armor) ? armor : 10;

            if (!dragons.ContainsKey(typeDragon))
            {
                dragons.Add(typeDragon, new SortedDictionary<string, List<int>>());
            }

            if (!dragons[typeDragon].ContainsKey(nameDragon))
            {
                dragons[typeDragon].Add(nameDragon, new List<int>());
            }
            else
            {
                dragons[typeDragon][nameDragon].Clear();
            }

            dragons[typeDragon][nameDragon].Add(damage);
            dragons[typeDragon][nameDragon].Add(health);
            dragons[typeDragon][nameDragon].Add(armor);
        }

        foreach (var dragon in dragons)
        {
            string type = dragon.Key;
            SortedDictionary<string, List<int>> dragonsData = dragon.Value;

            double averageDamage = dragonsData.Values.Average(x => x[0]);
            double averageHealth = dragonsData.Values.Average(x => x[1]);
            double averageArmor = dragonsData.Values.Average(x => x[2]);
           
            Console.WriteLine(
                $"{type}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

            foreach (var itemData in dragonsData)
            {
                string name = itemData.Key;
                List<int> stat = itemData.Value;

                double damage = stat[0];
                double health = stat[1];
                double armor = stat[2];

                Console.WriteLine(
                    $"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
            }
        }
    }
}

