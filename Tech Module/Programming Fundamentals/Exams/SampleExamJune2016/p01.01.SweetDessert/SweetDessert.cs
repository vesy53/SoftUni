namespace p01._01.SweetDessert
{
    using System;

    class SweetDessert
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int numGuest = int.Parse(Console.ReadLine());
            double priceBananas = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerries = double.Parse(Console.ReadLine());

            double portitions = Math.Ceiling(numGuest / 6.0);

            double sumBananas = portitions * (2 * priceBananas);
            double sumEggs = portitions * (4 * priceEggs);
            double sumBerries = portitions * (0.2 * priceBerries);

            double totalSum = sumBananas + sumEggs + sumBerries;

            if (totalSum <= cash)
            {
                Console.WriteLine(
                    $"Ivancho has enough money - it would cost {totalSum:F2}lv.");
            }
            else if (totalSum > cash)
            {
                totalSum -= cash;

                Console.WriteLine(
                    $"Ivancho will have to withdraw money - he will need {totalSum:F2}lv more.");
            }
        }
    }
}
