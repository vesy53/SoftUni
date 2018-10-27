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

            newArr = RotateStringsArray(arr);

            PrintArray(newArr);
        }

        static string[] RotateStringsArray(string[] arr)
        {
            string[] newArr = new string[arr.Length];
            string lastElement = arr[arr.Length - 1];
            newArr[0] = lastElement;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i + 1] = arr[i];
            }

            return newArr;
        }

        static void PrintArray(string[] newArr)
        {
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

