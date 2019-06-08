namespace p07._01.TheVLogger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheVLogger
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = Console.ReadLine();

            while (input.Equals("Statistics") == false)
            {
                string[] tokens = input
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string vloggername = tokens[0];
                string command = tokens[1];

                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(vloggername))
                    {
                        vloggers.Add(vloggername, new Dictionary<string, HashSet<string>>());

                        vloggers[vloggername].Add("Followers", new HashSet<string>());
                        vloggers[vloggername].Add("Following", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string secondVlogername = tokens[2];

                    if (vloggers.ContainsKey(secondVlogername) &&
                        vloggers.ContainsKey(vloggername) &&
                        vloggername != secondVlogername)
                    {
                        vloggers[secondVlogername]["Followers"].Add(vloggername);
                        vloggers[vloggername]["Following"].Add(secondVlogername);
                    }
                }

                input = Console.ReadLine();
            }

            int registeredVloggers = vloggers.Count;

            Console.WriteLine(
                $"The V-Logger has a total of {registeredVloggers} vloggers in its logs.");

            int count = 1;

            foreach (var vlogger in vloggers
                .OrderByDescending(x => x.Value["Followers"].Count)
                .ThenBy(x => x.Value["Following"].Count))
            {
                string vloggerName = vlogger.Key;
                Dictionary<string, HashSet<string>> vloggersArgs = vlogger.Value;

                int followers = vloggers[vloggerName]["Followers"].Count;
                int following = vloggers[vloggerName]["Following"].Count;

                Console.WriteLine(
                    $"{count}. {vloggerName} : {followers} followers, {following} following");

                if (count == 1)
                {
                    foreach (var name in vloggersArgs["Followers"]
                        .OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {name}");
                    }
                }

                count++;
            }
        }
    }
}
