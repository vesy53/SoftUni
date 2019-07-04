namespace p01._01.SpaceshipCrafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SpaceshipCrafting
    {
        static void Main(string[] args)
        { 
            var countData = new Dictionary<string, int>
            {
                { "Aluminium", 0 },
                { "Carbon fiber", 0 },
                { "Glass", 0 },
                { "Lithium", 0 }
            };

            int[] chemicalLiquids = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] physicalItems = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueLiquids = new Queue<int>(chemicalLiquids);
            Stack<int> stackPhysicalItems = new Stack<int>(physicalItems);

            while (queueLiquids.Count() != 0 &&
                stackPhysicalItems.Count() != 0)
            {
                int currentItem = stackPhysicalItems.Peek();
                int sum = queueLiquids.Dequeue() + stackPhysicalItems.Pop();

                if (sum == 25)
                {
                    countData["Glass"]++;
                }
                else if (sum == 50)
                {
                    countData["Aluminium"]++;
                }
                else if (sum == 75)
                {
                    countData["Lithium"]++;
                }
                else if (sum == 100)
                {
                    countData["Carbon fiber"]++;
                }
                else
                {
                    stackPhysicalItems.Push(currentItem + 3);
                }
            }

            if (countData["Glass"] >= 1 &&
                countData["Aluminium"] >= 1 &&
                countData["Lithium"] >= 1 &&
                countData["Carbon fiber"] >= 1)
            {
                Console.WriteLine(
                    "Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine(
                    "Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (queueLiquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine(
                    $"Liquids left: {string.Join(", ", queueLiquids)}");
            }

            if (stackPhysicalItems.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine(
                    $"Physical items left: {string.Join(", ", stackPhysicalItems)}");
            }

            foreach (var item in countData)
            {
                string element = item.Key;
                int count = item.Value;

                Console.WriteLine($"{element}: {count}");
            }
        }
    }
}
