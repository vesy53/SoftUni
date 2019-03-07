namespace p04._02.ForceBook
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class ForceBook2
    {
        static void Main(string[] args)
        {
            var sides = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input.Equals("Lumpawaroo") == false)
            {
                if (input.Contains("|"))
                {
                    string[] tokens = input
                        .Split(" | ");
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (!sides.Values.Any(x => x.Contains(user)))
                    {
                        sides[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] tokens = input
                        .Split(" -> ");
                    string user = tokens[0];
                    string side = tokens[1];

                    if (sides.Values.Any(x => x.Contains(user)))
                    {
                        sides.Values.First(x => x.Contains(user)).Remove(user);

                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else  //ако user-а не се съдържа в нито един side
                    {
                        if (!sides.ContainsKey(side))
                        {
                            sides.Add(side, new List<string>());
                        }

                        sides[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in sides
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
