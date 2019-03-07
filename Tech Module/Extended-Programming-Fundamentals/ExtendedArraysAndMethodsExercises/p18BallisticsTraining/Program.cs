using System;
using System.Linq;

namespace p18BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordinates = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            string[] text = Console.ReadLine()
                .Split();

            double pointX = coordinates[0];
            double pointY = coordinates[1];
            double resultX = 0.0;
            double resultY = 0.0;

            for (int i = 0; i < text.Length; i += 2)
            {
                string command = text[i];
                int value = int.Parse(text[i + 1]);

                if (command == "up")
                {
                    resultY += value;
                }
                else if (command == "down")
                {
                    resultY -= value;
                }
                else if (command == "left")
                {
                    resultX -= value;
                }
                else if (command == "right")
                {
                    resultX += value;
                }
            }

            Console.WriteLine($"firing at [{resultX}, {resultY}]");

            if (pointX == resultX && pointY == resultY)
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
