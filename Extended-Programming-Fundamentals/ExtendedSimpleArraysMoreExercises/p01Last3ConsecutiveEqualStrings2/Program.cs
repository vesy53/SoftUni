using System;
using System.Linq;

namespace p01Last3ConsecutiveEqualStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split()
                .Reverse()
                .ToArray();

            string equalStr = string.Empty;
            int counter = 1;
            int index = -1;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(text[i + 1]))
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }

                if (counter == 3)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(
                string.Concat(Enumerable.Repeat($"{text[index]} ", 3)));
        }
    }
}
