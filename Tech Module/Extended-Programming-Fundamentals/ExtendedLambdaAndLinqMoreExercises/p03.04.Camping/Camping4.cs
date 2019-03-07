using System;
using System.Collections.Generic;
using System.Linq;

class Camping4
{
    static void Main(string[] args)
    {
        var campersData = new Dictionary<string, List<string>>();
        var daysData = new Dictionary<string, int>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            string[] inputTokens = input
                .Split(' ');

            string namePerson = inputTokens[0];
            string camperModel = inputTokens[1];
            int daysStayed = int.Parse(inputTokens[2]);

            if (!campersData.ContainsKey(namePerson))
            {
                campersData.Add(namePerson, new List<string>());
            }

            campersData[namePerson].Add(camperModel);

            if (!daysData.ContainsKey(namePerson))
            {
                daysData.Add(namePerson, 0);
            }

            daysData[namePerson] += daysStayed;

            input = Console.ReadLine();
        }

        var orderedCampersData = campersData
                .OrderByDescending(item => item.Value.Count)
                .ThenBy(item => item.Key.Length);

        foreach (var item in orderedCampersData)
        {
            string namePerson = item.Key;
            List<string> campersModel = item.Value;

            Console.WriteLine($"{namePerson}: {campersModel.Count}");

            foreach (var camper in campersModel)
            {
                Console.WriteLine($"***{camper}");
            }

            Console.WriteLine(
                $"Total stay: {daysData[namePerson]} nights");
        }
    }
}

