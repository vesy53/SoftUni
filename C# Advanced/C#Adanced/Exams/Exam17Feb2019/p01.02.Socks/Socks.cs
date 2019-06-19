namespace p01._02.Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Socks
    {
        static void Main(string[] args)
        {
            int[] leftSocks = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] rightSocks = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> leftStack = FullTheStack(leftSocks);
            Queue<int> rightQueue = FullTheQueue(rightSocks);

            Queue<int> pairs = new Queue<int>();

            while (leftStack.Any() &&
                rightQueue.Any())
            {
                int currentLeft = leftStack.Pop();
                int currentRight = rightQueue.Peek();

                if (currentLeft > currentRight)
                {
                    int pair = currentLeft + currentRight;
                    pairs.Enqueue(pair);

                    rightQueue.Dequeue();
                }
                else if (currentLeft == currentRight)
                {
                    leftStack.Push(++currentLeft);
                    rightQueue.Dequeue();
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }

        private static Queue<int> FullTheQueue(int[] rightSocks)
        {
            Queue<int> rightQueue = new Queue<int>();

            foreach (int element in rightSocks)
            {
                rightQueue.Enqueue(element);
            }

            return rightQueue;
        }

        private static Stack<int> FullTheStack(int[] leftSocks)
        {
            Stack<int> leftStack = new Stack<int>();

            for (int i = 0; i < leftSocks.Length; i++)
            {
                leftStack.Push(leftSocks[i]);
            }

            return leftStack;
        }
    }
}
