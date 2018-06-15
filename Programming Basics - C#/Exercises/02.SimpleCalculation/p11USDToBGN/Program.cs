using System;

namespace p11USDToBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double dollar = double.Parse(Console.ReadLine());

            double levs = dollar * 1.79549;

            Console.WriteLine($"{levs:F2} BGN");
        }
    }
}
