using System;

namespace _01._02.TripToWorldCup
{
    class TripToWorldCup
    {
        static void Main(string[] args)
        {
            double ticketToGo = double.Parse(Console.ReadLine());
            double ticketReturn = double.Parse(Console.ReadLine());
            double ticketForOneMatch = double.Parse(Console.ReadLine());
            int numberMatch = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            double priceTravel = 6 * (ticketToGo + ticketReturn);
            double totalPriceTravel = priceTravel - ((priceTravel * discountPercentage) / 100);
            double sumTicketMatch = 6 * numberMatch * ticketForOneMatch;
            double totalPrice = totalPriceTravel + sumTicketMatch;
            double sumForOnePerson = totalPrice / 6;

            Console.WriteLine($"Total sum: {totalPrice:F2} lv.");
            Console.WriteLine($"Each friend has to pay {sumForOnePerson:F2} lv.");
        }
    }
}
