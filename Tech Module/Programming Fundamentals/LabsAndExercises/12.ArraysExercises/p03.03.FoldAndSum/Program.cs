using System;
using System.Linq;

namespace p03FoldAndSum2
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
            
            int[] firstElement = FoldFirstElementOfTheArray(arr, k);
            int[] middleElement = TakeTheMiddlePartOfTheArray(arr, k);
            int[] lastElement = FoldLastElementOfTheArray(arr, k);

            int[] sumArr = SumElementOfTheArray(arr, k, firstElement, lastElement, middleElement);

            Console.WriteLine(string.Join(" ", sumArr));
        }

        static int[] FoldFirstElementOfTheArray(int[] arr, int k)
        {
            int[] firstElement = new int[k];

            for (int i = 0; i < k; i++)
            {
                firstElement[i] = arr[i];
            }

            Array.Reverse(firstElement);

            return firstElement;
        }

        static int[] FoldLastElementOfTheArray(int[] arr, int k)
        {
            int[] lastElement = new int[k];

            for (int i = 0; i < k; i++)
            {
                lastElement[i] = arr[arr.Length - 1 - i];
            }           

            return lastElement;
        }

        static int[] TakeTheMiddlePartOfTheArray(int[] arr, int k)
        {
            int[] middleElement = new int[2 * k];

            for (int i = 0; i < 2 * k; i++)
            {
                middleElement[i] = arr[i + k];
            }

            return middleElement;
        }

        static int[] SumElementOfTheArray(int[] arr, int k, int[] firstElement, int[] lastElement, int[] middleElement)
        {
            int[] sumArr = new int[middleElement.Length];

            for (int i = 0; i < k; i++)
            {
                sumArr[i] = firstElement[i] + middleElement[i];
                sumArr[i + k] = lastElement[i] + middleElement[i + k];
            }

            return sumArr;
        }
    }
}
