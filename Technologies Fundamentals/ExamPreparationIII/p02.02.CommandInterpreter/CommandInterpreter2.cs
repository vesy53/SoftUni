namespace p02._02.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CommandInterpreter2
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();
            string[] tokens = Console.ReadLine()
                .Split();

            int startIndex = 0;
            int count = 0;

            while (tokens[0].Equals("end") == false)
            {
                string command = tokens[0];

                switch (command)
                {
                    case "reverse":
                        startIndex = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);
                        input = Reversed(input, startIndex, count);
                        break;
                    case "sort":
                        startIndex = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);
                        input = Sorted(input, startIndex, count);
                        break;
                    case "rollLeft":
                        count = int.Parse(tokens[1]);
                        RollLeft(input, count);
                        break;
                    case "rollRight":
                        count = int.Parse(tokens[1]);
                        RollRight(input, count);
                        break;
                }

                tokens = Console.ReadLine()
                    .Split();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        static void RollRight(List<string> input, int count)
        {
            if (count >= 0)
            {
                int rotation = count % input.Count;

                for (int i = 0; i < rotation; i++)
                {
                    string element = input[input.Count - 1];
                    input.RemoveAt(input.Count - 1);
                    input.Insert(0, element);
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static void RollLeft(List<string> input, int count)
        {
            if (count >= 0)
            {
                int rotation = count % input.Count;

                for (int i = 0; i < rotation; i++)
                {
                    string element = input[0];
                    input.RemoveAt(0);
                    input.Add(element);
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        static List<string> Sorted(List<string> input, int startIndex, int count)
        {
            if (IsValid(input, startIndex, count))
            {
                List<string> currentList = input
                    .Skip(startIndex)
                    .Take(count)
                    .OrderBy(x => x)
                    .ToList(); 

                input.RemoveRange(startIndex, count); 
                input.InsertRange(startIndex, currentList);
            }

            return input;
        }

        static List<string> Reversed(List<string> input, int startIndex, int count)
        {
            if (IsValid(input, startIndex, count))
            {
                List<string> currentList = input
                    .Skip(startIndex)
                    .Take(count)
                    .Reverse()
                    .ToList();

                input.RemoveRange(startIndex, count); 
                input.InsertRange(startIndex, currentList);
            }

            return input;
        }

        static bool IsValid(List<string> input, int startIndex, int count)
        {
            bool isInRange = startIndex >= 0 && startIndex < input.Count;
            bool isValidCount = count >= 0 && (startIndex + count) <= input.Count;

            if (isInRange && isValidCount)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");

                return false;
            }
        }
    }
}
