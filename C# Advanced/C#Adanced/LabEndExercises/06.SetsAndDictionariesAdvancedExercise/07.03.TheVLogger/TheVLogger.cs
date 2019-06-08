namespace p07._03.TheVLogger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheVLogger
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Vlogger>();

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
                        Vlogger newVlogger = new Vlogger()
                        {
                            Following = new List<string>(),
                            Followers = new List<string>()
                        };

                        vloggers.Add(vloggername, newVlogger);
                    }
                }
                else if (command == "followed")
                {
                    string secondVlogername = tokens[2];

                    if (vloggers.ContainsKey(vloggername) &&
                        vloggers.ContainsKey(secondVlogername) &&
                        vloggername != secondVlogername)
                    {
                        bool hasFollowing = vloggers[vloggername]
                            .Following
                            .Contains(secondVlogername);
                        bool hasFollowers = vloggers[secondVlogername]
                            .Followers
                            .Contains(vloggername);

                        if (!hasFollowing)
                        {
                            vloggers[vloggername].Following.Add(secondVlogername);
                        }

                        if (!hasFollowers)
                        {
                            vloggers[secondVlogername].Followers.Add(vloggername);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            int registeredVloggers = vloggers.Count;

            Console.WriteLine(
                $"The V-Logger has a total of {registeredVloggers} vloggers in its logs.");

            int count = 0;

            foreach (var vlogger in vloggers
                .OrderByDescending(x => x.Value.Followers.Count)
                .ThenBy(x => x.Value.Following.Count))
            {
                string vloggerName = vlogger.Key;
                Vlogger vloggersArgs = vlogger.Value;

                int countFollowers = vloggersArgs.Followers.Count;
                int countFollowing = vloggersArgs.Following.Count;

                Console.WriteLine(
                    $"{++count}. {vloggerName} : {countFollowers} followers, {countFollowing} following");

                if (count == 1)
                {
                    foreach (var follower in vloggersArgs
                        .Followers
                        .OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
            }
        }
    }

    class Vlogger
    {
        public List<string> Following { get; set; }

        public List<string> Followers { get; set; }
    }
}
