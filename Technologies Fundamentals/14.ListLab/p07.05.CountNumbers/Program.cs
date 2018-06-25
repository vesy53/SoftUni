using System;
using System.Collections.Generic;
using System.Linq;

namespace p07CountNumbers4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> numbersCount = new SortedDictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!numbersCount.ContainsKey(num))
                {
                    numbersCount.Add(num, 0);
                }

                numbersCount[num]++;
            }

            foreach (var number in numbersCount)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
