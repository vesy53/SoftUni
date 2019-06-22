namespace p01._02.SportCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SportCards
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<Sport>>();

            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                if (!input.Contains("check"))
                {
                    string[] tokens = input
                        .Split(" - ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string card = tokens[0];
                    string sportName = tokens[1];
                    decimal price = decimal.Parse(tokens[2]);

                    if (!data.ContainsKey(card))
                    {
                        data.Add(card, new List<Sport>());
                    }

                    Sport searchSportName = data[card]
                        .Where(d => d.Name == sportName)
                        .FirstOrDefault();

                    if (searchSportName == null)
                    {
                        Sport currentSport = new Sport(sportName, price);
                        data[card].Add(currentSport);
                    }
                    else
                    {
                        foreach (Sport itemSport in data[card]
                            .Where(i => i.Name == sportName))
                        {
                            itemSport.Price = price;
                        }
                    }
                }
                else if (input.Contains("check"))
                {
                    string[] tokens = input
                        .Split(" ",
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    string card = tokens[1];

                    if (data.ContainsKey(card))
                    {
                        Console.WriteLine($"{card} is available!");
                    }
                    else 
                    {
                        Console.WriteLine($"{card} is not available!");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderByDescending(d => d.Value.Count()))
            {
                string card = itemData.Key;
                List<Sport> sports = itemData.Value;

                Console.WriteLine($"{card}:");

                foreach (Sport sport in sports
                    .OrderBy(s => s.Name))
                {
                    Console.WriteLine(sport.ToString());
                }
            }
        }
    }

    class Sport
    {
        public Sport(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            string result = string.Format(
                $"  -{this.Name} - {this.Price:F2}");

            return result;
        }
    }
}
