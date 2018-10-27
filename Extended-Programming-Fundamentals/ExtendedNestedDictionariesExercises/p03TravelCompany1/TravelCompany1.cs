using System;
using System.Collections.Generic;
using System.Linq;

class TravelCompany1
{
    static void Main(string[] args)
    {
        var travelCompany = new Dictionary<string, Dictionary<string, int>>();
        string[] commands = Console.ReadLine()
            .Split(':');

        while (commands[0] != "ready")
        {
            string city = commands[0];
            string inputData = commands[1];
            string[] vehicleData = inputData
                .Split(',');

            foreach (var item in vehicleData)
            {
                string[] itemTokens = item
                    .Split('-');

                string bus = itemTokens[0];
                int capacity = int.Parse(itemTokens[1]);

                if (!travelCompany.ContainsKey(city))
                {
                    travelCompany.Add(city, new Dictionary<string, int>());
                }

                travelCompany[city][bus] = capacity;
            }

            commands = Console.ReadLine()
                .Split(':');
        }

        string[] groupSize = Console.ReadLine()
            .Split();

        while (groupSize[0] != "travel")
        {
            string destination = groupSize[0];
            int passengers = int.Parse(groupSize[1]);

            Dictionary<string, int> data = travelCompany[destination];

            int totalPassenger = data
                .Select(x => x.Value)
                .Sum();

            if (totalPassenger >= passengers)
            {
                Console.WriteLine(
                    $"{destination} -> all {passengers} accommodated");
            }
            else
            {
                passengers -= totalPassenger;

                Console.WriteLine(
                    $"{destination} -> all except {passengers} accommodated");
            }

            groupSize = Console.ReadLine()
                .Split();
        }
    }
}

