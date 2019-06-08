namespace p04._01.FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FastFood
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isNonFood = false;

            Queue<int> queue = new Queue<int>(orders);

            int biggestOrder = queue.Max();
            Console.WriteLine(biggestOrder);

            while (!isNonFood)
            {
                int currentOrder = queue.Peek();
               
                if (currentOrder <= quantityFood)
                {
                    queue.Dequeue();
                    quantityFood -= currentOrder;
                }
                else 
                {
                    isNonFood = true;
                }

                if (queue.Count == 0)
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(
                    $"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
