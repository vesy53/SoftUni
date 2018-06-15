using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "";

            if (boudget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    boudget *= 0.3;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    boudget *= 0.7;
                    place = "Hotel";
                }
            }
            else if (boudget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (season == "summer")
                {
                    boudget *= 0.4;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    boudget *= 0.8;
                    place = "Hotel";
                }
            }
            else if (boudget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");

                boudget *= 0.9;
                place = "Hotel";
            }

            Console.WriteLine($"{place} - {boudget:F2}");
        }
    }
}
