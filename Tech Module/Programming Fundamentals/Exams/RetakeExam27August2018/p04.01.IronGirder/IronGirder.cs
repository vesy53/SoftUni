namespace p04._01.IronGirder
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class IronGirder
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Railway>();

            string input = Console.ReadLine();

            while (input.Equals("Slide rule") == false)
            {
                string[] tokens = input
                    .Split(new string[] { ":", "->" },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string townName = tokens[0];
                string ambush = tokens[1];
                long passengersCount = long.Parse(tokens[2]);

                if (ambush == "ambush")
                {
                    if (!data.ContainsKey(townName)) //If it's the first time Iron Girder travels 
                    {                                //to this town then you simply ignore this line.
                        data.Add(townName, new Railway());
                    }
                    else
                    {
                        data[townName].Time = 0;
                        data[townName].PassengersCount -= passengersCount;
                    }
                }
                else
                {
                    int time = int.Parse(ambush);

                    if (!data.ContainsKey(townName))
                    {
                        data.Add(townName, new Railway());
                    }

                    if (data[townName].Time == 0 || data[townName].Time > time)
                    {
                        data[townName].Time = time;
                    }

                    data[townName].PassengersCount += passengersCount;
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .Where(x => x.Value.Time > 0 && x.Value.PassengersCount > 0)
                .OrderBy(x => x.Value.Time)
                .ThenBy(x => x.Key))
            {
                string townName = itemData.Key;
                int time = itemData.Value.Time;
                long passengersCount = itemData.Value.PassengersCount;

                Console.WriteLine(
                    $"{townName} -> Time: {time} -> Passengers: {passengersCount}");

            }
        }
    }

    class Railway
    {
        public int Time { get; set; }

        public long PassengersCount { get; set; }
    }
}
