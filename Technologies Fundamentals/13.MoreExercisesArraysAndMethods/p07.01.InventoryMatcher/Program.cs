using System;
using System.Linq;

namespace p07InventoryMatcher
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
                for (int i = 0; i < namesProducts.Length; i++)
                {
                    if (command == namesProducts[i])
                    {
                        Console.WriteLine(
                            $"{namesProducts[i]} costs: {priceProducts[i]}; Available quantity: {quantityProducts[i]}");
                        break;
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
