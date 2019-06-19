namespace p01._01.SportCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SportCards
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, SortedDictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                if (!input.Contains("-"))
                {
                    string[] tokens = input
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string card = tokens[1];

                    if (!data.ContainsKey(card))
                    {
                        Console.WriteLine($"{card} is not available!");
                    }
                    else
                    {
                        Console.WriteLine($"{card} is available!");
                    }
                }
                else
                {
                    string[] tokens = input
                        .Split(" - ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string card = tokens[0];
                    string sport = tokens[1];
                    decimal price = decimal.Parse(tokens[2]);

                    if (!data.ContainsKey(card))
                    {
                        data.Add(card, new SortedDictionary<string, decimal>());
                    }

                    if (!data[card].ContainsKey(sport))
                    {
                        data[card].Add(sport, 0);
                    }

                    data[card][sport] = price;
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderByDescending(d => d.Value.Count))
            {
                string card = itemData.Key;
                SortedDictionary<string, decimal> cardArgs = itemData.Value;

                Console.WriteLine($"{card}:");

                foreach (var cardArg in cardArgs)
                {
                    string sport = cardArg.Key;
                    decimal price = cardArg.Value;

                    Console.WriteLine($"  -{sport} - {price:F2}");
                }
            }
        } 
    }
}
