using System;

namespace p04SieveOfEratosthenes2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool[] primes = new bool[num + 1];

            FindPrimesNums(primes);

            PrintPrimesNums(primes);

            Console.WriteLine();
        }

        static bool[] FindPrimesNums(bool[] primes)
        {
            for (int i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    for (int j = 2; j * i < primes.Length; j++)
                    {
                        primes[j * i] = false;
                    }
                }
            }

            return primes;
        }

        static void PrintPrimesNums(bool[] primes)
        {
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
