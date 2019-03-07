using System;

namespace p02CircleAreaPrecision12
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double areaCircle = Math.PI * radius * radius;

            Console.WriteLine($"{areaCircle:F12}");
        }
    }
}
