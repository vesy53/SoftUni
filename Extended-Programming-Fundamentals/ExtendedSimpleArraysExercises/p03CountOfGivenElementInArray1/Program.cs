using System;
using System.Linq;

namespace p03CountOfGivenElementInArray1
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

            var count = arr.Where(a => a == searchNum).Count();

            Console.WriteLine(count);
        }
    }
}
