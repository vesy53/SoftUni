using System;

namespace p02Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double numDays = double.Parse(Console.ReadLine());
            double kgFood = double.Parse(Console.ReadLine());
            double dogFoodKg = double.Parse(Console.ReadLine());
            double catFoodKg = double.Parse(Console.ReadLine());
            double turtleGr = double.Parse(Console.ReadLine());

            dogFoodKg *= numDays;
            catFoodKg *= numDays;
            turtleGr *= numDays;
            double turtleKg = turtleGr / 1000;
            double total = dogFoodKg + catFoodKg + turtleKg;

            if (total <=kgFood)
            {
                kgFood -= total;

                Console.WriteLine(
                    $"{Math.Floor(kgFood)} kilos of food left.");
            }
            else if (total  > kgFood)
            {
                total -= kgFood;

                Console.WriteLine(
                    $"{Math.Ceiling(total)} more kilos of food are needed.");
            }
        }
    }
}
