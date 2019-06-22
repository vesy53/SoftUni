namespace p04._02.TravelMap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TravelMap
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<Travel>>();

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split(" > ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string country = tokens[0];
                string townName = tokens[1];
                int travelCost = int.Parse(tokens[2]);

                if (!data.ContainsKey(country))
                {
                    data.Add(country, new List<Travel>());
                }

                bool isExistTown = data[country]
                    .Any(t => t.TownName == townName);

                Travel travel = new Travel(townName, travelCost);

                if (!isExistTown)
                {
                    data[country].Add(travel);
                }
                else
                {
                    foreach (Travel currentTravel in data[country]
                           .Where(d => d.TownName == townName)
                           .Where(c => c.Cost > travelCost))
                    {
                        currentTravel.Cost = travelCost;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderBy(i => i.Key)
                .ThenBy(i => i.Value.OrderBy(c => c.Cost)))
            { 
                string country = itemData.Key;
                List<Travel> travels = itemData.Value;

                Console.Write($"{country} -> ");

                foreach (Travel travelData in travels
                    .OrderBy(t => t.Cost))
                {
                    Console.Write(travelData);
                }

                Console.WriteLine();
            }
        }
    }

    class Travel
    {
        public Travel()
        {

        }

        public Travel(string townName)
        {
            this.TownName = townName;
        }

        public Travel(string townName, int cost)
        {
            this.TownName = townName;
            this.Cost = cost;
        }

        public string TownName { get; set; }

        public int Cost { get; set; }

        public override string ToString()
        {
            string result = string.Format(
                $"{this.TownName} -> {this.Cost} ");

            return result;
        }
    }
}
