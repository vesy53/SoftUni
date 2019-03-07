using System;

namespace p03RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = "";
            double priceHall = 0.0;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                priceHall = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                priceHall = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                priceHall = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            double discount = 0.0;
            double price = 0.0;

            if (package == "Normal")
            {
                price = 500;
                discount = 0.05;
            }
            else if (package == "Gold")
            {
                price = 750;
                discount = 0.10;
            }
            else if (package == "Platinum")
            {
                price = 1000;
                discount = 0.15;
            }

            double totalPrice = priceHall + price;
            double totalDisc = totalPrice - totalPrice * discount;
            double pricePerson = totalDisc / groupSize;

            Console.WriteLine($"We can offer you the {hallName}\r\n" +
                $"The price per person is {pricePerson:F2}$");
        }
    }
}
