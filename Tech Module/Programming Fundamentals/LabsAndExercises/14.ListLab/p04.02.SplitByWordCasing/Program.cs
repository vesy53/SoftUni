using System;
using System.Collections.Generic;
using System.Linq;

namespace p04SplitByWordCasing1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = ",;:.!()\"\'\\/[] ".ToCharArray();

            List<string> text = Console.ReadLine()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var word in text)
            {
                if (word.Any(x => !char.IsLetter(x)))
                {
                    mixedCase.Add(word);
                }
                else if (word.ToUpper().Equals(word))
                {
                    upperCase.Add(word);
                }
                else if (word.ToLower().Equals(word))
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
