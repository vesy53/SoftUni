using System;

namespace p04NumbersInReversedOrder2
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            ReversedNumber(number);
        }

        static void ReversedNumber(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }

            Console.WriteLine();
        }
    }
}
