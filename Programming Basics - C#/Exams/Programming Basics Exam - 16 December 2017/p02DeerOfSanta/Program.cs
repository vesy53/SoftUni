using System;

namespace p02DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double foodForFirstDeer = double.Parse(Console.ReadLine());
            double foodForSecDeer = double.Parse(Console.ReadLine());
            double foodForThirdDeer = double.Parse(Console.ReadLine());

            foodForFirstDeer *= days;
            foodForSecDeer *= days;
            foodForThirdDeer *= days;
            double total = foodForFirstDeer + foodForSecDeer + foodForThirdDeer;

            if (total <= food)
            {
                food -= total;

                Console.WriteLine($"{Math.Floor(food)} kilos of food left.");
            }
            else if (total > food)
            {
                total -= food;

                Console.WriteLine($"{Math.Ceiling(total)} more kilos of food are needed.");
            }
        }
    }
}
