using System;

namespace p03BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsBake = int.Parse(Console.ReadLine());
            int seniorsBake = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            double priseJuniors = 0.0;
            double priceSeniors = 0.0;

            if (route == "trail")
            {
                priseJuniors = 5.50;
                priceSeniors = 7;
            }
            else if (route == "cross-country")
            {
                priseJuniors = 8;
                priceSeniors = 9.50;

                if (juniorsBake + seniorsBake >= 50)
                {
                    priseJuniors -= priseJuniors * 0.25;
                    priceSeniors -= priceSeniors * 0.25;
                }
            }
            else if (route == "downhill")
            {
                priseJuniors = 12.25;
                priceSeniors = 13.75;
            }
            else if (route == "road")
            {
                priseJuniors = 20;
                priceSeniors = 21.50;
            }

            double totalPrice = juniorsBake * priseJuniors + seniorsBake * priceSeniors;
            double costs = totalPrice * 0.05;
            totalPrice -= costs;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
