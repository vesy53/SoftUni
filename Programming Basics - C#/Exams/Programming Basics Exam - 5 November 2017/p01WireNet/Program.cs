using System;

namespace p01WireNet
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthM = double.Parse(Console.ReadLine());
            double widthM = double.Parse(Console.ReadLine());
            double heightM = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double weightSqMeter = double.Parse(Console.ReadLine());

            double totalLength = lengthM * 2 + widthM * 2;
            price *= totalLength;
            double area = totalLength * heightM;
            weightSqMeter *= area;

            Console.WriteLine(totalLength);
            Console.WriteLine($"{price:F2}");
            Console.WriteLine($"{weightSqMeter:F3}");
        }
    }
}
