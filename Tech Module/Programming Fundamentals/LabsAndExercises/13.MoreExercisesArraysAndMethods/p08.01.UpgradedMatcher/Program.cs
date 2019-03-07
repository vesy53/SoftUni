using System;
using System.Collections.Generic;
using System.Linq;

namespace p08UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productNames = Console.ReadLine()
                .Split()
                .ToList();
            List<long> productQuantity = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            List<decimal> productPrice = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            string command = Console.ReadLine();
            long result = 0;

            while (command != "done")
            {
                List<string> newList = command
                    .Split()
                    .ToList();
                string currentCommand = newList[0];
                long quantity = long.Parse(newList[1]);

                int searchIndex = productNames.IndexOf(currentCommand);
                //another method
                //result = searchIndex < productQuantity.Count ? productQuantity[searchIndex] : 0;
                if (searchIndex < productQuantity.Count)
                {
                    result = productQuantity[searchIndex];
                }
                else
                {
                    result = 0;
                }

                if (result >= quantity)
                {
                    decimal price = quantity * productPrice[searchIndex];

                    Console.WriteLine(
                        $"{currentCommand} x {quantity} costs {price:F2}");

                    productQuantity[searchIndex] -= quantity;
                }
                else if (result < quantity)
                {
                    Console.WriteLine($"We do not have enough {currentCommand}");
                }

                command = Console.ReadLine();
            }
        }
    }
}
