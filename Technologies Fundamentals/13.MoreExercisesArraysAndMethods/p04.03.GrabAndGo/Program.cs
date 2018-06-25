using System;
using System.Linq;

namespace p04GrabAndGo2
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            long numToSearch = long.Parse(Console.ReadLine());

            if (arr.Contains(numToSearch) == false)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }

            long result = arr
                .Reverse()
                .SkipWhile(x => x != numToSearch)
                .Sum() - numToSearch;

            Console.WriteLine(result);
        }
    }
}
