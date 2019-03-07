using System;

namespace p05FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num <= 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                int result = FibonaciNumbers(num);

                Console.WriteLine(result);
            }
        }

        static int FibonaciNumbers(int num)
        {
            int fib1 = 1;
            int fib2 = 1;
                   
            for (int i = 2; i <= num; i++)
            {
                int sumFib = fib1 + fib2;
                fib1 = fib2;
                fib2 = sumFib;
            }
            
            return fib2;           
        }
    }
}
