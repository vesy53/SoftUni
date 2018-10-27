using System;
using System.Collections.Generic;
using System.Linq;

namespace p07CountNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            input.Sort((a, b) => a.CompareTo(b));

            IEnumerable<IGrouping<int, int>> groups = input
                .GroupBy(item => item);

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} -> {group.Count()}");
            }
        }
    }
}
