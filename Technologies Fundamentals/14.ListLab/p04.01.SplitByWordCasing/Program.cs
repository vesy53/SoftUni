using System;
using System.Collections.Generic;

namespace p04SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(",;:.!()\"'\\/[] "
                .ToCharArray()
                , StringSplitOptions
                .RemoveEmptyEntries);

            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            foreach (var word in text)
            {
                int countLower = 0;
                int countUpper = 0;
                int length = word.Length;

                foreach (var w in word)
                {                 
                    if (w >= 'A' && w <= 'Z')
                    {
                        countUpper++;
                    }
                    else if (w >= 'a' && w <= 'z')
                    {
                        countLower++;
                    }
                }

                if (countUpper == length)
                {
                    upperCase.Add(word);
                }
                else if (countLower == length)
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
