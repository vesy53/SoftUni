using System;
using System.Linq;

namespace p07InventoryMatcher1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namesProducts = Console.ReadLine()
                .Split();
            long[] quantityProducts = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            decimal[] priceProducts = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "done")
            {
                int searchIndex = Array.IndexOf(namesProducts, command);
                long currentQuantity = quantityProducts[searchIndex];
                decimal currentPrice = priceProducts[searchIndex];

                Console.WriteLine(
                    $"{command} costs: {currentPrice}; Available quantity: {currentQuantity}");

                command = Console.ReadLine();
            }
        }
    }
}
