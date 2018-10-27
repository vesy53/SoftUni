using System;

namespace p03LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            long[] sequence = new long[num1];
            sequence[0] = 1;

            for (int i = 1; i < num1; i++)
            {
                long sum = 0;

                for (int j = i - num2; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += sequence[j];
                    }                   
                }

                sequence[i] = sum;
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
