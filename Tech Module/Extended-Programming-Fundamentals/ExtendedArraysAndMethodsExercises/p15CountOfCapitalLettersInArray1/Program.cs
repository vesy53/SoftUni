using System;
using System.Linq;

namespace p15CountOfCapitalLettersInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split()
                .ToArray();

            int countIsUpper = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length == 1)
                {
                    char letter = char.Parse(text[i]);

                    if (char.IsUpper(letter))
                    {
                        countIsUpper++;
                    }
                }
            }

            Console.WriteLine(countIsUpper);
        }
    }
}
