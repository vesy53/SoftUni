namespace p02._01.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator
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
                            var rightPart = numbers
                                .Skip(index + 1)
                                .ToList();

                            numbers.RemoveRange(index + 1, (numbers.Count - 1 - index));
                            numbers.InsertRange(0, rightPart);
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
                                int max = maxEvenNums
                                    .Max();
                                int evenIndex = 0;

                                for (int i = numbers.Count - 1; i >= 0; i--)
                                {
                                    if (numbers[i] == max)
                                    {
                                        evenIndex = i;
                                        break;
                                    }
                                }

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
                                int max = maxOddNums
                                    .Max();
                                int indexOdd = 0;

                                for (int i = numbers.Count - 1; i >= 0; i--)
                                {
                                    if ( numbers[i] == max)
                                    {
                                        indexOdd = i;
                                        break;
                                    }
                                }

                                Console.WriteLine(indexOdd);
                            }
                        }
                        break;
                    case "min":
                        evenOrOdd = tokens[1];

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
                                int min = maxEvenNums
                                    .Min();
                                int indexEven = 0;

                                for (int i = numbers.Count - 1; i >= 0; i--)
                                {
                                    if (numbers[i] == min)
                                    {
                                        indexEven = i;
                                        break;
                                    }
                                }

                                Console.WriteLine(indexEven);
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
                                int min = maxOddNums
                                    .Min();
                                int indexOdd = 0;

                                for (int i = numbers.Count - 1; i >= 0; i--)
                                {
                                    if (numbers[i] == min)
                                    {
                                        indexOdd = i;
                                        break;
                                    }
                                }

                                Console.WriteLine(indexOdd);
                            }
                        }
                        break;
                    case "first":
                        int count = int.Parse(tokens[1]);
                        string evenOdd = tokens[2];

                        if (evenOdd == "even")
                        {
                            if (count > numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                var takeNums = numbers
                                    .Where(x => x % 2 == 0)
                                    .Take(count)
                                    .ToList();

                                Console.WriteLine($"[{string.Join(", ", takeNums)}]");
                            }
                        }
                        else if (evenOdd == "odd")
                        {
                            if (count > numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                var takeNums = numbers
                                    .Where(x => x % 2 != 0)
                                    .Take(count)
                                    .ToList();

                                Console.WriteLine($"[{string.Join(", ", takeNums)}]");
                            }
                        }
                        break;
                    case "last":
                        count = int.Parse(tokens[1]);
                        evenOdd = tokens[2];

                        if (evenOdd == "even")
                        {
                            if (count > numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                var takeNums = numbers
                                    .Where(x => x % 2 == 0)
                                    .Reverse()
                                    .Take(count)
                                    .Reverse()
                                    .ToList();

                                Console.WriteLine($"[{string.Join(", ", takeNums)}]");
                            }
                        }
                        else
                        {
                            if (count > numbers.Count)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                var takeNums = numbers
                                    .Where(x => x % 2 != 0)
                                    .Reverse()
                                    .Take(count)
                                    .Reverse()
                                    .ToList();

                                Console.WriteLine($"[{string.Join(", ", takeNums)}]");
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
