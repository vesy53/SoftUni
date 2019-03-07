using System;

namespace p07CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            int countCapitalLetters = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1)
                {
                    char letter = char.Parse(words[i]);

                    if (letter >= 'A' && letter <= 'Z')
                    {
                        countCapitalLetters++;
                    }
                }
            }

            Console.WriteLine(countCapitalLetters);
        }
    }
}
