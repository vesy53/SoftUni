using System;

namespace p03FinalCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            double dancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double cashPrize = dancers * points;
            double moneyCosts = 0.0;

            if (season == "summer")
            {
                if (place == "Bulgaria")
                {
                    moneyCosts = cashPrize - cashPrize * 0.05;
                }
                else if (place == "Abroad")
                {
                    cashPrize += cashPrize * 0.5;
                    moneyCosts = cashPrize - cashPrize * 0.1;
                }
            }
            else if (season == "winter")
            {              
                if (place == "Bulgaria")
                {
                    moneyCosts = cashPrize - cashPrize * 0.08; 
                }
                else if (place == "Abroad")
                {
                    cashPrize += cashPrize * 0.5;
                    moneyCosts = cashPrize - cashPrize * 0.15;
                }
            }

            double moneyCharity = moneyCosts * 0.75;
            double total = moneyCosts - moneyCharity;
            double moneyDancer = total / dancers;

            Console.WriteLine($"Charity - {moneyCharity:F2}");
            Console.WriteLine($"Money per dancer - {moneyDancer:F2}");
        }
    }
}
