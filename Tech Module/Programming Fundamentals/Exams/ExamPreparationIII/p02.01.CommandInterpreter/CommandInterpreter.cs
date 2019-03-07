namespace p02._01.CommandInterpreter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> inputStr = Console.ReadLine()
                .Split()
                .ToList();
            string[] commandLine = Console.ReadLine()
                .Split();

            while (commandLine[0].Equals("end") == false)
            {
                string command = commandLine[0];

                switch (command)
                {
                    case "reverse":
                        int startIndex = int.Parse(commandLine[2]);
                        int count = int.Parse(commandLine[4]);

                        if (startIndex >= 0 && 
                            startIndex < inputStr.Count &&
                            count >= 0 &&
                            startIndex + count <= inputStr.Count)
                        {
                            inputStr = ReversedPartOfElements(inputStr, startIndex, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "sort":
                        startIndex = int.Parse(commandLine[2]);
                        count = int.Parse(commandLine[4]);

                        if (startIndex >= 0 &&
                            startIndex < inputStr.Count &&
                            count >= 0 &&
                            startIndex + count <= inputStr.Count)
                        {
                            inputStr = SortedPartOfElements(inputStr, startIndex, count);

                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollLeft":
                        int countLeft = int.Parse(commandLine[1]);

                        if (countLeft >= 0)
                        {
                            inputStr = RollFirstLeftElements(inputStr, countLeft);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                    case "rollRight":
                        int countRight = int.Parse(commandLine[1]);

                        if (countRight >= 0)
                        {
                            inputStr = RollLastRightElements(inputStr, countRight);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }

                commandLine = Console.ReadLine()
                    .Split();
            }

            Console.WriteLine($"[{string.Join(", ", inputStr)}]");
        }

        private static List<string> RollLastRightElements(
            List<string> inputStr,
            int countRight)
        {
            for (int i = 0; i < countRight % inputStr.Count; i++)
            {
                string element = inputStr[inputStr.Count - 1];
                inputStr.RemoveAt(inputStr.Count - 1);
                inputStr.Insert(0, element);
            }

            return inputStr;
        }

        static List<string> RollFirstLeftElements(
            List<string> inputStr, 
            int countLeft)
        {
            for (int i = 0; i < countLeft % inputStr.Count; i++)
            {
                string element = inputStr[0];
                inputStr.RemoveAt(0);
                inputStr.Add(element);
            }

            return inputStr;
        }

        static List<string> SortedPartOfElements(
            List<string> inputStr,
            int startIndex,
            int count)
        {
            List<string> firstPart = inputStr
                .Take(startIndex)
                .ToList();
            List<string> sorted = inputStr
                .Skip(startIndex)
                .Take(count)
                .OrderBy(x => x)
                .ToList();
            List<string> lastPart = inputStr
                .Skip(startIndex + count)
                .ToList();

            List<string> firstConcat = firstPart
                .Concat(sorted)
                .ToList();
            List<string> concat = firstConcat
                .Concat(lastPart)
                .ToList();

            inputStr.Clear();
            inputStr.AddRange(concat);

            return inputStr;
        }

        static List<string> ReversedPartOfElements(
            List<string> inputStr,
            int startIndex,
            int count)
        {
            List<string> firstPart = inputStr
                .Take(startIndex)
                .ToList();

            List<string> reversed = inputStr
                .Skip(startIndex)
                .Take(count)
                .Reverse()
                .ToList();

            List<string> lastPart = inputStr
                .Skip(startIndex + count)
                .ToList();

            List<string> firstConcat = firstPart
                .Concat(reversed)
                .ToList();
            List<string> concat = firstConcat
                .Concat(lastPart)
                .ToList();
            inputStr.Clear();
            inputStr.AddRange(concat);

            return inputStr;
        }
    }
}
