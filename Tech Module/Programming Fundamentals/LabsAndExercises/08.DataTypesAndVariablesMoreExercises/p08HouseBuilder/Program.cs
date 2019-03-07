using System;

namespace p08HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong priceS = ulong.Parse(Console.ReadLine());
            ulong priceI = ulong.Parse(Console.ReadLine());

            ulong minPrice = Math.Min(priceS, priceI);

            if (minPrice >= 0 && minPrice <= 127)
            {
                minPrice *= 4;
            }

            ulong maxPrice = Math.Max(priceS, priceI);

            if (maxPrice >= 128 && maxPrice <= 2147483647)
            {
                maxPrice *= 10;
            }

            ulong totalPrice = minPrice + maxPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
