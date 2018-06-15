using System;

namespace p01VegetableExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgVegetables= double.Parse(Console.ReadLine());
            double priceKgFruits = double.Parse(Console.ReadLine());
            double totalPriceVegetables= double.Parse(Console.ReadLine());
            double totalPriceFruits = double.Parse(Console.ReadLine());

            priceKgVegetables *= totalPriceVegetables;
            priceKgFruits *= totalPriceFruits;
            double total = (priceKgVegetables + priceKgFruits) / 1.94;

            Console.WriteLine(total);

        }
    }
}
