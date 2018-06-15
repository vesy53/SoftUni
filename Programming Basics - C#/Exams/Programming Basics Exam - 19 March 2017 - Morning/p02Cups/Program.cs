using System;

namespace p02Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededCups = double.Parse(Console.ReadLine());
            double worker = double.Parse(Console.ReadLine());
            double workDay = double.Parse(Console.ReadLine());

            double totalHours = worker * workDay * 8;
            double workCups = Math.Floor(totalHours / 5);
            double price = 0.0;

            if (workCups <= neededCups)
            {
                neededCups -= workCups;
                price = neededCups * 4.2;

                Console.WriteLine($"Losses: {price:F2}");
            }
            else if (workCups > neededCups)
            {
                workCups -= neededCups;
                price = workCups * 4.2;

                Console.WriteLine($"{price:F2} extra money");
            }
        }
    }
}
