using System;

namespace p04DwarfPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDwarfs = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());

            double price = 0.0;

            for (int i = 1; i <= numDwarfs; i++)
            {
                string typeGift = Console.ReadLine();

                if (typeGift == "sand clock")
                {
                    price += 2.20;
                }
                else if (typeGift == "magnet")
                {
                    price += 1.50;
                }
                else if (typeGift == "cup")
                {
                    price += 5;
                }
                else if (typeGift == "t-shirt")
                {
                    price += 10;
                }
            }

            if (price <= money)
            {
                money -= price;

                Console.WriteLine(
                    $"Santa Claus has {money:F2} more leva left!");
            }
            else if (price > money)
            {
                price -= money;

                Console.WriteLine(
                    $"Santa Claus will need {price:F2} more leva.");
            }
        }
    }
}
