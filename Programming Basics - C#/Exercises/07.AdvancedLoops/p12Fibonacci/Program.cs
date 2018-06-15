using System;

namespace p12Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int fib0 = 1;
            int fib1 = 1;
            int totalFib = 0;

            for (int i = 2; i <= num; i++)
            {
                totalFib = fib0 + fib1;
                fib1 = fib0;
                fib0 = totalFib;
            }
       
            Console.WriteLine(fib0);
            
        }
    }
}
