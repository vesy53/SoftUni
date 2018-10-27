using System;
using System.Collections.Generic;
using System.Linq;

namespace p02AppendLists1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();

            List<int> reversedNums = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<int> currentNum = input[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (var num in currentNum)
                {
                    reversedNums.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", reversedNums));
        }
    }
}
