using System;

namespace p04SieveOfEratosthenes1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool[] primes = new bool[num + 1];

            for (int i = 2; i <= num; i++)
            {
                primes[i] = true;
            }

            for (int i = 2; i <= num; i++)
            {
                if (primes[i])
                {
                    for (int j = 2; j * i <= num; j++)
                    {
                        primes[j * i] = false;
                    }

                }
            }

            for (int i = 2; i <= num; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
