namespace p02._01.StackSum
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

            Stack<int> stack = new Stack<int>();

            foreach (int number in numbers)
            {
                stack.Push(number);
            }

            while (commandArgs[0].Equals("end") == false)
            {
                string command = commandArgs[0];

                switch (command)
                {
                    case "add":
                        int firstNum = int.Parse(commandArgs[1]);
                        int secondNum = int.Parse(commandArgs[2]);

                        stack.Push(firstNum);
                        stack.Push(secondNum);
                        break;
                    case "remove":
                        int countPerRemove = int.Parse(commandArgs[1]);

                        if (stack.Count > countPerRemove)
                        {
                            for (int i = 0; i < countPerRemove; i++)
                            {
                                stack.Pop();
                            }
                        }

                        break;
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
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
