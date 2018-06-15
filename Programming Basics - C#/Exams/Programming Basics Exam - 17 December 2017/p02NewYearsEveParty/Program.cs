using System;

namespace p02NewYearsEveParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double numGuests = double.Parse(Console.ReadLine());
            double boudget = double.Parse(Console.ReadLine());

            numGuests *= 20;

            if (numGuests <= boudget)
            {
                boudget -= numGuests;
                double moneyFireworks = Math.Ceiling(boudget * 0.4);
                double moneyDonation = Math.Ceiling(boudget - moneyFireworks);

                Console.WriteLine(
                    $"Yes! {moneyFireworks} lv are for fireworks " +
                    $"and {moneyDonation} lv are for donation.");
            }
            else if (numGuests > boudget)
            {
                numGuests -= boudget;

                Console.WriteLine(
                    $"They won't have enough money to pay the covert." +
                    $" They will need {Math.Ceiling(numGuests)} lv more.");
            }
        }
    }
}
