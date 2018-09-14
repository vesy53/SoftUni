namespace p02._01.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulator //80/100
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
                string[] inputTokens = input
                    .Split();

                string command = inputTokens[0];

                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(inputTokens[1]);

                        if (index >= 0 && index <= numbers.Count)
                        {
                            List<int> lastElements = numbers
                                .Skip(index + 1)
                                .Take(numbers.Count - index)
                                .ToList();
                            numbers = numbers
                                .Take(index + 1)
                                .ToList();

                            for (int i = 0; i < lastElements.Count; i++)
                            {
                                numbers.Insert(i, lastElements[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        string oddOrEven = inputTokens[1];

                        int result = oddOrEven == "even" ? 0 : 1;

                        List<int> evenOrOddElements = numbers
                            .Where(x => x % 2 == result)
                            .ToList();

                        int maxElement;

                        if (evenOrOddElements.Count() > 0)
                        {
                            maxElement = evenOrOddElements.Max();

                            Console.WriteLine($"{numbers.ToList().LastIndexOf(maxElement)}");
                        }
                        else if (evenOrOddElements.Count == 0)
                        {
                            Console.WriteLine("No matches");
                            break;
                        }

                        break;
                    case "min":
                        oddOrEven = inputTokens[1];

                        result = oddOrEven == "even" ? 0 : 1;

                        evenOrOddElements = numbers
                            .Where(x => x % 2 == result)
                            .ToList();

                        int minElement;

                        if (evenOrOddElements.Count() > 0)
                        {
                            minElement = evenOrOddElements.Min();

                            Console.WriteLine($"{numbers.ToList().LastIndexOf(minElement)}");
                        }
                        else if (evenOrOddElements.Count == 0)
                        {
                            Console.WriteLine("No matches");
                            break;
                        }
                        break;
                    case "first":
                        int searchCount = int.Parse(inputTokens[1]);
                        string evenOrOdd = inputTokens[2];
                        List<int> first = new List<int>();

                        if (searchCount >= 0 && searchCount < numbers.Count)
                        {
                            if (evenOrOdd == "odd")
                            {
                                first = numbers
                                    .Where(x => x % 2 != 0)
                                    .Take(searchCount)
                                    .ToList();
                            }
                            else if (evenOrOdd == "even")
                            {
                                first = numbers
                                    .Where(x => x % 2 == 0)
                                    .Take(searchCount)
                                    .ToList();
                            }

                            if (first.Count() == 0)
                            {
                                Console.WriteLine($"[]");
                            }
                            else
                            {
                                Console.WriteLine(
                                    $"[{string.Join(", ", first)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }

                        break;
                    case "last":
                        int countSearch = int.Parse(inputTokens[1]);
                        string evenOdd = inputTokens[2];
                        List<int> last = new List<int>();

                        if (countSearch >= 0 && countSearch < numbers.Count)
                        {
                            if (evenOdd =="odd")
                            {
                                last = numbers
                                    .Where(x => x % 2 != 0)
                                    .Reverse()
                                    .Take(countSearch)
                                    .Reverse()
                                    .ToList();
                            }
                            else if (evenOdd == "even")
                            {
                                last = numbers
                                    .Where(x => x % 2 == 0)
                                    .Reverse()
                                    .Take(countSearch)
                                    .Reverse()
                                    .ToList();
                            }

                            if (last.Count == 0)
                            {
                                Console.WriteLine($"[]");
                            }
                            else
                            {
                                Console.WriteLine(
                                    $"[{string.Join(", ", last)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
