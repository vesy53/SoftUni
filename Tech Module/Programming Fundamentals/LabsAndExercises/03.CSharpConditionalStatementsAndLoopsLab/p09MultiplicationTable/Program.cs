﻿using System;

namespace p09MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int multiplication = 0;

            for (int i = 1; i <= 10; i++)
            {
                multiplication = num * i;

                Console.WriteLine($"{num} X {i} = {multiplication}");
            }
        }
    }
}
