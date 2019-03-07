using System;
using System.Collections.Generic;
using System.Linq;

namespace p01RemoveNegativesAndReverse4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();

            foreach (var num in numbers)
            {
                if (num > 0)
                {
                    newList.Add(num);
                }
            }


            if (newList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                newList.Reverse();

                Console.WriteLine(string.Join(" ", newList));
            }
        }
    }
}
