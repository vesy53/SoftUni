namespace p04._01.ForceBook
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ForceBook
    {
        static void Main(string[] args)
        {
            var dataSide = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input.Equals("Lumpawaroo") == false)
            {
                if (input.Contains("|"))
                {
                    string[] tokens = input
                        .Split(new string[] { " | " },
                            StringSplitOptions
                            .RemoveEmptyEntries);
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!dataSide.ContainsKey(side))
                    {
                        dataSide.Add(side, new List<string>());
                    }

                    if(!dataSide.Values.Any(x => x.Contains(user)))
                    {
                        dataSide[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] tokens = input
                        .Split(new string[] { " -> " },
                            StringSplitOptions
                            .RemoveEmptyEntries);
                    string user = tokens[0];
                    string side = tokens[1];

                    if (dataSide.Any(x => x.Value.Contains(user)))
                    //if (dataSide.Values.Any(x => x.Contains(user)))
                    {
                        dataSide.Values.First(x => x.Contains(user)).Remove(user);
                    }

                    if (!dataSide.ContainsKey(side))
                    {
                        dataSide.Add(side, new List<string>());
                    }

                    dataSide[side].Add(user);

                    Console.WriteLine($"{user} joins the {side} side!");
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in dataSide
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                string side = itemData.Key;
                List<string> users = itemData.Value;
                int count = users.Count();

                Console.WriteLine(
                    $"Side: {side}, Members: {count}");

                foreach (string user in users
                    .OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
