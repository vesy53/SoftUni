namespace p03._01.SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> stack = new Stack<string>(input);

            int sum = 0;

            while (stack.Count != 1)
            {
                string currentNum = stack.Pop();

                int number;
                bool isNumber = Int32.TryParse(currentNum, out number);

                if (isNumber)
                {
                    sum = number;
                }
                else
                {
                    if (currentNum == "+")
                    {
                        currentNum = stack.Pop();
                        sum += int.Parse(currentNum);
                        stack.Push(Convert.ToString(sum));
                    }
                    else if (currentNum == "-")
                    {
                        currentNum = stack.Pop();
                        sum -= int.Parse(currentNum);
                        stack.Push(Convert.ToString(sum));
                    }
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
