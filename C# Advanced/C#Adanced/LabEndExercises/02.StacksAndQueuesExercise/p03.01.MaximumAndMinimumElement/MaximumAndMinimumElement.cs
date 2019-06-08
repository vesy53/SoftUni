namespace p03._01.MaximumAndMinimumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = commandArgs[0];

                switch (command)
                {
                    case "1":
                        int pushNumber = int.Parse(commandArgs[1]);
                        stack.Push(pushNumber);
                        break;
                    case "2":
                        if (stack.Count != 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case "3":
                        if (stack.Count != 0)
                        {
                            int maxElement = stack.Max();

                            Console.WriteLine(maxElement);
                        }
                        break;
                    case "4":
                        if (stack.Count != 0)
                        {
                            int minElement = stack.Min();

                            Console.WriteLine(minElement);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
