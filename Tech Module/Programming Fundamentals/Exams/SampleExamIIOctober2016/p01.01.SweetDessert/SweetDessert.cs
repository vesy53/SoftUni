namespace p01._01.SweetDessert
{
    using System;

    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal amountCash = decimal.Parse(Console.ReadLine());
            decimal numGuest = decimal.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());

            decimal portions = Math.Ceiling(numGuest / 6);
            decimal neededBananas = portions * priceBananas * 2;
            decimal neededEggs = portions * priceEggs * 4;
            decimal neededBeries = portions * (priceBerries * 0.2m);

            decimal totalPrice = neededBananas + neededEggs + neededBeries;

            if (totalPrice <= amountCash)
            {
                Console.WriteLine(
                    $"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else if (totalPrice > amountCash)
            {
                totalPrice -= amountCash;

                Console.WriteLine(
                    $"Ivancho will have to withdraw money - he will need {totalPrice:F2}lv more.");
            }
        }
    }
}
