using System;
using System.Collections.Generic;
using System.Linq;

namespace p01RemoveElementsAtOddPositions1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split()
                .Where((x, i) => i % 2 != 0) //start from 1 not 0
                .ToList();

            Console.WriteLine(string.Join("", text));
        }
    }
}
