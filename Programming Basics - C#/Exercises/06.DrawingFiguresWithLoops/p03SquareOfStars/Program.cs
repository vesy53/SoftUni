﻿using System;

namespace p03SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
               Console.Write("*");
               
               for (int col = 1; col < n; col++)
               {
                   Console.Write(" *");
               }
               
               Console.WriteLine();
            }
        }
    }
}
