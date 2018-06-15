using System;

namespace p03Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChrysant = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidays = Console.ReadLine();

            double priceChrysant = 0.0;
            double priceRoses = 0.0;
            double priceTulips = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                priceChrysant = 2;
                priceRoses = 4.10;
                priceTulips = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrysant = 3.75;
                priceRoses = 4.50;
                priceTulips = 4.15;
            }

            double total =
                numChrysant * priceChrysant + numRoses * priceRoses + numTulips * priceTulips;

            if (holidays == "Y")
            {
                total += total * 0.15;
            }

            if (season == "Spring" && numTulips > 7)
            {
                total -= total * 0.05;
            }

            if (season == "Winter" && numRoses >= 10)
            {
                total -= total * 0.1;
            }

            if (numChrysant + numRoses + numTulips > 20)
            {
                total -= total * 0.2;
            }

            total += 2;

            Console.WriteLine($"{total:F2}");
        }
    }
}
