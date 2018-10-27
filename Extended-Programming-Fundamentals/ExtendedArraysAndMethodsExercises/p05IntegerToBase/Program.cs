using System;

namespace p05IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int numBase = int.Parse(Console.ReadLine());

            string total = IntegerToBase(number, numBase);         

            Console.WriteLine(total);
        }

        static string IntegerToBase(long number, int numBase)
        {
            string total = string.Empty;

            total += number / numBase;
            total += number % numBase;

            return total;
        }
    }
}
