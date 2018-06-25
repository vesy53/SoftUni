using System;

namespace p04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;
            }

            if (night > 7 && (month == "May" || month == "October"))
            {
                priceStudio *= 0.95;
            }
            else if (night > 14 && (month == "June" || month == "September"))
            {
                priceDouble *= 0.90;
            }
            else if (night > 14 && (month == "July" || month == "August" 
                || month == "December"))
            {
                priceSuite *= 0.85;
            }

            if (night > 7 && (month == "September" || month == "October"))
            {
                priceStudio *= (night - 1);
            }
            else
            {
                priceStudio *= night;

            }

            priceDouble *= night;
            priceSuite *= night;

            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
            Console.WriteLine($"Double: {priceDouble:F2} lv.");
            Console.WriteLine($"Suite: {priceSuite:F2} lv.");
        }
    }
}
