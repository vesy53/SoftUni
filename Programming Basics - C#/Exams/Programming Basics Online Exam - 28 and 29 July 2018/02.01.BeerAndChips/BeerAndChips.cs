namespace _02._01.BeerAndChips
{
    using System;

    class BeerAndChips
    {
        static void Main(string[] args)
        {
            string fansName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numBeers = int.Parse(Console.ReadLine());
            int numCheeps = int.Parse(Console.ReadLine());

            double totalPriceBeers = 1.20 * numBeers;
            double sumOneCheep = totalPriceBeers * 0.45;
            double totalCheeps = Math.Ceiling(sumOneCheep * numCheeps);

            double totalPrice = totalPriceBeers + totalCheeps;

            if (totalPrice <= budget)
            {
                budget -= totalPrice;

                Console.WriteLine(
                    $"{fansName} bought a snack and has {budget:F2} leva left.");
            }
            else if (totalPrice > budget)
            {
                totalPrice -= budget;

                Console.WriteLine($"{fansName} needs {totalPrice:F2} more leva!");
            }
        }
    }
}
