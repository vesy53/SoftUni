using System;

namespace p04RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split();

            string[] newArr = new string[arr.Length];
            string lastElement = arr[arr.Length - 1];
            newArr[0] = lastElement;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i + 1] = arr[i];
            }

            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}
