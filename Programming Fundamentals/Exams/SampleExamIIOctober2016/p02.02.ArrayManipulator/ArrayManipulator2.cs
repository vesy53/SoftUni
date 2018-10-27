namespace p02._02.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator2
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

                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers = Exchange(numbers, index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        string evenOrOdd = tokens[1];

                        if (evenOrOdd == "even")
                        {
                            var maxEvenNums = numbers
                                .Where(x => x % 2 == 0)
                                .ToList();

                            if (maxEvenNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int evenIndex = MaxIndex(numbers, maxEvenNums);

                                Console.WriteLine(evenIndex);
                            }
                        }
                        else if (evenOrOdd == "odd")
                        {
                            var maxOddNums = numbers
                                .Where(x => x % 2 != 0)
                                .ToList();

                            if (maxOddNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int indexOdd = MaxIndex(numbers, maxOddNums);

                                Console.WriteLine(indexOdd);
                            }
                        }
                        break;
                    case "min":
                        evenOrOdd = tokens[1];

                        if (evenOrOdd == "even")
                        {
                            var minEvenNums = numbers
                                .Where(x => x % 2 == 0)
                                .ToList();

                            if (minEvenNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int indexEven = MinIndex(numbers, minEvenNums);

                                Console.WriteLine(indexEven);
                            }
                        }
                        else if (evenOrOdd == "odd")
                        {
                            var minOddNums = numbers
                                .Where(x => x % 2 != 0)
                                .ToList();

                            if (minOddNums.Count == 0)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                int indexOdd = MinIndex(numbers, minOddNums);

                                Console.WriteLine(indexOdd);
                            }
                        }
                        break;
                    case "first":
                        int count = int.Parse(tokens[1]);
                        string evenOdd = tokens[2];

                        if (count > numbers.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            List<int> takeFirstNums = new List<int>();

                            if (evenOdd == "even")
                            {
                                takeFirstNums = numbers
                                    .Where(x => x % 2 == 0)
                                    .ToList();
                                takeFirstNums = TakeFirstNums(takeFirstNums, count);
                            }
                            else if (evenOdd == "odd")
                            {
                                takeFirstNums = numbers
                                    .Where(x => x % 2 != 0)
                                    .ToList();
                                takeFirstNums = TakeFirstNums(takeFirstNums, count);
                            }

                            Console.WriteLine($"[{string.Join(", ", takeFirstNums)}]");
                        }
 
                        break;
                    case "last":
                        count = int.Parse(tokens[1]);
                        evenOdd = tokens[2];

                        if (count > numbers.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            List<int> takeLastNums = new List<int>();

                            if (evenOdd == "even")
                            {
                                takeLastNums = numbers
                                    .Where(x => x % 2 == 0)
                                    .Reverse()
                                    .ToList();
                                takeLastNums = TakeLastNums(takeLastNums, count);
                            }
                            else if (evenOdd == "odd")
                            {
                                takeLastNums = numbers
                                    .Where(x => x % 2 != 0)
                                    .Reverse()
                                    .ToList();
                                takeLastNums = TakeLastNums(takeLastNums, count);
                            }

                            Console.WriteLine($"[{string.Join(", ", takeLastNums)}]");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        static List<int> TakeLastNums(List<int> takeLastNums, int count)
        {
            takeLastNums = takeLastNums
                .Take(count)
                .Reverse()
                .ToList();

            return takeLastNums;
        }

        static List<int> TakeFirstNums(List<int> takeFirstNums, int count)
        {
            takeFirstNums = takeFirstNums
                .Take(count)
                .ToList();

            return takeFirstNums;
        }

        static int MinIndex(List<int> numbers, List<int> minNums)
        {
            int min = minNums
                .Min();
            int index = 0;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] == min)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        static int MaxIndex(List<int> numbers, List<int> maxNums)
        {
            int max = maxNums
                .Max();
            int index = 0;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] == max)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        static List<int> Exchange(List<int> numbers, int index)
        {
            var rightPart = numbers
                .Skip(index + 1)
                .ToList();

            numbers.RemoveRange(index + 1, (numbers.Count - 1 - index));
            numbers.InsertRange(0, rightPart);

            return numbers;
        }
    }
}
