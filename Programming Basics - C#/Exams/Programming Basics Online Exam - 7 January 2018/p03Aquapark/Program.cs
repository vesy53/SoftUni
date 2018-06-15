using System;

namespace p03Aquapark1
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int hours = int.Parse(Console.ReadLine());
            int numPersonGrour = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine().ToLower();

            double price = 0.0;          

            if (month == "march" || month == "april"
                || month == "may")
            {
                if (dayOrNight == "day")
                {
                    price = 10.50;
                }
                else if (dayOrNight == "night")
                {
                    price = 8.40;
                }
            }
            else if (month == "june" || month == "july"
                || month == "august")
            {
                if (dayOrNight == "day")
                {
                    price = 12.60;
                }
                else if (dayOrNight == "night")
                {
                    price = 10.20;
                }
            }

            if (numPersonGrour >= 4)
            {
                price -= price * 0.1;
            }

            if (hours >= 5)
            {
                price -= price * 0.5;
            }

            double total = price * hours * numPersonGrour;

            Console.WriteLine(
                $"Price per person for one hour: {price:F2}");
            Console.WriteLine(
                $"Total cost of the visit: {total:F2}");
        }
    }
}
