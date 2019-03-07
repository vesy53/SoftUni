using System;
using System.Collections.Generic;
using System.Linq;

class SplitByWordCasing1
{
    static void Main(string[] args)
    {
        List<string> text = Console.ReadLine()
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
            if (word.Any(x => char.IsDigit(x)))
            {
                mixedWords.Add(word);
            }
            else if (word.ToLower().Equals(word))
            {
                lowerWords.Add(word);
            }
            else if (word.ToUpper().Equals(word))
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

