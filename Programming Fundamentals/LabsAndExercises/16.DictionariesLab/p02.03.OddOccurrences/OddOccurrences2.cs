using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences2
{
    static void Main(string[] args)
    {
        Dictionary<string, int> words = new Dictionary<string, int>();
        string[] wordsInput = Console.ReadLine()
            .Split()
            .Select(w => w.ToLower())
            .ToArray();

        foreach (var word in wordsInput)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, 0);
            }

            words[word]++;
        }

        List<string> result = words
            .Where(w => w.Value % 2 == 1)
            .ToDictionary(w => w.Key, w => w.Value)
            .Keys
            .ToList();

        Console.WriteLine(string.Join(", ", result));
    }
}

