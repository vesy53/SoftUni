using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences1
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

        List<string> result = new List<string>();

        foreach (KeyValuePair<string, int> word in words)
        {
            if (word.Value % 2 != 0)
            {
                result.Add(word.Key);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }
}

