using System;

namespace p02AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
        }
    }
}
