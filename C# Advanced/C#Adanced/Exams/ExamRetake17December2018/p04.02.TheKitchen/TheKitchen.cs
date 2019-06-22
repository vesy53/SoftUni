namespace p04._02.TheKitchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TheKitchen
    {
        static void Main(string[] args)
        {
            int[] inputKnives = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] inputForks = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackKnives = new Stack<int>(inputKnives);
            Stack<int> stackForks = new Stack<int>(inputForks.Reverse());

            Queue<int> sets = new Queue<int>();

            while (stackKnives.Any() &&
                   stackForks.Any())
            {
                int knive = stackKnives.Pop();
                int fork = stackForks.Peek();

                if (knive > fork)
                {
                    stackForks.Pop();
                    sets.Enqueue(knive + fork);
                }
                else if (knive == fork)
                {
                    stackForks.Pop();
                    stackKnives.Push(++knive);
                }
            }

            Console.WriteLine(
                $"The biggest set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));        
        }
    }
}
