namespace p02._01.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split(new char[] { ' ' },
                        StringSplitOptions
                        .RemoveEmptyEntries);
                string command = tokens[0];
                int start = 0;
                int count = 0;

                switch (command)
                {
                    case "reverse":
                        start = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);

                        if (start >= 0 &&
                            start < numbers.Count && 
                            count >= 0 &&
                            start + count <= numbers.Count)
                        {
                            numbers = Reversed(numbers, start, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "sort":
                        start = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);

                        if (start >= 0 && 
                            start < numbers.Count && 
                            count >= 0 &&
                            start + count <= numbers.Count)
                        {
                            numbers = Sorted(numbers, start, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollLeft":
                        count = int.Parse(tokens[1]);

                        if (count >= 0)
                        {
                            numbers = RollLeft(numbers, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        count = int.Parse(tokens[1]);

                        if (count >= 0)
                        {
                            numbers = RollRight(numbers, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        static List<string> RollRight(List<string> numbers, int count)
        {
            count = count % numbers.Count;

            for (int i = 0; i < count; i++)
            {
                string lastNum = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNum);
            }

            return numbers;
        }

        static List<string> RollLeft(List<string> numbers, int count)
        {
            count = count % numbers.Count;

            for (int i = 0; i < count; i++)
            {
                string firstNum = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNum);
            }

            return numbers;
        }

        static List<string> Sorted(
            List<string> numbers,
            int start,
            int count)
        {
            var middlePart = numbers
                .Skip(start)
                .Take(count)
                .ToList();

            middlePart.Sort();

            numbers.RemoveRange(start, count);
            numbers.InsertRange(start, middlePart);

            return numbers;
        }

        static List<string> Reversed(
            List<string> numbers,
            int start,
            int count)
        {
            var middlePart = numbers
                .Skip(start)
                .Take(count)
                .Reverse()
                .ToList();

            numbers.RemoveRange(start, count);
            numbers.InsertRange(start, middlePart);

            return numbers;
        }
    }
}
