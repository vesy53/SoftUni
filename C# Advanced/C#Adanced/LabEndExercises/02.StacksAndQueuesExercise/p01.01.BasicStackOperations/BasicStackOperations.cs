namespace p01._01.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicStackOperations
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

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < pushNumber; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < popNumber; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchNumber))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count != 0)
                {
                    int minNum = stack.Min();

                    Console.WriteLine(minNum);
                }
                else
                {
                    Console.WriteLine(stack.Count);
                }
            }
        }
    }
}
