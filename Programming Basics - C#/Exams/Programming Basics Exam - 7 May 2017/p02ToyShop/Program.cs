using System;

namespace p02ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numTeddyBeers = int.Parse(Console.ReadLine());
            int numMillion = int.Parse(Console.ReadLine());
            int numTruck = int.Parse(Console.ReadLine());

            double pricePuzzle = 2.6 * numPuzzles;
            double priceDolls = 3 * numDolls;
            double priceTeddyBeers = 4.1 * numTeddyBeers;
            double priceMillion = 8.2 * numMillion;
            double priceTruck = 2 * numTruck;
            double totalPrice =
                pricePuzzle + priceDolls + priceTeddyBeers + priceTruck + priceMillion;

            double totalNumToys =
                numPuzzles + numDolls + numTeddyBeers + numMillion + numTruck;

            if (totalNumToys >= 50)
            {
                totalPrice -= totalPrice * 0.25;
            }

            totalPrice -= totalPrice * 0.1;

            if (totalPrice < priceExcursion)
            {
                priceExcursion -= totalPrice;

                Console.WriteLine(
                    $"Not enough money! {priceExcursion:F2} lv needed.");
            }
            else if (totalPrice >= priceExcursion)
            {
                totalPrice -= priceExcursion;

                Console.WriteLine(
                    $"Yes! {totalPrice:F2} lv left.");
            }
        }
    }
}
