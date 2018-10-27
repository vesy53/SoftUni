using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SerbeanUnleashed2
{
    static void Main(string[] args)
    {
        string pattern = @"(([A-Za-z]+\s){1,})@(([A-Za-z]+\s){1,})(\d+)\s(\d+)";
        var data = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();

        while (input.Equals("End") == false)
        {
            Regex reg = new Regex(pattern);
            Match match = reg.Match(input);

            if (match.Success)
            {
                string singer = match.Groups[1].Value.Trim();
                string venue = match.Groups[3].Value.Trim();
                int ticketsPrice = int.Parse(match.Groups[5].Value);
                int ticketsCount = int.Parse(match.Groups[6].Value);

                int totalPrice = ticketsCount * ticketsPrice;

                if (!data.ContainsKey(venue))
                {
                    data.Add(venue, new Dictionary<string, int>());
                }

                if (!data[venue].ContainsKey(singer))
                {
                    data[venue].Add(singer, 0);
                }

                data[venue][singer] += totalPrice;
            }

            input = Console.ReadLine();
        }

        foreach (var itemData in data)
        {
            string venue = itemData.Key;
            Dictionary<string, int> singersData = itemData.Value;

            Console.WriteLine(venue);

            foreach (var singerData in singersData
                .OrderByDescending(x => x.Value))
            {
                string singer = singerData.Key;
                int priceTicket = singerData.Value;

                Console.WriteLine($"#  {singer} -> {priceTicket}");
            }
        }
    }
}

