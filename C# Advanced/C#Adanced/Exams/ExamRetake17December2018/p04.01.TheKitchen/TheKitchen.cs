namespace p04._01.TheKitchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheKitchen
    {
        static void Main(string[] args)
        {
            int[] knives = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] forks = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackKnives = new Stack<int>(knives);
            Queue<int> queueForks = new Queue<int>(forks);

            Queue<int> sets = new Queue<int>();

            while (stackKnives.Count() != 0 &&
                queueForks.Count() != 0)
            {
                int knive = stackKnives.Pop();
                int fork = queueForks.Peek();

                if (knive > fork)
                {
                    sets.Enqueue(knive + fork);
                    queueForks.Dequeue();
                }
                else if (knive == fork)
                {
                    queueForks.Dequeue();
                    stackKnives.Push(knive + 1);
                }
            }

            Console.WriteLine($"The biggest set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
