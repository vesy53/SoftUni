using System;
using System.Linq;

namespace p02RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rotationCount = int.Parse(Console.ReadLine());

            int[] sumArr = new int[arr.Length];

            for (int i = 0; i < rotationCount; i++)
            {
                int lastElement = arr[arr.Length - 1];
               
                //записване на предишния елемент в настоящия, т.е. изместваме с 1-на позиция напред с-стите 
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
            
                arr[0] = lastElement;

                for (int k = 0; k < arr.Length; k++)
                {
                    sumArr[k] += arr[k];
                }
            }
            
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
