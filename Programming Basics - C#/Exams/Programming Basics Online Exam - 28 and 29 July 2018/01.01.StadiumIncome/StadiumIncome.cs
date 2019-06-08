namespace _01._01.StadiumIncome
{
    using System;

    class StadiumIncome
    {
        static void Main(string[] args)
        {
            double numsSectorOfStadium = double.Parse(Console.ReadLine());
            double capacityStadium = double.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());

            double amountForOneSector = (capacityStadium * priceTicket) / numsSectorOfStadium;
            double totalIncome = amountForOneSector * numsSectorOfStadium;
            double moneyForCharity = (totalIncome - (amountForOneSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:F2} BGN");
        }
    }
}
