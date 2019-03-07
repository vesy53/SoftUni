using System;
using System.Collections.Generic;
using System.Linq;

class ForumTopics
{
    static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> dataForum = new Dictionary<string, HashSet<string>>();
        string[] inputTokens = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries);

        while (inputTokens[0] != "filter")
        {
            string keyWord = inputTokens[0];
            List<string> valueWords = inputTokens[1]
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .ToList();

            if (!dataForum.ContainsKey(keyWord))
            {
                dataForum.Add(keyWord, new HashSet<string>());
            }

            foreach (var word in valueWords)
            {
                dataForum[keyWord].Add(word);
            }

            inputTokens = Console.ReadLine()
            .Split(new string[] { " -> " },
                StringSplitOptions
                .RemoveEmptyEntries);
        }

        string[] searchInput = Console.ReadLine()
            .Split(new string[] { ", " },
                StringSplitOptions
                .RemoveEmptyEntries);
        int length = searchInput.Length;

        foreach (var data in dataForum)
        {
            string key = data.Key;
            HashSet<string> values = data.Value;
            int count = 0;

            foreach (var search in searchInput)
            {

                foreach (var value in values)
                {
                    if (value == search)
                    {
                        count++;

                        if (count == length)
                        {
                            Console.WriteLine(
                                $"{key} | #{string.Join(", #", values)}");
                        }
                    }
                }
            }
        }
    }
}

