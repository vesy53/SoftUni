using System;

namespace p07MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            double result = RaiseToPower(num, pow);

            Console.WriteLine(result);
        }

        static double RaiseToPower(double num, int pow)
        {
            return Math.Pow(num, pow);
        }
    }
}
