using System;
using System.Linq;

namespace p05CountOfOddNumbersInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(
                arr.Where(x => x % 2 == 1 || x % 2 == -1).Count());
        }
    }
}
