namespace p05._01.FashionBoutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FashionBoutique
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int capacityOfRacks = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothesInTheBox);

            int countRacks = 0;
            int totalSum = 0;

            while (stack.Count != 0)
            {
                int currentValue = stack.Peek();

                totalSum += currentValue;

                if (totalSum < capacityOfRacks)
                {
                    stack.Pop();

                    if (stack.Count == 0)
                    {
                        countRacks++;
                    }

                    continue;
                }
                else if (totalSum == capacityOfRacks)
                {
                    totalSum = 0;
                    stack.Pop();
                    countRacks++;

                    continue;
                }
                else if (totalSum > capacityOfRacks)
                {
                    totalSum = 0;
                    countRacks++;

                    continue;
                }
            }

            Console.WriteLine(countRacks);
        }
    }
}
