namespace p01._02.SpaceshipCrafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SpaceshipCrafting
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<int, string>
            {
                { 50, "Aluminium" },
                { 100, "Carbon fiber" },
                { 25, "Glass" },
                { 75, "Lithium" }
            };

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

            while (queueLiquids.Any() &&
                   stackPhysicalItems.Any())
            {
                int currentItem = stackPhysicalItems.Peek();
                int sum = queueLiquids.Dequeue() + stackPhysicalItems.Pop();

                if (data.ContainsKey(sum))
                {
                    string element = data[sum];

                    countData[element]++;
                }
                else
                {
                    stackPhysicalItems.Push(currentItem + 3);
                }
            }

            BuildingTheSpaceship(countData);

            PrintChemicalLiquids(queueLiquids);

            PrintPhysicalItems(stackPhysicalItems);

            PrintCountsOfTheElements(countData);
        }

        private static void PrintCountsOfTheElements(
            Dictionary<string, int> countData)
        {
            foreach (var itemData in countData)
            {
                string element = itemData.Key;
                int count = itemData.Value;

                Console.WriteLine($"{element}: {count}");
            }
        }

        private static void PrintPhysicalItems(
            Stack<int> stackPhysicalItems)
        {
            if (stackPhysicalItems.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine(
                    $"Physical items left: {string.Join(", ", stackPhysicalItems)}");
            }
        }

        private static void PrintChemicalLiquids(
            Queue<int> queueLiquids)
        {
            if (queueLiquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine(
                    $"Liquids left: {string.Join(", ", queueLiquids)}");
            }
        }

        private static void BuildingTheSpaceship(
            Dictionary<string, int> countData)
        {
            if (countData["Glass"] > 0 &&
                countData["Aluminium"] > 0 &&
                countData["Lithium"] > 0 &&
                countData["Carbon fiber"] > 0)
            {
                Console.WriteLine(
                    "Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine(
                    "Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
        }
    }
}
