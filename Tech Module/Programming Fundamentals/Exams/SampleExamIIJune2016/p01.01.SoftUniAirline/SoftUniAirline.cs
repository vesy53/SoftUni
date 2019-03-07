namespace p01._01.SoftUniAirline
{
    using System;

    class SoftUniAirline
    {
        static void Main(string[] args)
        {
            int numFlights = int.Parse(Console.ReadLine());

            decimal overallProfit = 0.0m;

            for (int i = 0; i < numFlights; i++)
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
                overallProfit += income - expenses;
                income -= expenses;

                if (income >= expenses)
                {
                    Console.WriteLine($"You are ahead with {income:F3}$.");
                }
                else if (income < expenses)
                {
                    Console.WriteLine(
                        $"We've got to sell more tickets! We've lost {income:F3}$.");
                }
            }

            decimal average = overallProfit / numFlights;

            Console.WriteLine($"Overall profit -> {overallProfit:F3}$.");
            Console.WriteLine($"Average profit -> {average:F3}$.");
        }
    }
}
