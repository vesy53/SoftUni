namespace o04._01.MeTubeStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MeTubeStatistics
    {
        static void Main(string[] args)
        {
            var dataViews = new Dictionary<string, long>();
            var dataLikes = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input.Equals("stats time") == false)
            {
                string[] tokens = input
                    .Split(new char[] { '-', ':' },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string name = tokens[0];
                string videoName = tokens[1];

                if (name == "like")
                {
                    if (dataLikes.ContainsKey(videoName))
                    {
                        dataLikes[videoName]++;
                    }
                }
                else if (name == "dislike")
                {
                    if (dataLikes.ContainsKey(videoName))
                    {
                        dataLikes[videoName]--;
                    }
                }
                else
                {
                    long view = long.Parse(videoName);

                    if (!dataViews.ContainsKey(name))
                    {
                        dataViews.Add(name, 0);
                        dataLikes.Add(name, 0);
                    }

                    dataViews[name] += view;
                }

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            if (command == "by likes")
            {
                foreach (var dataLike in dataLikes
                    .OrderByDescending(x => x.Value))
                {
                    string name = dataLike.Key;
                    int count = dataLike.Value;
                    long views = dataViews[name];

                    Console.WriteLine(
                        $"{name} - {views} views - {count} likes");
                }
            }
            else if (command == "by views")
            {
                foreach (var dataView in dataViews
                    .OrderByDescending(x => x.Value))
                {
                    string name = dataView.Key;
                    long countViews = dataView.Value;
                    int countLikes = dataLikes[name];

                    Console.WriteLine(
                        $"{name} - {countViews} views - {countLikes} likes");
                }
            }
        }
    }
}
