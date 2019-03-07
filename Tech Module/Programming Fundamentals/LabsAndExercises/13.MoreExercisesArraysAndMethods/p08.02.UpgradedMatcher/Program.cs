using System;
using System.Linq;

namespace p08UpgradedMatcher1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine()
                .Split();
            long[] productQuantity = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            decimal[] productPrice = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            string[] command = Console.ReadLine()
                .Split();

            long result = 0;

            while (command[0] != "done")
            {
                string currentCommand = command[0];
                long quantity = long.Parse(command[1]);

                int searchIndex = Array.IndexOf(productNames, currentCommand);

                try
                {
                    result = productQuantity[searchIndex];
                }
                catch (Exception)
                {
                    result = 0;
                }           

                if (result > 0)
                {
                    decimal price = quantity * productPrice[searchIndex];

                    Console.WriteLine(
                        $"{currentCommand} x {quantity} costs {price:F2}");

                    productQuantity[searchIndex] -= quantity;
                }
                else if (result <= 0)
                {
                    Console.WriteLine($"We do not have enough {currentCommand}");
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}

