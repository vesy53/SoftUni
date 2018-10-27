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
          
            double resultX = 0.0;
            double resultY = 0.0;

            for (int i = 0; i < text.Length; i += 2)
            {
                string command = text[i];
                int value = int.Parse(text[i + 1]);

                if (command.Equals("up"))
                {
                    resultY += value;
                }
                else if (command.Equals("down"))
                {
                    resultY -= value;
                }
                else if (command.Equals("left"))
                {
                    resultX -= value;
                }
                else if (command.Equals("right"))
                {
                    resultX += value;
                }
            }

            Console.WriteLine($"firing at [{resultX}, {resultY}]");

            if (resultX == coordinates[0] && resultY == coordinates[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }

            //second method
            /*if (resultX == coordinates.First() && resultY == coordinates.Last())
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }*/
        }
    }
}
