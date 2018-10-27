using System;

namespace p06PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(num);

            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long num)
        {
            bool isPrime = true;

            if (num < 2)
            {
                isPrime = false;
            }

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
