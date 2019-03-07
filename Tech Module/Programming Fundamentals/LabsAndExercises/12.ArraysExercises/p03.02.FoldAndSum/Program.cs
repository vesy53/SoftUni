using System;
using System.Linq;

namespace p03FoldAndSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int k = arr.Length / 4;

            int[] firstElements = arr
                .Take(k)
                .ToArray();
            Array.Reverse(firstElements);

            int[] lastElement = arr
                .Skip(3 * k)
                .Take(k)
                .ToArray();
            Array.Reverse(lastElement);

            int[] concatedElement = firstElements.Concat(lastElement).ToArray();

            int[] middleElements = arr
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            int[] sumArr = new int[middleElements.Length];

            for (int i = 0; i < middleElements.Length; i++)
            {
                sumArr[i] = concatedElement[i] + middleElements[i];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
