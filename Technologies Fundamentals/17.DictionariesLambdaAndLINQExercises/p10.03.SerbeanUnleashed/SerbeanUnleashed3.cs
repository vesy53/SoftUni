using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SerbeanUnleashed3
{ //70 / 100
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, int>>();

        string input = Console.ReadLine();

        while (input.Equals("End") == false)
        {
            try
            {
                List<string> currentInput = input
                    .Split(' ')
                    .ToList();
                List<string> before = input
                    .Split(new string[] { " @" },
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToList();

                string singer = before[0];
                string venue = Regex.Replace(before[1], "[0-9]", "").Trim();
                int ticketsCount = int.Parse(currentInput[currentInput.Count - 1]);
                int ticketsPrice = int.Parse(currentInput[currentInput.Count - 2]);
                int totalPrice = ticketsPrice * ticketsCount;

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
            catch (Exception)
            {
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

