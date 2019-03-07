namespace p02._02.SoftUniWaterSupplies
{
    using System;
    using System.Linq;

    class SoftUniWaterSupplies2
    {
        static void Main(string[] args)
        {
            double totalWater = double.Parse(Console.ReadLine());
            double[] bottlesToFill = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double bottleCapacity = double.Parse(Console.ReadLine());

            int endIndex = -1;
            bool hasWater = true;
            double leftWater = totalWater;

            if ((int)totalWater % 2 != 0)
            {
                Array.Reverse(bottlesToFill);
            }

            for (int i = 0; i < bottlesToFill.Length; i++)
            {
                leftWater -= bottleCapacity - bottlesToFill[i];

                if (leftWater < 0 && hasWater)
                {
                    endIndex = i;
                    hasWater = false;
                }
            }

            if (leftWater < 0)
            {
                Console.WriteLine("We need more water!");

                endIndex = totalWater % 2 == 0 ? 
                    endIndex : 
                    bottlesToFill.Length - 1 - endIndex;
                int leftBottle = totalWater % 2 == 0 ?
                    bottlesToFill.Length - endIndex : 
                    endIndex + 1;

                Console.WriteLine($"Bottles left: {leftBottle}");
                Console.Write($"With indexes: ");

                for (int i = 0; i < leftBottle; i++)
                {
                    if (i == leftBottle - 1)
                    {
                        Console.WriteLine(endIndex);
                    }
                    else
                    {
                        Console.Write(endIndex + ", ");

                        if (totalWater % 2 == 0)
                        {
                            endIndex++;
                        }
                        else
                        {
                            endIndex--;
                        }
                    }
                }

                Console.WriteLine(
                    $"We need {Math.Abs(leftWater)} more liters!");
            }
            else
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {leftWater}l.");
            }
        }
    }
}
