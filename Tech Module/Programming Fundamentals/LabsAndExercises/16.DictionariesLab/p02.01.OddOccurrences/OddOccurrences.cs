using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences
{
    static void Main(string[] args)
    {
        Dictionary<string, int> words = new Dictionary<string, int>();
        string[] wordsInput = Console.ReadLine()
            .Split()
            .Select(w => w.ToLower())
            .ToArray();

        for (int i = 0; i < wordsInput.Length; i++)
        {
            if (!words.ContainsKey(wordsInput[i]))
            {
                words.Add(wordsInput[i], 0);
            }

            words[wordsInput[i]]++;
        }

        List<string> result = new List<string>();

        foreach (KeyValuePair<string, int> word in words)
        {
            if (word.Value % 2 == 1)
            {
                result.Add(word.Key);
            }
        }

        Console.WriteLine(string.Join(", ", result));
    }   
}

