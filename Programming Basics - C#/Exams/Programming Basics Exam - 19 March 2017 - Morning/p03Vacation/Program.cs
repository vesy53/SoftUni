using System;

namespace p03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string accommodation = "";
            string location = "";
            double price = 0.0;

            if (boudget <= 1000)
            {
                accommodation = "Camp";

                if (season == "Summer")
                {
                    location = "Alaska";
                    price = boudget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = boudget * 0.45;
                }
            }
            else if (boudget > 1000 && boudget <= 3000)
            {
                accommodation = "Hut";

                if (season == "Summer")
                {
                    location = "Alaska";
                    price = boudget * 0.8;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = boudget * 0.6;
                }
            }
            else if (boudget > 3000)
            {
                accommodation = "Hotel";

                if (season == "Summer")
                {
                    location = "Alaska";
                    price = boudget * 0.9;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = boudget * 0.9;
                }
            }

            Console.WriteLine(
                $"{location} - {accommodation} - {price:F2}");
        }
    }
}
