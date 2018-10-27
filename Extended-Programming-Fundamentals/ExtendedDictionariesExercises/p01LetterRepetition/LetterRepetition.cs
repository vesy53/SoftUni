using System;
using System.Collections.Generic;

class LetterRepetition
{
    static void Main(string[] args)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        string textInput = Console.ReadLine();

        foreach (var text in textInput)
        {
            if (!letters.ContainsKey(text))
            {
                letters.Add(text, 0);
            }

            letters[text]++;
        }

        foreach (KeyValuePair<char,int> letter in letters)
        {
            Console.WriteLine($"{letter.Key} -> {letter.Value}");
        }
    }
}

