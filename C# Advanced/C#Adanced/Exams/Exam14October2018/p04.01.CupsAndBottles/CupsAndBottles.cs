namespace p04._01.CupsAndBottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CupsAndBottles
    {
        static void Main(string[] args)
        {
            int[] cupsArr = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bottlesArr = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queueCups = new Queue<int>(cupsArr);
            Stack<int> stackBottles = new Stack<int>(bottlesArr);

            int wastedWater = 0;

            while (queueCups.Count() != 0 &&
                stackBottles.Count() != 0)
            {
                int cup = queueCups.Peek();
                int bottle = stackBottles.Peek();

                if (cup <= bottle)
                {
                    wastedWater += bottle - cup;
                    queueCups.Dequeue();
                    stackBottles.Pop();
                }
                else if (cup > bottle)
                {
                    cup -= bottle;
                    bottle = stackBottles.Pop();

                    while (cup > 0)
                    {
                        bottle = stackBottles.Peek();

                        if (cup <= bottle)
                        {
                            wastedWater += bottle - cup;
                            queueCups.Dequeue();
                        }

                        cup -= bottle;
                        bottle = stackBottles.Pop();
                    }
                }
            }

            if (queueCups.Count > 0)
            {
                Console.WriteLine(
                    $"Cups: {string.Join(" ", queueCups)}");
            }
            else 
            {
                Console.WriteLine(
                    $"Bottles: {string.Join(" ", stackBottles)}");
            }

            Console.WriteLine(
                $"Wasted litters of water: {wastedWater}");
        }
    }
}
