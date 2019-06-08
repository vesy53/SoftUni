namespace p01._01.Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Socks
    {
        static void Main(string[] args)
        {
            int[] leftSocks = Console.ReadLine()
                .Split(' ',
                   StringSplitOptions
                   .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] rightSocks = Console.ReadLine()
                .Split(' ',
                   StringSplitOptions
                   .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackLeftSocks = new Stack<int>(leftSocks);
            Queue<int> queueRightSocks = new Queue<int>(rightSocks);

            Queue<int> pairs = new Queue<int>();
            int sumBigPair = 0;

            while (stackLeftSocks.Count != 0 &&
                   queueRightSocks.Count != 0)
            {
                int leftSock = stackLeftSocks.Pop();
                int rightStock = queueRightSocks.Peek();

                if (leftSock > rightStock)
                {
                    leftSock += rightStock;

                    queueRightSocks.Dequeue();
                    pairs.Enqueue(leftSock);

                    if (leftSock > sumBigPair)
                    {
                        sumBigPair = leftSock;
                    }
                }
                else if (leftSock == rightStock)
                {
                    leftSock++;
                    queueRightSocks.Dequeue();
                    stackLeftSocks.Push(leftSock);
                }
            }

            Console.WriteLine(sumBigPair);
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}
