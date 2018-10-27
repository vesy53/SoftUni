using System;

namespace p04VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            int number = Convert.ToInt32(symbols, 16);

            Console.WriteLine(number);
        }
    }
}
