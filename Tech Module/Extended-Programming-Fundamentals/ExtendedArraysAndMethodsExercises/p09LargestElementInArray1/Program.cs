﻿using System;
using System.Linq;

namespace p09LargestElementInArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arr = new int[number];

            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(arr.Max());
        }
    }
}
