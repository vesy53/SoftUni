namespace p02._03.ArrayManipulator
{
    using System;
    using System.Linq;

    class ArrayManipulator3
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

                        if (index >= 0 && index < numbers.Length)
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

                        int maxIndex = TakeMaxIndex(numbers, evenOrOdd);

                        if (maxIndex >= 0)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "min":
                        evenOrOdd = tokens[1];

                        int minIndex = TakeMinIndex(numbers, evenOrOdd);

                        if (minIndex >= 0)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "first":
                        int count = int.Parse(tokens[1]);
                        string oddOrEven = tokens[2];

                        if (count <= numbers.Length)
                        {
                            int[] firstElements = TakeFirstElements(numbers, count, oddOrEven);
                            Console.WriteLine($"[{string.Join(", ", firstElements)}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                    case "last":
                        count = int.Parse(tokens[1]);
                        oddOrEven = tokens[2];

                        if (count <= numbers.Length)
                        {
                            int[] lastElements = TakeLastElements(numbers, count, oddOrEven);
                            Console.WriteLine($"[{string.Join(", ", lastElements)}]");
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

        static int[] TakeLastElements(int[] numbers, int count, string oddOrEven)
        {
            int result = (oddOrEven == "even") ? 0 : 1;

            int[] lastElements = numbers
                .Where(x => x % 2 == result)
                .Reverse()
                .Take(count)
                .Reverse()
                .ToArray();

            return lastElements;
        }

        static int[] TakeFirstElements(int[] numbers, int count, string oddOrEven)
        {
            int result = (oddOrEven == "even") ? 0 : 1;

            int[] firstElements = numbers
                .Where(x => x % 2 == result)
                .Take(count)
                .ToArray();

            return firstElements;
        }

        static int TakeMinIndex(int[] numbers, string evenOrOdd)
        {
            int result = (evenOrOdd == "even") ? 0 : 1;

            int[] evenOrOddElements = numbers
                .Where(x => x % 2 == result)
                .ToArray();

            int minElement;

            if (evenOrOddElements.Length > 0)
            {
                minElement = evenOrOddElements.Min();
            }
            else
            {
                return -1;
            }

            return Array.LastIndexOf(numbers, minElement);
        }

        static int TakeMaxIndex(int[] numbers, string evenOrOdd)
        {
            int result = (evenOrOdd == "even") ? 0 : 1;

            int[] evenOrOddElements = numbers
                .Where(x => x % 2 == result)
                .ToArray();

            int maxElement;

            if (evenOrOddElements.Length > 0 )
            {
                maxElement = evenOrOddElements.Max();
            }
            else
            {
                return -1;
            }

            return Array.LastIndexOf(numbers, maxElement);
        }

        static int[] Exchange(int[] numbers, int index)
        {
            int[] firstPart = numbers
                .Take(index + 1)
                .ToArray();
            int[] secondPart = numbers
                .Skip(index + 1)
                .ToArray();

            int[] concatArr = secondPart
                .Concat(firstPart)
                .ToArray();

            return concatArr;
        }
    }
}
