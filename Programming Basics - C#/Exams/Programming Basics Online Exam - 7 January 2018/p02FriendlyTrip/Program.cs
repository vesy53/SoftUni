using System;

namespace p02FriendlyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceKm = double.Parse(Console.ReadLine());
            double costCar100Km = double.Parse(Console.ReadLine());
            double priceForLiter = double.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());

            double costCar = distanceKm * costCar100Km / 100;
            double totalCost = costCar * priceForLiter;
            double total = Math.Abs(totalCost - sum);

            if (sum < totalCost)
            {
                sum /= 5;

                Console.WriteLine(
                    $"Sorry, you cannot take a trip. Each will receive {sum:f2} money.");
            }
            else if (sum >= totalCost)
            {
                Console.WriteLine(
                    $"You can take a trip. {total:F2} money left.");
            }

        }
    }
}
