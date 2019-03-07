namespace p07._02.PlayCatch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PlayCatch2
    {
        static void Main(string[] args)
        {
            Catch3Exeptions();
        }

        static void Catch3Exeptions()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var exeptionsCounter = 3;

            while (exeptionsCounter > 0)
            {
                string input = Console.ReadLine();

                string command = input
                    .Split(' ')
                    .First();
                string[] commandList = input
                    .Split(' ')
                    .Skip(1)
                    .ToArray();

                try
                {
                    switch (command)
                    {
                        case "Replace":
                            RaplaceNum(numbers, commandList);
                            break;
                        case "Print":
                            PrintNumRange(numbers, commandList);
                            break;
                        case "Show":
                            PrintNumAt(numbers, commandList);
                            break;
                    }
                }
                catch (FormatException)
                {
                    exeptionsCounter--;

                    Console.WriteLine(
                        "The variable is not in the correct format!");
                }
                catch (IndexOutOfRangeException)
                {
                    exeptionsCounter--;

                    Console.WriteLine("The index does not exist!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void PrintNumAt(int[] numbers, string[] commandList)
        {
            var index = int.Parse(commandList[0]);

            Console.WriteLine(numbers[index]);
        }

        static void PrintNumRange(int[] numbers, string[] commandList)
        {

            int startIndex = int.Parse(commandList[0]);
            int endIndex = int.Parse(commandList[1]);

            List<int> result = new List<int>();

            for (int i = startIndex; i <= endIndex; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(", ", result));
        }

        static void RaplaceNum(int[] numbers, string[] commandList)
        {
            int index = int.Parse(commandList[0]);
            int element = int.Parse(commandList[1]);

            numbers[index] = element;
        }
    }
}
