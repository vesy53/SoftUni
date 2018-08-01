using System;
using System.Collections.Generic;
using System.Linq;

class DragonArmy
{
    static void Main(string[] args)
    {
        var dragonsStats = new Dictionary<string, SortedDictionary<string, List<double>>>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] dragonsInformation = Console.ReadLine()
                .Split();

            string typeDragon = dragonsInformation[0];
            string nameDragon = dragonsInformation[1];
            string damageStr = dragonsInformation[2];
            string healthStr = dragonsInformation[3];
            string armorStr = dragonsInformation[4];          

            if (damageStr == "null")
            {
                damageStr = "45";
            }

            if (healthStr == "null")
            {
                healthStr = "250";
            }

            if (armorStr == "null")
            {
                armorStr = "10";
            }

            double damage = double.Parse(damageStr);
            double health = double.Parse(healthStr);
            double armor = double.Parse(armorStr);

            List<double> stats = new List<double>();
            stats.Add(damage);
            stats.Add(health);
            stats.Add(armor);

            if (!dragonsStats.ContainsKey(typeDragon))
            {
                dragonsStats.Add(typeDragon, new SortedDictionary<string, List<double>>());
            }

            if (!dragonsStats[typeDragon].ContainsKey(nameDragon))
            {
                dragonsStats[typeDragon].Add(nameDragon, new List<double>());
            }
            else
            {
                dragonsStats[typeDragon][nameDragon].Clear();
            }

            dragonsStats[typeDragon][nameDragon].AddRange(stats);
        }
       
        foreach (var item in dragonsStats)
        {
            string type = item.Key;
            SortedDictionary<string, List<double>> stats = item.Value;

            double averageDamage = stats.Select(x => x.Value[0]).Average();
            double averageHealths = stats.Select(x => x.Value[1]).Average();
            double averageArmor = stats.Select(x => x.Value[2]).Average();

            Console.WriteLine(
                $"{type}::({averageDamage:F2}/{averageHealths:F2}/{averageArmor:F2})");
           
            foreach (var itemStats in stats)
            {
                string name = itemStats.Key;
                List<double> stat = itemStats.Value;

                double damage = stat[0];
                double health = stat[1];
                double armor = stat[2];

                Console.WriteLine(
                    $"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
            }
        }
    }
}


    