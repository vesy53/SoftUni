using System;

namespace p03MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numOfPerson = int.Parse(Console.ReadLine());

            double transportPrice = 0.0;

            if (numOfPerson >= 1 && numOfPerson <= 4)
            {
                transportPrice = boudget * 0.75;
            }
            else if (numOfPerson >= 5 && numOfPerson <= 9)
            {
                transportPrice = boudget * 0.6;
            }
            else if (numOfPerson >= 10 && numOfPerson <= 24)
            {
                transportPrice = boudget * 0.5;
            }
            else if (numOfPerson >= 25 && numOfPerson <= 49)
            {
                transportPrice = boudget * 0.4;
            }
            else if (numOfPerson >= 50)
            {
                transportPrice = boudget * 0.25;
            }

            double total = boudget - transportPrice;
            double price = 0.0;

            if (category == "Normal")
            {
                price = 249.99;
            }
            else if (category == "VIP")
            {
                price = 499.99;
            }

            double totalPrice = price * numOfPerson;

            if (totalPrice < total)
            {
                total -= totalPrice;

                Console.WriteLine(
                    $"Yes! You have {total:F2} leva left.");
            }
            else if(totalPrice >= total)
            {
                totalPrice -= total;

                Console.WriteLine(
                    $"Not enough money! You need {totalPrice:F2} leva.");
            }
        }
    }
}
