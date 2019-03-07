namespace p02._02.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator2
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

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

                        if (index < 0 || index >= numbers.Length)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }

                        int[] firstSequence = numbers
                            .Take(index + 1)
                            .ToArray();
                        int[] secondSequence = numbers
                            .Skip(index + 1)
                            .ToArray();

                        numbers = secondSequence
                            .Concat(firstSequence)
                            .ToArray();
                        break;

                    case "max":
                    case "min":
                        string maxOrMin = command;
                        string evenOrOdd = tokens[1];

                        int result = evenOrOdd == "even" ? 0 : 1;
                        int[] evenOrOddElements = numbers
                            .Where(x => x % 2 == result)
                            .ToArray();

                        if (evenOrOddElements.Length == 0)
                        {
                            Console.WriteLine("No matches");
                            break;
                        }

                        int maxOrMinElement = maxOrMin == "max" ? 
                            evenOrOddElements.Max() : 
                            evenOrOddElements.Min();
                        int lastIndexOfElement = Array.LastIndexOf(numbers, maxOrMinElement);

                        Console.WriteLine(lastIndexOfElement);
                        break;

                    case "first":
                    case "last":
                        string firstOrLast = command;
                        int count = int.Parse(tokens[1]);
                        evenOrOdd = tokens[2];

                        if (count < 0 || count > numbers.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        result = evenOrOdd == "even" ? 0 : 1;
                        int[] oddOrEvenElements = numbers.Where(s => s % 2 == result).ToArray();
                        int[] lastOrFirstArr = firstOrLast == "first" ? oddOrEvenElements.Take(count).ToArray() :
                            oddOrEvenElements.Reverse().Take(count).Reverse().ToArray();

                        Console.WriteLine("[{0}]", string.Join(", ", lastOrFirstArr));
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
