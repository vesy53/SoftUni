namespace p01._01.SweetDessert
{
    using System;

    class SweetDessert
    {
        static void Main(string[] args)
        {
            double boudget = double.Parse(Console.ReadLine());
            int numGuest = int.Parse(Console.ReadLine());
            double priceBananas = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerriesKg = double.Parse(Console.ReadLine());

            double sets = Math.Ceiling(numGuest / 6.0);

            double totalPrice = 
                sets * (2 * priceBananas) + sets * (4 * priceEggs) + sets * (0.2 * priceBerriesKg);

            if (totalPrice <= boudget)
            {
                Console.WriteLine(
                    $"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else if(totalPrice > boudget)
            {
                totalPrice -= boudget;

                Console.WriteLine(
                    $"Ivancho will have to withdraw money - he will need {totalPrice:F2}lv more.");
            }
        }
    }
}
