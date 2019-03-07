using System;

namespace p15CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            var count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length == 1)
                {
                    char letter = char.Parse(text[i]);

                    if (letter >= 'A' && letter <= 'Z')
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
