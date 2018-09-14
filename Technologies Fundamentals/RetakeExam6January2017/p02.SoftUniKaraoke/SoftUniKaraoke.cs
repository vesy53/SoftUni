namespace p02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string[] songs = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string input = Console.ReadLine();

            var data = new Dictionary<string, List<string>>();
            //var data = new Dictionary<string, HashSet<string>>();  //надоло е еднакво

            while (input.Equals("dawn") == false)
            {
                string[] tokens = input
                    .Split(new string[] { ", " },
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(name) &&
                    songs.Contains(song))
                {
                    if (!data.ContainsKey(name))
                    {
                        data.Add(name, new List<string>());
                    }

                    data[name].Add(award);
                }

                input = Console.ReadLine();
            }

            if (data.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in data
                    .OrderByDescending(x => x.Value.Distinct().ToList().Count)
                    .ThenBy(x => x.Key))
                {
                    string name = item.Key;
                    List<string> awards = item.Value;

                    Console.WriteLine($"{name}: {awards.Distinct().ToList().Count} awards");

                    foreach (string award in awards
                        .Distinct().ToList().OrderBy(n => n)) //без този ред 60/100
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
