using System;

namespace p03TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (kmPerMonth <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.75;
                }
                else if (season == "Summer")
                {
                    price = 0.9;
                }
                else if (season == "Winter")
                {
                    price = 1.05;
                }
            }
            else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.95;
                }
                else if (season == "Summer")
                {
                    price = 1.10;
                }
                else if (season == "Winter")
                {
                    price = 1.25;
                }
            }
            else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                if (season == "Spring" || season == "Summer" 
                    || season == "Autumn" || season == "Winter")
                {
                    price = 1.45;
                }
            }

            double salary = (kmPerMonth * price) * 4;
            double total = salary - salary * 0.1;

            Console.WriteLine($"{total:F2}");
        }
    }
}
