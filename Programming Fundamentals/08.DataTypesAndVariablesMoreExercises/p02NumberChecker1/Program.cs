using System;

namespace p02NumberChecker1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            if (num.Contains("."))
            {
                Console.WriteLine("floating-point");
            }
            else
            {
                Console.WriteLine("integer");
            }
        }
    }
}
