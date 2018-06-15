using System;

namespace p01GrapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaVineyard = double.Parse(Console.ReadLine());
            double kgOfSquareMeter = double.Parse(Console.ReadLine());
            double marriage = double.Parse(Console.ReadLine());

            double total = (areaVineyard * kgOfSquareMeter) - marriage;
            double rakia = (total * 0.45) / 7.5;
            double priceRakia = rakia * 9.80;

            double sale = (total * 0.55) * 1.50;


            Console.WriteLine($"{priceRakia:F2}");
            Console.WriteLine($"{sale:F2}");
        }
    }
}
