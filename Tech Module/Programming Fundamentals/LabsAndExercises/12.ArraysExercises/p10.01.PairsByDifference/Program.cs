using System;
using System.Linq;

namespace p10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int diff = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int result = Math.Abs(numbers[j] - numbers[i]);

                    if (result == diff)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
