using System;

namespace p02NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            double number = double.Parse(num);

            if (number % 1 == 0)
            {
                Console.WriteLine("integer");
            }
            else 
            {
                Console.WriteLine("floating-point");
            }           
        }
    }
}
