using System;

namespace p07CountOfCapitalLettersInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            int countCapitalLetters = 0;

            foreach (var word in words)
            {
                if (word.Length == 1)
                {
                    char letter = char.Parse(word);

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
