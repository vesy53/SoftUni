namespace p02._01.SoftUniKaraoke
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var dataSingers = new Dictionary<string, List<string>>();

            string[] participants = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string[] songs = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string input = Console.ReadLine();

            while (input.Equals("dawn") == false)
            {
                string[] tokens = input
                    .Split(new string[] { ", " },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string participant = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(participant) &&
                    songs.Contains(song))
                {
                    if (!dataSingers.ContainsKey(participant))
                    {
                        dataSingers.Add(participant, new List<string>());
                    }

                    dataSingers[participant].Add(award);
                }

                input = Console.ReadLine();
            }

            if (dataSingers.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var singer in dataSingers
                    .OrderByDescending(x => x.Value.Distinct().Count())
                    .ThenBy(x => x.Key))
                {
                    string participant = singer.Key;
                    List<string> awards = singer.Value;
                    int count = singer.Value.Distinct().Count();

                    Console.WriteLine($"{participant}: {count} awards");

                    foreach (var award in awards
                            .Distinct()
                            .OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }

            }
        }
    }
}
