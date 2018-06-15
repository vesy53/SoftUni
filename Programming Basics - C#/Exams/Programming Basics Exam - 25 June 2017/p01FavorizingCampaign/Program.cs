using System;

namespace p01FavorizingCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int numCake = int.Parse(Console.ReadLine());
            int numWaffles = int.Parse(Console.ReadLine());
            int numPancake = int.Parse(Console.ReadLine());

            double priceCake = numCake * 45;
            double priceWaffers = numWaffles * 5.80;
            double pricePancake = numPancake * 3.20;
            double totalPrice = 
                (priceCake + priceWaffers + pricePancake) * confectioners;

            double totalSum = totalPrice * days;
            totalSum -= totalSum * 1 / 8;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
