using System;

namespace p04FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            double capacityStadium = double.Parse(Console.ReadLine());
            double numFans = double.Parse(Console.ReadLine());

            double counterA = 0.0;
            double counterB = 0.0;
            double counterV = 0.0;
            double counterG = 0.0;

            for (int i = 0; i < numFans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    counterA++;
                }
                else if (sector == "B")
                {
                    counterB++;
                }
                else if (sector == "V")
                {
                    counterV++;
                }
                else if (sector == "G")
                {
                    counterG++;
                }
            }

            Console.WriteLine($"{counterA / numFans * 100:F2}%");
            Console.WriteLine($"{counterB / numFans * 100:F2}%");
            Console.WriteLine($"{counterV / numFans * 100:F2}%");
            Console.WriteLine($"{counterG / numFans * 100:F2}%");
            Console.WriteLine($"{numFans / capacityStadium * 100:F2}%");
        }
    }
}
