using System;

namespace p04NthDigit1
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            long currentDigit = FindNthDigit(number, index);

            Console.WriteLine(currentDigit);
        }

        static long FindNthDigit(long number, int index)
        {
            long currentDigit = 0;

            for (int i = 1; i <= index; i++)
            {
                long digit = number % 10;

                if (i == index)
                {
                    currentDigit = digit;
                    break;
                }

                number /= 10;
            }

            return currentDigit;
        }
    }
}
