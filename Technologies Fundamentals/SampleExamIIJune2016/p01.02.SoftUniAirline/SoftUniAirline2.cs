namespace p01._02.SoftUniAirline
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniAirline2
    {
        static void Main(string[] args)
        {
            int numsFlights = int.Parse(Console.ReadLine());

            List<decimal> profits = new List<decimal>();

            for (int i = 0; i < numsFlights; i++)
            {
                decimal adulstCount = decimal.Parse(Console.ReadLine());
                decimal adultsTicketPrice = decimal.Parse(Console.ReadLine());
                decimal youngsCount = decimal.Parse(Console.ReadLine());
                decimal youngsTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPriceHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal income =
                    (adulstCount * adultsTicketPrice) + (youngsCount * youngsTicketPrice);
                decimal expenses = fuelPriceHour * fuelConsumptionHour * flightDuration;
                decimal profit = income - expenses;

                profits.Add(profit);

                if (income >= expenses)
                {
                    Console.WriteLine($"You are ahead with {profit:F3}$.");
                }
                else if (income < expenses)
                {
                    Console.WriteLine(
                        $"We've got to sell more tickets! We've lost {profit:F3}$.");
                }
            }

            Console.WriteLine($"Overall profit -> {profits.Sum():F3}$.");
            Console.WriteLine($"Average profit -> {profits.Average():F3}$.");
        }
    }
}
