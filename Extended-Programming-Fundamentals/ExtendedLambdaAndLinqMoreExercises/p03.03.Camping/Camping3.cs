using System;
using System.Collections.Generic;
using System.Linq;

class Camping3
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
                campingsData[personName] = new Dictionary<string, int>();
            }

            campingsData[personName].Add(camperModel, timeToStay);

            input = Console.ReadLine();
        }

        foreach (var campingData in campingsData
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key.Length))
        {
            string personName = campingData.Key;
            Dictionary<string, int> modelAndTime = campingData.Value;

            Console.WriteLine($"{personName}: {modelAndTime.Count}");

            foreach (var item in modelAndTime)
            {
                string camperModel = item.Key;
                int timeToStay = item.Value;

                Console.WriteLine($"***{camperModel}");
            }

            Console.WriteLine(
                $"Total stay: {modelAndTime.Values.Sum()} nights");
        }
    }
}

