using System;
using System.Collections.Generic;
using System.Linq;

namespace p03SearchForANumber
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
            int deleteElements = arr[1];
            int searchElement = arr[2];

            numbers.Take(takeElements);
            numbers.RemoveRange(0, deleteElements);
            
            if (numbers.Contains(searchElement))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
