using System;
using System.Collections.Generic;
using System.Linq;

namespace p01RemoveNegativesAndReverse1
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

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    newList.Add(numbers[i]);
                }
            }

            newList.Reverse();

            bool isEmpty = true;

            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] != 0)
                {
                    isEmpty = false;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newList));
            }
        }
    }
}
