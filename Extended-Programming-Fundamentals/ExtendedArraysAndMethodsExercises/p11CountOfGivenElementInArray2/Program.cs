using System;
using System.Linq;

namespace p11CountOfGivenElementInArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int searchNum = int.Parse(Console.ReadLine());

            var count = arr.Where(x => x == searchNum).Count();

            Console.WriteLine(count);
        }
    }
}
