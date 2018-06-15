using System;

namespace p02Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            double areaHouse = double.Parse(Console.ReadLine());
            double numWindow = double.Parse(Console.ReadLine());
            double sqMInOnePackage = double.Parse(Console.ReadLine());
            double priceStyrofoam = double.Parse(Console.ReadLine());

            double totalArea = areaHouse - numWindow * 2.4;
            totalArea += totalArea * 0.1;
            double neededPackages = Math.Ceiling(totalArea / sqMInOnePackage);
            double pricePackages = neededPackages * priceStyrofoam;

            if (pricePackages <= boudget)
            {
                boudget -= pricePackages;

                Console.WriteLine($"Spent: {pricePackages:F2}\r\n" +
                    $"Left: {boudget:F2}");
            }
            else if (pricePackages > boudget)
            {
                pricePackages -= boudget;

                Console.WriteLine($"Need more: {pricePackages:F2}");
            }

        }
    }
}
