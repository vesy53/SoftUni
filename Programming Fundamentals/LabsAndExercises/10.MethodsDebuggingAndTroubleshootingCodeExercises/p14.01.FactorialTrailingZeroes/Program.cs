using System;
using System.Numerics;

namespace p14FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int count = CounTrailingZeroes(num);

            Console.WriteLine(count);
        }

        static int CounTrailingZeroes(int num)
        {
            BigInteger factorial = FindFactorial(num);
            int count = 0;

            while(factorial > 0)
            {
                BigInteger lastDigit = factorial % 10;
                factorial /= 10;

                if (lastDigit == 0)
                {
                    count++;
                }

                if (lastDigit != 0)
                {
                    break;
                }
            }

            return count;
        }

        static BigInteger FindFactorial(int num)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
