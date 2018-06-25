using System;
using System.Collections.Generic;

namespace p02AppendLists2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|');

            List<string[]> numElements = new List<string[]>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] currentNum = input[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                numElements.Add(currentNum);
            }

            foreach (var num in numElements)
            {
                Console.Write($"{string.Join(" ", num)} ");
            }

            Console.WriteLine();
        }
    }
}
