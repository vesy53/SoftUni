namespace p12._02.CupsAndBottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CupsAndBottles
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottles = Console.ReadLine()
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> cupsCapasity = new Stack<int>();
            Stack<int> filledBottles = new Stack<int>(bottles);

            int wastedWater = 0;

            for (int i = cups.Length - 1; i >= 0; i--)
            {
                cupsCapasity.Push(cups[i]);
            }

            while (cupsCapasity.Count != 0 && 
                   filledBottles.Count != 0)
            {
                int currentCup = cupsCapasity.Pop();
                int currentBottle = filledBottles.Pop();

                if (currentBottle >= currentCup)
                {
                    wastedWater += currentBottle - currentCup;
                }
                else
                {
                    currentCup -= currentBottle;
                    cupsCapasity.Push(currentCup);
                }
            }

            string result = cupsCapasity.Count == 0 ?
                $"Bottles: {string.Join(" ", filledBottles)}" :
                $"Cups: {string.Join(" ", cupsCapasity)}";

            Console.WriteLine(result);
            Console.WriteLine(
                $"Wasted litters of water: {wastedWater}");
        }
    }
}
