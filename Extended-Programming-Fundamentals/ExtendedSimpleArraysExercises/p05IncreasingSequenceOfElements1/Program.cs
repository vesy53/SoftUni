using System;
using System.Linq;

namespace p05IncreasingSequenceOfElements1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isIncreasingSequence = true;

            foreach (var a in arr)
            {
                if (a > a + 1)
                {
                    isIncreasingSequence = false;
                    break;
                }
            }

            if (isIncreasingSequence)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
