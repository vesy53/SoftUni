using System;
using System.Collections.Generic;
using System.Linq;

namespace p07CountNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
           .Split(' ')
           .Select(int.Parse)
           .ToList();

            numbers.Sort();
            int i = 0;

            while (i < numbers.Count)
            {
                int num = numbers[i];
                int count = 1;

                while (i + count < numbers.Count &&
                    numbers[i + count] == num)
                {
                    count++;
                }

                i += count;

                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
