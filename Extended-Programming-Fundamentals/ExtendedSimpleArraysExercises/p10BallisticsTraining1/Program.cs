using System;
using System.Linq;

namespace p10BallisticsTraining1
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

            double xPoint = 0.0;
            double yPoint = 0.0;

            for (int i = 0; i < commands.Length - 1; i += 2)
            {
                string instruction = commands[i];
                double value = double.Parse(commands[i + 1]);

                if (instruction.Equals("up"))
                {
                    yPoint += value;
                }
                else if (instruction.Equals("down"))
                {
                    yPoint -= value;
                }
                else if (instruction.Equals("left"))
                {
                    xPoint -= value;
                }
                else if (instruction.Equals("right"))
                {
                    xPoint += value;
                }
            }

            Console.WriteLine($"firing at [{xPoint}, {yPoint}]");

            if (xPoint == coordinates.First() && yPoint == coordinates.Last())
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

