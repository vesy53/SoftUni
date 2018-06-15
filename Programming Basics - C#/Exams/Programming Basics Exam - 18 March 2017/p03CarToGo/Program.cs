using System;

namespace p03CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string classCar = "";
            double price = 0.0;
            string car = "";

            if (boudget <= 100)
            {
                classCar = "Economy class";

                if (season == "Summer")
                {
                    car = "Cabrio";
                    price = boudget * 0.35;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    price = boudget * 0.65;
                }
            }
            else if (boudget > 100 && boudget <= 500)
            {
                classCar = "Compact class";

                if (season == "Summer")
                {
                    car = "Cabrio";
                    price = boudget * 0.45;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    price = boudget * 0.8;
                }
            }
            else if (boudget > 500)
            {
                classCar = "Luxury class";

                if (season == "Summer" || season == "Winter")
                {
                    car = "Jeep";
                    price = boudget * 0.9;
                }
            }

            Console.WriteLine(classCar);
            Console.WriteLine($"{car} - {price:F2}");
        }
    }
}
