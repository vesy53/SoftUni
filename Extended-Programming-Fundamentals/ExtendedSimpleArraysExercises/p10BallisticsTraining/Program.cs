using System;
using System.Linq;

namespace p10BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordinates = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            string[] commands = Console.ReadLine()
                .Split();

            double pointX = coordinates[0];
            double pointY = coordinates[1];
            double xPoint = 0.0;
            double yPoint = 0.0;

            for (int i = 0; i < commands.Length - 1; i += 2)
            {
                string instruction = commands[i];
                double value = double.Parse(commands[i + 1]);

                if (instruction == "up")
                {
                    yPoint += value;
                }
                else if (instruction == "down")
                {
                    yPoint -= value;
                }
                else if (instruction == "left")
                {
                    xPoint -= value;
                }
                else if (instruction == "right")
                {
                    xPoint += value;
                }
            }

            Console.WriteLine($"firing at [{xPoint}, {yPoint}]");

            if (xPoint == pointX && yPoint == pointY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
