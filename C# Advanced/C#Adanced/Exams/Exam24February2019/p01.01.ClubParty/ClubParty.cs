namespace p01._01.ClubParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ClubParty
    {
        static void Main(string[] args)
        {
            int hallsMaxCapacity = int.Parse(Console.ReadLine());
            string[] elements = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>(elements);

            Queue<string> halls = new Queue<string>();
            Queue<int> numbers = new Queue<int>();
            int totalSum = 0;

            while (stack.Count != 0)
            {
                string currentElement = stack.Peek();

                bool isDigit = int.TryParse(currentElement, out int number);

                if (isDigit)
                {
                    if (halls.Count == 0)
                    {
                        stack.Pop();
                        continue;
                    }

                    totalSum += number;

                    if (totalSum <= hallsMaxCapacity)
                    {
                        stack.Pop();
                        numbers.Enqueue(number);
                    }
                    else
                    {
                        totalSum = 0;

                        Console.WriteLine(
                            $"{halls.Dequeue()} -> {string.Join(", ", numbers)}");

                        numbers = new Queue<int>();
                    }
                }
                else
                {
                    halls.Enqueue(currentElement);
                    stack.Pop();
                }
            }
        }
    }
}
