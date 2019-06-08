namespace p02._01.BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int pushNumber = elements[0];
            int popNumber = elements[1];
            int searchNumber = elements[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < pushNumber; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < popNumber; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count != 0)
                {
                    int minNum = queue.Min();

                    Console.WriteLine(minNum);
                }
                else
                {
                    Console.WriteLine(queue.Count);
                }
            }
        }
    }
}
