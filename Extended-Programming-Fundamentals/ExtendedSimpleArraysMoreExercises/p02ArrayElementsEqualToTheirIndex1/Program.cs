using System;
using System.Linq;

namespace p02ArrayElementsEqualToTheirIndex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.WriteLine();

            //another method
            //var result = arr.Where((x, i) => x == i).ToArray();        
            //Console.WriteLine(string.Join(" ", result));
        }
    }
}
