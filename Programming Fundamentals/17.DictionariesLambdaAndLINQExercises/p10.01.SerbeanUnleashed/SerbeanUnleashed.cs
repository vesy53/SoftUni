using System;
using System.Collections.Generic;
using System.Linq;

class SerbeanUnleashed
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, long>>();
        string input = Console.ReadLine();

        while (input != "End")
        {
            try
            {
                string[] inputTokens = input
                .Split(new string[] { " @" },
                    StringSplitOptions
                    .RemoveEmptyEntries);

                string singer = inputTokens[0];
                string[] venueData = inputTokens[1]
                    .Split();

                venueData = venueData.Reverse().ToArray();

                long ticketsCount = long.Parse(venueData[0]);
                long ticketPrice = long.Parse(venueData[1]);
                long totalPrice = ticketPrice * ticketsCount;

                venueData = venueData.Reverse().ToArray();
                string venue = string.Empty;

                for (int i = 0; i < venueData.Length - 2; i++)
                {
                    venue = venue + venueData[i] + " ";
                }

                if (!data.ContainsKey(venue))
                {
                    data.Add(venue, new Dictionary<string, long>());
                }

                if (!data[venue].ContainsKey(singer))
                {
                    data[venue].Add(singer, 0);
                }

                data[venue][singer] += totalPrice;
            }
            catch (Exception)
            {               
            }

            input = Console.ReadLine();
        }

        foreach (var itemData in data)
        {
            string venue = itemData.Key;
            Dictionary<string, long> singersData = itemData.Value;

            Console.WriteLine($"{venue}");

            foreach (var singerData in singersData
                .OrderByDescending(x => x.Value))
            {
                string singer = singerData.Key;
                long price = singerData.Value;

                Console.WriteLine($"#  {singer} -> {price}");
            }
        }
    }
}

