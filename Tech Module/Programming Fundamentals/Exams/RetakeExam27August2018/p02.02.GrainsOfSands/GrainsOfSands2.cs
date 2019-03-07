namespace p02._02.GrainsOfSands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GrainsOfSands2
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input != "Mort")
            {
                string[] commandArgs = input
                    .Split();
                string command = commandArgs[0];
                int value = int.Parse(commandArgs[1]);

                int index = numbers.IndexOf(value);

                switch (command)
                {
                    case "Add":
                        Add(numbers, value);
                        break;
                    case "Remove":
                        Remove(numbers, value, index);
                        break;
                    case "Replace":
                        int replacement = int.Parse(commandArgs[2]);

                        Replace(numbers, value, replacement, index);
                        break;
                    case "Increase":
                        Increase(numbers, value);
                        break;
                    case "Collapse":
                        Collapse(numbers, value);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static void Collapse(List<int> numbers, int value)
        {
            numbers.RemoveAll(e => e < value);
        }

        static void Increase(List<int> numbers, int value)
        {
            bool isFound = false;

            foreach (var num in numbers)
            {
                if (num >= value)
                {
                    value = num;
                    isFound = true;
                    break;
                }
            }

            if (isFound == false)
            {
                value = numbers.Last();
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] += value;
            }
        }

        static void Replace(
            List<int> numbers, 
            int value, 
            int replacement,
            int index)
        {
            if (index != -1)
            {
                numbers[index] = replacement;
            }
        }

        static void Remove(
            List<int> numbers,
            int value,
            int index)
        {
            if (index != -1)
            {
                numbers.RemoveAt(index);
            }
            else
            {
                if (value >= 0 && value < numbers.Count)
                {
                    numbers.RemoveAt(value);
                }
            }
        }

        static void Add(List<int> numbers, int value)
        {
            numbers.Add(value);
        }
    }
}
