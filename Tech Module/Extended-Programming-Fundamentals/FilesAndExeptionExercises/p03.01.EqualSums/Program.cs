﻿namespace p03._01.EqualSums
{
    using System;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split()
                .ToArray();

            File.WriteAllLines("input.txt", numbers);

            bool hasEqualSum = false;

            File.WriteAllText("output.txt", string.Empty);

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = numbers
                    .Take(i)
                    .Select(int.Parse)
                    .Sum();

                int rightSum = numbers
                    .Skip(i + 1)
                    .Select(int.Parse)
                    .Sum();

                if (leftSum == rightSum)
                {
                    File.WriteAllText("output.txt", i.ToString());

                    hasEqualSum = true;
                    break;
                }
            }

            if (!hasEqualSum)
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}
