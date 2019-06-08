namespace p07._02.TheVLogger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheVLogger
    {
        static void Main(string[] args)
        {
            var followers = new Dictionary<string, List<string>>();
            var following = new Dictionary<string, List<string>>();

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
                    if (!followers.ContainsKey(vloggername))
                    {
                        followers.Add(vloggername, new List<string>());
                    }

                    if (!following.ContainsKey(vloggername))
                    {
                        following.Add(vloggername, new List<string>());
                    }
                }
                else if (command == "followed")
                {
                    string secondVlogername = tokens[2];

                    if (followers.ContainsKey(vloggername) &&
                        followers.ContainsKey(secondVlogername) &&
                        vloggername != secondVlogername)
                    {
                        if (!followers[secondVlogername].Contains(vloggername))
                        {
                            followers[secondVlogername].Add(vloggername);
                        }
                    }

                    if (following.ContainsKey(vloggername) &&
                        following.ContainsKey(secondVlogername) &&
                        vloggername != secondVlogername)
                    {
                        if (!following[vloggername].Contains(secondVlogername))
                        {
                            following[vloggername].Add(secondVlogername);
                        }
                    }

                }

                input = Console.ReadLine();
            }

            int registeredVloggers = followers.Count;

            Console.WriteLine(
                $"The V-Logger has a total of {registeredVloggers} vloggers in its logs.");

            var vloggers = new Dictionary<string, List<List<string>>>();

            foreach (var data in followers)
            {
                string name = data.Key;
                List<string> followersName = data.Value;

                vloggers.Add(name, new List<List<string>>());

                vloggers[name].Add(followersName);
            }

            foreach (var data in following)
            {
                string name = data.Key;
                List<string> followingsName = data.Value;

                vloggers[name].Add(followingsName);
            }

            int count = 1;

            foreach (var data in vloggers
                .OrderByDescending(x => x.Value[0].Count)
                .ThenBy(x => x.Value[1].Count))
            {
                string vloggerName = data.Key;
                List<List<string>> vloggersArgs = data.Value;

                int countFollowers = vloggersArgs[0].Count;
                int countFollowings = vloggersArgs[1].Count;

                Console.WriteLine(
                    $"{count}. {vloggerName} : {countFollowers} followers, {countFollowings} following");

                if (count == 1)
                {
                    foreach (var follower in vloggersArgs[0]
                        .OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }
}
