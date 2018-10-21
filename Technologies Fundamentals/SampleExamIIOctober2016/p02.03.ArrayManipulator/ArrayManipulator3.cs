namespace p02._03.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ArrayManipulator3
    {
        static void Main(string[] args)
        {
            var result = new StringBuilder();

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split();
                string command = tokens.First();

                if (command.Equals("exchange"))
                {
                    int index = int.Parse(tokens[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        result.AppendLine("Invalid index");
                        input = Console.ReadLine();
                        continue;
                    }

                    int[] someNumbers = numbers
                        .Skip(index + 1)
                        .ToArray();
                    numbers.RemoveRange(index + 1, numbers.Count - index - 1);
                    numbers.InsertRange(0, someNumbers);
                }
                else if (command.Equals("max") || command.Equals("min"))
                {
                    string numberType = tokens.Last();

                    var currentNums = numberType.Equals("even") ?
                        numbers.Where(x => x % 2 == 0) :
                        numbers.Where(x => x % 2 == 1);

                    if (currentNums.Count() == 0)
                    {
                        result.AppendLine("No matches");
                        input = Console.ReadLine();
                        continue;
                    }

                    int number = command.Equals("max") ?
                        numbers.LastIndexOf(currentNums.Max()) :
                        numbers.LastIndexOf(currentNums.Min());

                    result.AppendLine(number.ToString());
                }
                else if (command.Equals("first") || command.Equals("last"))
                {
                    int count = int.Parse(tokens[1]);

                    if (count > numbers.Count)
                    {
                        result.AppendLine("Invalid count");
                        input = Console.ReadLine();
                        continue;
                    }

                    var currentNums = tokens[2].Equals("even") ?
                            numbers.Where(x => x % 2 == 0).ToList() :
                            numbers.Where(x => x % 2 != 0).ToList();

                    if (command.Equals("first"))
                    {
                        result.AppendLine($"[{string.Join(", ", currentNums.Take(count))}]");
                    }
                    else
                    {
                        int skipCount = currentNums.Count - count;

                        result.AppendLine($"[{string.Join(", ", currentNums.Skip(skipCount))}]");
                    }
                }

                input = Console.ReadLine();
            }

            result.AppendLine($"[{string.Join(", ", numbers)}]");

            Console.Write(result.ToString());
        }
    }
}
