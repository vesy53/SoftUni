using System;

namespace p03HotelRoom2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNight = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if (numNight > 14)
                {
                    priceStudio -= priceStudio * 0.3;
                    priceApartment -= priceApartment * 0.1;
                }
                else if (numNight > 7)
                {
                    priceStudio -= priceStudio * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;

                if (numNight > 14)
                {
                    priceStudio -= priceStudio * 0.2;
                    priceApartment -= priceApartment * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;

                if (numNight > 14)
                {
                    priceApartment -= priceApartment * 0.1;
                }
            }

            double totalPriceStudio = priceStudio * numNight;
            double totalPriceApartment = priceApartment * numNight;

            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
