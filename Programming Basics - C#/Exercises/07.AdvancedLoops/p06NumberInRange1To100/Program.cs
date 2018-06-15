using System;

namespace p06NumberInRange1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number in the range [1...100]: ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0 && num <= 100)
                {
                    Console.WriteLine($"The number is: {num}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
