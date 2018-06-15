using System;

namespace p01DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightM = double.Parse(Console.ReadLine());
            double widthM = double.Parse(Console.ReadLine());
            double sideWardrobeM = double.Parse(Console.ReadLine());

            double totalHall = (heightM * 100) * (widthM * 100);
            double wardrobe = (sideWardrobeM * 100) * (sideWardrobeM * 100);
            double bench = totalHall / 10;
            double freeSpace = totalHall - wardrobe - bench;
            double dancers = freeSpace / (40 + 7000);

            Console.WriteLine($"{Math.Floor(dancers)}");
        }
    }
}
