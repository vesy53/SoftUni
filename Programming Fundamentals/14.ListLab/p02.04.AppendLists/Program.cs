using System;
using System.Collections.Generic;
using System.Linq;

namespace p02AppendLists3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .Select(x => string.Join(
                    " ", x.Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries)))
                .ToList();

            foreach (var inner in input)
            {
                Console.WriteLine(string.Join(" ", inner));
            }

            Console.WriteLine();
        }
    }
}
