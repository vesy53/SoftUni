using System;
using System.Numerics;

namespace p13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger factorial = FindFactorial(num);

            Console.WriteLine(factorial);
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
