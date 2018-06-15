using System;

namespace p01Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialDoughGr = double.Parse(Console.ReadLine());
            double breadGr = double.Parse(Console.ReadLine());
            double priceBread = double.Parse(Console.ReadLine());
            double numBakedSold = double.Parse(Console.ReadLine());
            double numSweetsSold = double.Parse(Console.ReadLine());

            double incomeBread = numBakedSold * priceBread;
            double neededBread = numBakedSold * breadGr;
            double remain = initialDoughGr - neededBread;
            double sweetDough = remain + neededBread;
            double priceSweet = priceBread + priceBread * 0.25;
            double sweetGr = breadGr - breadGr * 0.2;
            double doughUsedSweets = numSweetsSold * sweetGr;
            double incomeSweet = numSweetsSold * priceSweet;
            double price = (neededBread / 1000 + sweetDough / 1000) * 4;
            double total = incomeBread + incomeSweet - price;
            double doughUsed = neededBread + doughUsedSweets;

            Console.WriteLine($"Pure income: {total:f2} lv.");
            Console.WriteLine($"Dough used: {Math.Ceiling(doughUsed)} g.");
        }
    }
}
