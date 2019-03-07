using System;
using System.Linq;

namespace p01Last3ConsecutiveEqualStrings
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

            for (int i = 0; i < text.Length - 1; i++)
            {          
                if (text[i] == text[i + 1] && text[i] == text[i + 2])
                {
                    equalStr += text[i] + " " + text[i + 1] + " " + text[i + 2];
                    break;
                }                
            }

            Console.WriteLine(equalStr);
        }
    }
}
