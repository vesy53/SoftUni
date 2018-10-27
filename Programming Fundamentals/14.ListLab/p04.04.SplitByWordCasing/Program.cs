using System;
using System.Collections.Generic;
using System.Linq;

namespace p04SplitByWordCasing3
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
                if (IsLower(word))
                {
                    lowerCase.Add(word);
                }
                else if (IsUpper(word))
                {
                    upperCase.Add(word);
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

        static bool IsUpper(string word)
        {
            foreach (var w in word)
            {
                if (w < 'A' || w > 'Z')
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsLower(string word)
        {
            foreach (var w in word)
            {
                if (w < 'a' || w > 'z')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
