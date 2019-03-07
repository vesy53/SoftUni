namespace p02._01.SoftUniWaterSupplies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftUniWaterSupplies
    {
        static void Main(string[] args)
        {
            double totalWater = double.Parse(Console.ReadLine());
            List<double> bottles = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            double capasity = double.Parse(Console.ReadLine());

            List<double> emptyBottle = new List<double>();

            if (totalWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Count; i++)
                {
                    double currCapasity = capasity;

                    if (bottles[i] < capasity)
                    {
                        currCapasity -= bottles[i];
                        totalWater -= currCapasity;

                        if (totalWater < 0)
                        {
                            emptyBottle.Add(i);
                        }
                    }
                }
            }
            else if (totalWater % 2 != 0)
            {
                for (int i = bottles.Count - 1; i >= 0; i--)
                {
                    double currCapasity = capasity;

                    if (bottles[i] < capasity)
                    {
                        currCapasity -= bottles[i];
                        totalWater -= currCapasity;

                        if (totalWater < 0)
                        {
                            emptyBottle.Add(i);
                        }
                    }
                }
            }

            if (totalWater >= 0)
            {
                Console.WriteLine(
                    $"Enough water!\r\nWater left: {totalWater}l.");
            }
            else
            {
                Console.WriteLine($"We need more water!");
                Console.WriteLine($"Bottles left: {emptyBottle.Count()}");
                Console.WriteLine(
                    $"With indexes: {string.Join(", ", emptyBottle)}");
                Console.WriteLine(
                    $"We need {Math.Abs(totalWater)} more liters!");
            }
        }
    }
}
