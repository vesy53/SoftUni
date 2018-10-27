using System;
using System.Numerics;

namespace p14FactorialTrailingZeroes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger factorial = FindFactorial(num);
            int countZeroes = CountsTrailingZeroes(factorial);

            Console.WriteLine(countZeroes);
        }

        static int CountsTrailingZeroes(BigInteger factorial)
        {
            int countZeroes = 0;

            while (factorial % 10 == 0)
            {
                countZeroes++;
                factorial /= 10;
            }

            return countZeroes;
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
