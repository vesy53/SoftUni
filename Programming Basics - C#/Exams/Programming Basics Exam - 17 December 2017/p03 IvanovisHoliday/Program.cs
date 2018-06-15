using System;

namespace p03_IvanovisHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNight = int.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transport = Console.ReadLine();

            double priceAdults = 0.0;
            double priceChildren = 0.0;

            if (destination == "Miami")
            {
                if (numNight >= 1 && numNight <= 10)
                {
                    priceAdults = 24.99;
                    priceChildren = 14.99;
                }
                else if (numNight >= 11 && numNight <= 15)
                {
                    priceAdults = 22.99;
                    priceChildren = 11.99;
                }
                else if (numNight > 15)
                {
                    priceAdults = 20;
                    priceChildren = 10;
                }
            }
            else if (destination == "Canary Islands")
            {
                if (numNight >= 1 && numNight <= 10)
                {
                    priceAdults = 32.50;
                    priceChildren = 28.50;
                }
                else if (numNight >= 11 && numNight <= 15)
                {
                    priceAdults = 30.50;
                    priceChildren = 25.60;
                }
                else if (numNight > 15)
                {
                    priceAdults = 28;
                    priceChildren = 22;
                }
            }
            else if (destination == "Philippines")
            {
                if (numNight >= 1 && numNight <= 10)
                {
                    priceAdults = 42.99;
                    priceChildren = 39.99;
                }
                else if (numNight >= 11 && numNight <= 15)
                {
                    priceAdults = 41;
                    priceChildren = 36;
                }
                else if (numNight > 15)
                {
                    priceAdults = 38.50;
                    priceChildren = 32.40;
                }
            }

            double total = numNight * (2 * priceAdults + 3 * priceChildren);
            total += total * 0.25;
            double transportAdults = 0.0;
            double transportChildren = 0.0;

            if (transport == "train")
            {
                transportAdults = 22.30;
                transportChildren = 12.50;
            }
            else if (transport == "bus")
            {
                transportAdults = 45;
                transportChildren = 37;
            }
            else if (transport == "airplane")
            {
                transportAdults = 90;
                transportChildren = 68.50;
            }

            double totalTransports = 2 * transportAdults + 3 * transportChildren;
            double totalPrice = total + totalTransports;

            Console.WriteLine($"{totalPrice:F3}");
        }
    }
}
