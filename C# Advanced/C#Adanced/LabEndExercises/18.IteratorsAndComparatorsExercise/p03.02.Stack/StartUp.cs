﻿namespace p03._02.Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split(new char[] { ',', ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];

                switch (command)
                {
                    case "Push":
                        string[] arguments = tokens
                            .Skip(1)
                            .ToArray();

                        foreach (string argument in arguments)
                        {
                            stack.Push(argument);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            PrintTheResult(stack);
            PrintTheResult(stack);
        }

        private static void PrintTheResult(Stack<string> stack)
        {
            foreach (string element in stack
                .Where(e => e != null))
            {
                Console.WriteLine(element);
            }
        }
    }
}
