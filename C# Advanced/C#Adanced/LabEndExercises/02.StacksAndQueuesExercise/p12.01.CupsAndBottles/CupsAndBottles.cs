namespace p12._01.CupsAndBottles
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

            Queue<int> cupsCapasity = new Queue<int>(cups);
            Stack<int> filledBottles = new Stack<int>(bottles);

            int wastedWother = 0;

            while (cupsCapasity.Count != 0 &&
                   filledBottles.Count != 0)
            {
                int currentCup = cupsCapasity.Dequeue();
                int currentBottle = filledBottles.Pop();

                if (currentCup <= currentBottle)
                {
                    wastedWother += currentBottle - currentCup;
                }
                else if (currentCup > currentBottle)
                {
                    currentCup -= currentBottle;

                    while (currentCup > 0)
                    {
                        currentCup -= filledBottles.Pop();
                    }

                    wastedWother += Math.Abs(currentCup);
                }
            }

            string result = cupsCapasity.Count == 0 ?
                $"Bottles: {string.Join(" ", filledBottles)}" :
                $"Cups: {string.Join(" ", cupsCapasity)}";

            Console.WriteLine(result);
            Console.WriteLine(
                $"Wasted litters of water: {wastedWother}");
        }
    }
}