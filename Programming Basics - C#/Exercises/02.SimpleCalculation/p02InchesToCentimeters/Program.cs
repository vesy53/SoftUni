using System;

namespace p02InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inches = ");
            double inches = double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine("Centimeters = {0}", centimeters);
        }
    }
}
