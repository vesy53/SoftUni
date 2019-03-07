using System;
using System.Collections.Generic;

class TravelCompany
{
    static void Main(string[] args)
    {
        var travelCompany = new Dictionary<string, Dictionary<string, int>>(); 
        string[] commands = Console.ReadLine()
            .Split(':');

        while (commands[0].Equals("ready") == false)
        {
            string city = commands[0];
            string[] vehicleTypesAndCapasity = commands[1].
                Split(new char[] { '-', ',' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            if (!travelCompany.ContainsKey(city))
            {
                travelCompany.Add(city, new Dictionary<string, int>());
            }

            for (int i = 0; i < vehicleTypesAndCapasity.Length - 1; i += 2)
            {
                string vechialeType = vehicleTypesAndCapasity[i];
                int capasity = int.Parse(vehicleTypesAndCapasity[i + 1]);

                if (!travelCompany[city].ContainsKey(vechialeType))
                {
                    travelCompany[city].Add(vechialeType, capasity);
                }

                travelCompany[city][vechialeType]= capasity;
            }

            commands = Console.ReadLine()
                .Split(':');
        }

        string[] groupSize = Console.ReadLine()
            .Split();

        while (groupSize[0] != "travel" && groupSize[1] != "time")
        {
            string groupCity = groupSize[0];
            int peopleCount = int.Parse(groupSize[1]);

            foreach (var item in travelCompany)
            {
                string city = item.Key;
                Dictionary<string, int> vehicleData = item.Value;
                int totalCount = 0;

                if (city == groupCity)
                {
                    Console.Write($"{city} -> ");

                    foreach (var itemData in vehicleData)
                    {
                        int peoplesNum = itemData.Value;

                        totalCount += peoplesNum;
                    }

                    if (peopleCount <= totalCount)
                    {
                        Console.WriteLine($"all {peopleCount} accommodated");
                    }
                    else if (peopleCount > totalCount)
                    {
                        peopleCount -= totalCount;

                        Console.WriteLine($"all except {peopleCount} accommodated");
                    }
                }

            }

            groupSize = Console.ReadLine()
                .Split();
        }
    }
}

