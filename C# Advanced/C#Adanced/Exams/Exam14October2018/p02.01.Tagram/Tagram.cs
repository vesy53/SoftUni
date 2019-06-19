namespace p02._01.Tagram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Tagram
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, int>>();
            
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split(new char[] { ' ', '-', '>' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                if (tokens[0] == "ban")
                {
                    string username = tokens[1];

                    if (data.ContainsKey(username))
                    {
                        data.Remove(username);
                    }
                }
                else
                {
                    string username = tokens[0];
                    string tag = tokens[1];
                    int likes = int.Parse(tokens[2]);

                    if (!data.ContainsKey(username))
                    {
                        data.Add(username, new Dictionary<string, int>());
                    }

                    if (!data[username].ContainsKey(tag))
                    {
                        data[username].Add(tag, 0);
                    }

                    data[username][tag] = likes;
                }

                input = Console.ReadLine();
            }

            foreach (var itemData in data
                .OrderByDescending(d => d.Value.Values.Sum())
                .ThenBy(d => d.Value.Keys.Count()))
            {
                string username = itemData.Key;
                Dictionary<string, int> arguments = itemData.Value;

                Console.WriteLine($"{username}");

                foreach (var argument in arguments)
                {
                    string tag = argument.Key;
                    int likes = argument.Value;

                    Console.WriteLine($"- {tag}: {likes}");
                }
            }
        }
    }
}
