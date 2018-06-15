using System;

namespace ConsoleApp1
{
    class p01TrainingLab
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            height *= 100;
            double corridor = 100;
            double deskOfHeight = Math.Floor((height - corridor) / 70);
            width *= 100;
            double deskOfWidth = Math.Floor(width / 120);
            double total = (deskOfHeight * deskOfWidth) - 3;

            Console.WriteLine(total);
        }
    }
}
