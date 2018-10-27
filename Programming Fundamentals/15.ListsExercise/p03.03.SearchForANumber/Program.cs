using System;
using System.Collections.Generic;
using System.Linq;

namespace p03SearchForANumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int takeElements = arr[0];
            int deleteElement = arr[1];
            int searchElement = arr[2];
            bool isEqual = true;

            for (int i = deleteElement; i < takeElements; i++)
            {
                if (numbers[i] == searchElement)
                {
                    Console.WriteLine("YES!");
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
