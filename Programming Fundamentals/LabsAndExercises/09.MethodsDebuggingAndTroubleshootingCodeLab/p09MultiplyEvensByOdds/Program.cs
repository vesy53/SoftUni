using System;

namespace p09MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            num = Math.Abs(num);
            int result = MultipleOfEvenAndOddSum(num);

            Console.WriteLine(result);
        }

        static int MultipleOfEvenAndOddSum(int num)
        {
            int oddSum = SumOfOddDigits(num);
            int evenSum = SumOfEvenDigits(num);

            return oddSum * evenSum;
        }

        static int SumOfEvenDigits(int num)
        {
            int evenSum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }

                num /= 10;
            }

            return evenSum;
        }

        static int SumOfOddDigits(int num)
        {
            int oddSum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;

                if (lastDigit % 2 == 1)
                {
                    oddSum += lastDigit;
                }

                num /= 10;
            }

            return oddSum;
        }
    }
}
