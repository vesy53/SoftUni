namespace p04._02.IronGirder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class IronGirder2
    {
        static void Main(string[] args)
        {
            var towns = new Dictionary<string, Town>();

            string input = Console.ReadLine();

            while (input != "Slide rule")
            {
                string[] tokens = input
                    .Split(new string[] { ":", "->" },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string townName = tokens[0];
                int passengers = int.Parse(tokens[2]);

                if (tokens[1] == "ambush")
                {
                    if (towns.ContainsKey(townName))
                    {
                        towns[townName].Ambush(passengers);
                    }

                    input = Console.ReadLine();

                    continue;
                }

                int time = int.Parse(tokens[1]);

                if (!towns.ContainsKey(townName))
                {
                    towns[townName] = new Town(townName, time, passengers);
                }
                else
                {
                    if (towns[townName].Time == 0 || towns[townName].Time > time)
                    {
                        towns[townName].UpdateTime(time);
                    }

                    towns[townName].AddPassengers(passengers);
                }

                input = Console.ReadLine();
            }

            towns
                .Select(t => t.Value)
                .Where(t => t.Time != 0 && t.Passengers != 0)
                .OrderBy(t => t.Time)
                .ThenBy(t => t.TownName)
                .ToList()
                .ForEach(t => Console.WriteLine(t));
        }
    }

    class Town
    {
        public string TownName { get; private set; }

        public int Time { get; private set; }

        public int Passengers { get; private set; }

        public Town(string townName, int time, int passengers)
        {
            this.TownName = townName;
            this.Time = time;
            this.Passengers = passengers;
        }

        public void AddPassengers(int passengers)
        {
            this.Passengers += passengers;
        }

        public void Ambush(int passengers)
        {
            this.Time = 0;
            this.Passengers -= passengers;

            if (this.Passengers < 0)
            {
                this.Passengers = 0;
            }
        }

        public void UpdateTime(int time)
        {
            this.Time = time;
        }

        public override string ToString()
        {
            string townName = TownName;
            int time = Time;
            int passengers = Passengers;

            string result = $"{townName} -> Time: {time} -> Passengers: {passengers}";

            return result;
        }
    }
}
