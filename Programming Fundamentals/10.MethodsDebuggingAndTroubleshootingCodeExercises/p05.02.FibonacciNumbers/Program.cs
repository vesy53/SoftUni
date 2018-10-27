using System;
using System.Collections.Generic;

namespace p05FibonacciNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int result = FibonacciNumbers(num);

            Console.WriteLine(result);
        }

        static int FibonacciNumbers(int num)
        {
            List<int> fibList = new List<int>();

            fibList.Add(1);
            fibList.Add(1);

            for (int i = 2; i <= num; i++)
            {
                fibList.Add(fibList[i - 1] + fibList[i - 2]);
            }

            return fibList[fibList.Count - 1];
        }
    }
}
