namespace p07._01.PlayCatch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PlayCatch
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int exceptionsCounter = 0;

            while (exceptionsCounter < 3)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');
                string command = input[0];

                try
                {
                    switch (command)
                    {
                        case "Replace":
                            int index = int.Parse(input[1]);
                            int element = int.Parse(input[2]);

                            numbers.RemoveAt(index);
                            numbers.Insert(index, element);
                            break;

                        case "Print":
                            int startIndex = int.Parse(input[1]);
                            int endIndex = int.Parse(input[2]);

                            List<int> listToPrint = new List<int>();

                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                listToPrint.Add(numbers[i]);
                            }

                            Console.WriteLine(string.Join(", ", listToPrint));
                            break;

                        case "Show":
                            int printIndex = int.Parse(input[1]);

                            Console.WriteLine(numbers[printIndex]);
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    exceptionsCounter++;

                    Console.WriteLine("The index does not exist!");
                }
                catch (FormatException)
                {
                    exceptionsCounter++;

                    Console.WriteLine(
                        "The variable is not in the correct format!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
