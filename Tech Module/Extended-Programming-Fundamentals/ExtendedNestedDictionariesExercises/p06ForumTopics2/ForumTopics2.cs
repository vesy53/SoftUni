using System;
using System.Collections.Generic;
using System.Linq;

class ForumTopics2
{
    static void Main(string[] args)
    {
        Dictionary<string, HashSet<string>> dataForum = new Dictionary<string, HashSet<string>>();
        string inputTokens = Console.ReadLine();

        while (inputTokens.Equals("filter") == false)
        {
            string[] currentInput = inputTokens
                .Split(new string[] { " -> " },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string keyWord = currentInput[0];
            List<string> valueWords = currentInput[1]
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
                dataForum[keyWord].Add($"#{word}");
            }

            inputTokens = Console.ReadLine();
        }

        string[] searchInput = Console.ReadLine()
            .Split(new string[] { ", " },
                StringSplitOptions
                .RemoveEmptyEntries);

        PrintForumTopicsData(dataForum, searchInput);
    }

    static void PrintForumTopicsData(
        Dictionary<string, HashSet<string>> dataForum,
        string[] searchInput)
    {
        foreach (var data in dataForum)
        {
            string key = data.Key;
            HashSet<string> values = data.Value;

            if (ContainsAllValues(values, searchInput))
            {
                Console.WriteLine(
                    $"{key} | {string.Join(", ", values)}");
            }
        }
    }

    static bool ContainsAllValues(
        HashSet<string> values,
        string[] searchInput)
    {
        foreach (var search in searchInput)
        {
            if (!values.Contains($"#{search}"))
            {
                return false;
            }
        }

        return true;
    }
}

