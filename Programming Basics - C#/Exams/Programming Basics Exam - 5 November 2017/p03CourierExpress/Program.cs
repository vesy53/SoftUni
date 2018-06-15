using System;

namespace p03CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightKg = double.Parse(Console.ReadLine());
            string typeService = Console.ReadLine();
            double distanceKm = double.Parse(Console.ReadLine());

            double price = 0.0;
            double overcharge = 0.0;
            double totalDist = 0.0;

            if (typeService == "standard")
            {
                if (weightKg <= 1)
                {
                    price = 0.03;
                }
                else if (weightKg > 1 && weightKg <= 10)
                {
                    price = 0.05;
                }
                else if (weightKg >= 11 && weightKg <= 40)
                {
                    price = 0.10;
                }
                else if (weightKg >= 41 && weightKg <= 90)
                {
                    price = 0.15;
                }
                else if (weightKg >= 91 && weightKg <= 150)
                {
                    price = 0.20;
                }

                totalDist = distanceKm * price;
            }
            else if (typeService == "express")
            {
                if (weightKg <= 1)
                {
                    price = 0.03;
                    overcharge = 0.03 * 0.8;
                }
                else if (weightKg > 1 && weightKg <= 10)
                {
                    price = 0.05;
                    overcharge = 0.05 * 0.4;
                }
                else if (weightKg >= 11 && weightKg <= 40)
                {
                    price = 0.10;
                    overcharge = 0.10 * 0.05;
                }
                else if (weightKg >= 41 && weightKg <= 90)
                {
                    price = 0.15;
                    overcharge = 0.15 * 0.02;
                }
                else if (weightKg >= 91 && weightKg <= 150)
                {
                    price = 0.20;
                    overcharge = 0.20 * 0.01;
                }

                double total = distanceKm * price;
                double result = distanceKm * weightKg * overcharge;
                totalDist = total + result;
            }

            Console.WriteLine(
                $"The delivery of your shipment with weight of" +
                $" {weightKg:F3} kg. would cost {totalDist:F2} lv.");
        }
    }
}
