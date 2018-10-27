namespace p02._04.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator4
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split();
                string command = tokens[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);

                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            input = Console.ReadLine();
                            continue;
                        }

                        int[] rightPart = numbers
                                .Skip(index + 1)
                                .ToArray();

                        numbers.RemoveRange(index + 1, (numbers.Count - 1 - index));
                        numbers.InsertRange(0, rightPart);
                        break;

                    case "max":
                    case "min":
                        string evenOrOdd = tokens[1];
                        var currentNums = evenOrOdd.Equals("even") ?
                            numbers.Where(x => x % 2 == 0) :
                            numbers.Where(x => x % 2 == 1);

                        if (currentNums.Count() == 0)
                        {
                            Console.WriteLine("No matches");
                            input = Console.ReadLine();
                            continue;
                        }

                        int number = command.Equals("max") ?
                            numbers.LastIndexOf(currentNums.Max()) :
                            numbers.LastIndexOf(currentNums.Min());

                        Console.WriteLine(number);
                        break;
                    case "first":
                    case "last":
                        int count = int.Parse(tokens[1]);

                        if (count > numbers.Count)
                        {
                            Console.WriteLine("Invalid count");
                            input = Console.ReadLine();
                            continue;
                        }

                        List<int> currNums = tokens[2].Equals("even") ?
                                numbers.Where(x => x % 2 == 0).ToList() :
                                numbers.Where(x => x % 2 != 0).ToList();

                        if (command.Equals("first"))
                        {
                            Console.WriteLine(
                                $"[{string.Join(", ", currNums.Take(count))}]");
                        }
                        else
                        {
                            int skipCount = currNums.Count - count;

                            Console.WriteLine(
                                $"[{string.Join(", ", currNums.Skip(skipCount))}]");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
