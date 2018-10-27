using System;

namespace p02SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintSign(num);
        }

        static void PrintSign(int num)
        {
            if (num < 0)
            {
                Console.WriteLine(
                    $"The number {num} is negative.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
