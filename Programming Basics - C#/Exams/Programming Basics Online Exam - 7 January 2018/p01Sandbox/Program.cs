using System;

namespace p01Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            double widthSite = double.Parse(Console.ReadLine());
            double lengthSite = double.Parse(Console.ReadLine());
            double priceKgSand = double.Parse(Console.ReadLine());
            double priceBoard = double.Parse(Console.ReadLine());

            double totalSite = widthSite * lengthSite;
            double areaSandbox = (widthSite - (0.2 + 0.2)) * (lengthSite - (0.2 + 0.2));
            double curbArea = totalSite - areaSandbox;
            double neededSand = Math.Ceiling(areaSandbox * 20);
            double neededBoard = Math.Ceiling(curbArea / (2.2 * 0.2));
            priceKgSand *= neededSand;
            priceBoard *= neededBoard;
            double sum = priceKgSand + priceBoard;

            Console.WriteLine($"{sum:F2}");
        }
    }
}
