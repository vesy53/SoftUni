using System;

namespace p01Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenghtSm = double.Parse(Console.ReadLine());
            double widthSm = double.Parse(Console.ReadLine());
            double heightSm = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double total = lenghtSm * widthSm * heightSm;
            double totalLiters = total * 0.001;
            percentage *= 0.01;
            double result = totalLiters * (1 - percentage);

            Console.WriteLine($"{result:F3}");
        }
    }
}
