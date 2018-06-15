using System;

namespace p02Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double vineyard = double.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            double litersOfWineNeeded = double.Parse(Console.ReadLine());
            double numOfWorkers = double.Parse(Console.ReadLine());

            vineyard *= grapes;
            double wine = vineyard * 0.4 / 2.5;

            if (wine < litersOfWineNeeded)
            {
                litersOfWineNeeded -= wine;

                Console.WriteLine(
                    $"It will be a tough winter! More {Math.Floor(litersOfWineNeeded)} liters wine needed.");
            }
            else if (wine >= litersOfWineNeeded)
            {
                double totalWine = Math.Ceiling(wine - litersOfWineNeeded);
                double litersPerPerson = Math.Ceiling(totalWine / numOfWorkers);

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.\r\n" +
                    $"{totalWine} liters left -> {litersPerPerson} liters per person.");
            }
        }
    }
}
