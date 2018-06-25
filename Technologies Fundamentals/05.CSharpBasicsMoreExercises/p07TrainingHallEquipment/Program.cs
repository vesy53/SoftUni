using System;

namespace p07TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            int numOfItems = int.Parse(Console.ReadLine());

            double subtotal = 0.0;

            for (int i = 0; i < numOfItems; i++)
            {
                string nameItem = Console.ReadLine();
                double priceItem = double.Parse(Console.ReadLine());
                int countItem = int.Parse(Console.ReadLine());

                if (countItem > 1)
                {
                    nameItem += 's';
                }

                Console.WriteLine($"Adding {countItem} {nameItem} to cart.");

                subtotal += countItem * priceItem;
            }

            Console.WriteLine($"Subtotal: ${subtotal:F2}");

            if (boudget - subtotal >= 0)
            {
                Console.WriteLine($"Money left: ${boudget - subtotal:F2}");
            }
            else if (boudget - subtotal < 0)
            {
                Console.WriteLine(
                    $"Not enough. We need ${Math.Abs(boudget - subtotal):F2} more.");
            }
        }
    }
}
