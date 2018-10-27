using System;
using System.Collections.Generic;
using System.Linq;

class Camping
{
    static void Main(string[] args)
    {
        var campingsData = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();

        while (input.Equals("end") == false)
        {
            string[] inputTokens = input
                .Split();

            string personName = inputTokens[0];
            string camperModel = inputTokens[1];
            int timeToStay = int.Parse(inputTokens[2]);

            if (!campingsData.ContainsKey(personName))
            {
                campingsData.Add(personName, new Dictionary<string, int>());
            }

            if (!campingsData[personName].ContainsKey(camperModel))
            {
                campingsData[personName].Add(camperModel, 0);
            }

            campingsData[personName][camperModel] += timeToStay;

            input = Console.ReadLine();
        }       
        
        foreach (var campingData in campingsData
            .OrderByDescending(x => x.Value.Keys.Count)
            .ThenBy(x => x.Key.Length))
        {
            string personName = campingData.Key;
            Dictionary<string, int> modelAndTime = campingData.Value;

            int count = modelAndTime
                .Select(x => x.Key)
                .Count();

            int total = 0;

            Console.WriteLine($"{personName}: {count}");

            foreach (var item in modelAndTime)
            {
                string camperModel = item.Key;
                int timeToStay = item.Value;

                total += timeToStay;

                Console.WriteLine($"***{camperModel}");
            }

            Console.WriteLine($"Total stay: {total} nights");
        }
    }
}

