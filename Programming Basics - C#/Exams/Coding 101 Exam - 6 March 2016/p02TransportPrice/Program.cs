using System;

namespace p02TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numKm = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0.0;
            double innerPrice = 0.0;

            if (numKm < 20)
            {
                innerPrice = 0.70;

                if (dayOrNight == "day")
                {
                    price = 0.79;
                }
                else if (dayOrNight == "night")
                {
                    price = 0.90;
                }
            }
            else if (numKm >= 20 && numKm < 100)
            {
                price = 0.09;
            }
            else if (numKm >= 100)
            {
                price = 0.06;
            }

            double totalPrice = innerPrice + numKm * price;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
