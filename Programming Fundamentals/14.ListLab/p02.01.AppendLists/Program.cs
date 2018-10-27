using System;
using System.Collections.Generic;
using System.Linq;

namespace p02AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            char[] delimeter = " ".ToCharArray();
            List<string> reversedNums = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                List<string> currentNums = input[i]
                    .Split(delimeter, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                reversedNums.AddRange(currentNums);
            }

            Console.WriteLine(string.Join(" ", reversedNums));
        }
    }
}
