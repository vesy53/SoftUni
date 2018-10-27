using System;

namespace p04NthDigit
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
            int newIndex = 1;
            long currentDigit = 0;

            while (number > 0)
            {
                long digit = number % 10;

                if (newIndex == index)
                {
                    currentDigit = digit;
                    break;
                }

                number /= 10;
                newIndex++;
            }

            return currentDigit;
        }
    }
}
