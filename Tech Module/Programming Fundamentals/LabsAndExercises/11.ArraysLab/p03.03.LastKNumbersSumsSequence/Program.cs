﻿using System;

namespace p03LastKNumbersSumsSequence2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            long[] sequence = new long[num1];
            sequence[0] = 1;

            for (long i = 1; i < sequence.Length; i++)
            {
                long start = Math.Max(0, i - num2);
                long end = i - 1;
                sequence[i] = NumsSumsSequence(sequence, start, end);
            }

            Console.WriteLine(string.Join(" ", sequence));
        }

        static long NumsSumsSequence(long[] sequence, long start, long end)
        {
            long sum = 0;

            for (long j = start; j <= end; j++)
            {
                if (j >= 0)
                {
                    sum += sequence[j];
                }
            }

            return sum;
        }
    }
}
