using System;

namespace p02ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double timeFather = double.Parse(Console.ReadLine());
        
            double total = 1 / (1 / first + 1 / second + 1 / third);   
            double result = total * 0.15;
            total += result;

            Console.WriteLine($"Cleaning time: {total:F2}");

            double diff = timeFather - total;

            if (diff >= 0)
            {
                Console.WriteLine(
                    $"Yes, there is a surprise - time left -> " +
                    $"{Math.Floor(diff)} hours.");
            }
            else
            {
                Console.WriteLine(
                    $"No, there isn't a surprise - shortage of time " +
                    $"-> {Math.Ceiling(Math.Abs(diff))} hours.");

               
            }
        }
    }
}
