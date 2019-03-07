namespace p02._01.GrainsOfSands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GrainsOfSands  
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("Mort") == false)
            {
                string[] tokens = input
                    .Split();
                string command = tokens[0];
                int value = int.Parse(tokens[1]);

                switch (command)
                {
                    case "Add":
                        numbers = Add(numbers, value);
                        break;
                    case "Remove":
                        numbers = Remove(numbers, value);
                        break;
                    case "Replace":
                        int replacement = int.Parse(tokens[2]);

                        numbers = Replace(numbers, value, replacement);
                        break;
                    case "Increase":
                        numbers = Increase(numbers, value);
                        break;
                    case "Collapse":
                        numbers = Collapse(numbers, value);                     
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> Collapse(List<int> numbers, int value)
        {
            numbers = numbers
                .Where(x => x >= value)
                .ToList();

            return numbers;
        }

        static List<int> Increase(List<int> numbers, int value)
        {
            if (numbers.Any(x => x >= value))
            {
                int num = numbers
                    .Where(x => x >= value)
                    .First();

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] += num;
                }
            }
            else
            {
                int[] num = numbers
                    .TakeLast(1)
                    .ToArray();
                int lastNum = num[0];

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i] += lastNum;
                }
            }

            return numbers;
        }

        static List<int> Replace(
            List<int> numbers,
            int value, 
            int replacement)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == value)
                {
                    numbers.Remove(value);
                    numbers.Insert(i, replacement);
                    break;
                }
            }

            return numbers;
        }

        static List<int> Remove(List<int> numbers, int value)
        {
            if (numbers.Contains(value))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == value)
                    {
                        numbers.Remove(value);
                        break;
                    }
                }
            }
            else
            {
                if (value >= 0 && value < numbers.Count)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (i == value)
                        {
                            numbers.RemoveAt(i);
                            break;
                        }
                    }
                }
            }

            return numbers;
        }

        static List<int> Add(List<int> numbers, int value)
        {
            numbers.Add(value);

            return numbers;
        }
    }
}
