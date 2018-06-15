using System;

namespace p01AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double quantityBeer = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityRakia = double.Parse(Console.ReadLine());
            double quantityeWhiskey = double.Parse(Console.ReadLine());

            double priceRakia = priceWhiskey / 2;
            double priceWine = priceRakia - priceRakia * 0.4;
            double priceBeer = priceRakia - priceRakia * 0.8;
            double sumRakia = priceRakia * quantityRakia;
            double sumWine = priceWine * quantityWine;
            double sumBeer = priceBeer * quantityBeer;
            double sumWhisky = priceWhiskey * quantityeWhiskey;
            double total = sumRakia + sumWine + sumBeer + sumWhisky;

            Console.WriteLine($"{total:F2}");
        }
    }
}
