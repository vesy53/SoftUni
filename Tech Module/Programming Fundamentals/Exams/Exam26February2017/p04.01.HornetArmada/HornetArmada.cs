namespace p04._01.HornetArmada
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class HornetArmada
    {
        static void Main(string[] args)
        {
            var legionActivity = new Dictionary<string, int>();
            var soldiers = new Dictionary<string, Dictionary<string, long>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { " = ", " -> ", ":" },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                int activity = int.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                int soldierCount = int.Parse(input[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, activity);
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!soldiers[legionName].ContainsKey(soldierType))
                {
                    soldiers[legionName].Add(soldierType, 0);
                }

                soldiers[legionName][soldierType] += soldierCount;

                if (legionActivity[legionName] < activity)
                {
                    legionActivity[legionName] = activity;
                }
            }

            string[] tokens = Console.ReadLine()
                .Split('\\');

            if (tokens.Length == 2)
            {
                int currentActivity = int.Parse(tokens[0]);
                string currentSoldiersType = tokens[1];

                foreach (var soldier in soldiers
                    .Where(x => x.Value.ContainsKey(currentSoldiersType))
                    .OrderByDescending(x => x.Value[currentSoldiersType]))
                {
                    string legionName = soldier.Key;

                    if (currentActivity > legionActivity[legionName])
                    {
                        Console.WriteLine(
                            $"{legionName} -> {soldier.Value[currentSoldiersType]}");                                        
                    }
                }
            }
            else if(tokens.Length == 1)
            {
                string currentSoldierType = tokens[0];

                foreach (var legion in legionActivity
                    .OrderByDescending(x => x.Value))
                {
                    string legionName = legion.Key;
                    int activity = legion.Value;

                    if (soldiers[legionName].ContainsKey(currentSoldierType))
                    {
                        Console.WriteLine($"{activity} : {legionName}");
                    }
                }
            }
        }
    }
}
