using System;

namespace p03HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double numNight = double.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApartment = 65;

                    if (numNight > 14)
                    {
                        priceStudio -= 50 * 0.3;
                        priceApartment -= 65 * 0.1;
                    }
                    else if (numNight > 7)
                    {
                        priceStudio -= 50 * 0.05;
                    }
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartment = 68.70;

                    if (numNight > 14)
                    {
                        priceStudio -= 75.20 * 0.2;
                        priceApartment -= 68.70 * 0.1;
                    }
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceApartment = 77;

                    if (numNight > 14)
                    {
                        priceApartment -= 77 * 0.1;
                    }
                    break;
            }

            double totalPriceStudio = priceStudio * numNight;
            double totalPriceApartment = priceApartment * numNight;

            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
