using System;

namespace p03SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string valuation = Console.ReadLine();

            double price = 0.0;

            if (typeRoom == "room for one person")
            {
                price = (days - 1) * 18;              
            }
            else if (typeRoom == "apartment")
            {
                price = (days - 1) * 25;

                if (days < 10)
                {
                    price -= price * 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    price -= price * 0.35;
                }
                else if (days > 15)
                {
                    price -= price * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                price = (days - 1) * 35;

                if (days < 10)
                {
                    price -= price * 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    price -= price * 0.15;
                }
                else if (days > 15)
                {
                    price -= price * 0.2;
                }
            }

            if (valuation == "positive")
            {
                price += price * 0.25;
            }
            else if (valuation == "negative")
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
