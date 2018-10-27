using System;
using System.Linq;

namespace p01Last3ConsecutiveEqualStrings1
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

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[i + 1])
                {
                    counter++;
                    equalStr = text[i];

                    if (counter == 3)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("{0} {0} {0}", equalStr);
        }
    }
}
