using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing
{
    static void Main(string[] args)
    {
        List<string> text = Console.ReadLine()
            //.Split(new char[] {',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' }
            .Split(",;:.!()\"'\\/[] "
            .ToCharArray()
            , StringSplitOptions
            .RemoveEmptyEntries)
            .ToList();

        List<string> lowerWords = new List<string>();
        List<string> mixedWords = new List<string>();
        List<string> upperWords = new List<string>();

        foreach (var word in text)
        {
            int length = word.Length;
            int countLower = 0;
            int countUpper = 0;

            foreach (var w in word)
            {
                if (w >= 'a' && w <= 'z')
                {
                    countLower++;
                }
                else if (w >= 'A' && w <= 'Z')
                {
                    countUpper++;
                }
            }

            if (countLower == length)
            {
                lowerWords.Add(word);
            }
            else if (countUpper == length)
            {
                upperWords.Add(word);
            }
            else
            {
                mixedWords.Add(word);
            }
        }

        Console.WriteLine($"Lower-case: {string.Join(", ", lowerWords)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedWords)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperWords)}");
    }
}

