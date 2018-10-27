using System;

namespace p11OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                num = Math.Abs(num);

                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }

                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
