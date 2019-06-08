namespace p02._02.StackSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StackSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[] commandArgs = Console.ReadLine()
                .ToLower()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            while (commandArgs[0].Equals("end") == false)
            {
                string command = commandArgs[0];

                if (command.Equals("add"))
                {
                    int firstNumber = int.Parse(commandArgs[1]);
                    int secondNumber = int.Parse(commandArgs[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (command.Equals("remove"))
                {
                    int countPerRemoved = int.Parse(commandArgs[1]);

                    if (stack.Count > countPerRemoved)
                    {
                        while (countPerRemoved != 0)
                        {
                            stack.Pop();

                            countPerRemoved--;
                        }
                    }
                }

                commandArgs = Console.ReadLine()
                    .ToLower()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToArray();
            }

            int sum = 0;

            while (stack.Count != 0)
            {
                sum += stack.Peek();
                stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
