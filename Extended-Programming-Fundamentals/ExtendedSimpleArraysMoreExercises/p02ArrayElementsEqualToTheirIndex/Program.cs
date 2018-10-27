using System;
using System.Linq;

namespace p02ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string newArr = string.Empty;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    newArr += arr[i].ToString() + " ";
                }
            }

            Console.WriteLine(newArr);
        }
    }
}
