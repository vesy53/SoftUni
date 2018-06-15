using System;

namespace p02FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int zymbuly = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double priceGift = double.Parse(Console.ReadLine());

            double priceMagnolia = 3.25 * magnolia;
            double priceZymbul = 4.0 * zymbuly;
            double priceRoses = 3.50 * roses;
            double priceCacti = 8.0 * cacti;

            double total = priceMagnolia + priceZymbul + priceRoses + priceCacti;
            double tax = total * 0.05;
            total -= tax;

            if (priceGift <= total)
            {
                total -= priceGift;

                Console.WriteLine(
                    $"She is left with {Math.Floor(total)} leva.");
            }
            else if (priceGift > total)
            {
                priceGift -= total;

                Console.WriteLine(
                    $"She will have to borrow {Math.Ceiling(priceGift)} leva.");
            }
        }
    }
}
