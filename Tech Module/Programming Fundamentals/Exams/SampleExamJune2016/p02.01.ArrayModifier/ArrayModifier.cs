namespace p02._01.ArrayModifier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayModifier
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split();
                string command = tokens[0];

                switch (command)
                {
                    case "swap":
                        int firstIndex = int.Parse(tokens[1]);
                        int secondIndex = int.Parse(tokens[2]);

                        Swap(numbers, firstIndex, secondIndex);
                        break;
                    case "multiply":
                        firstIndex = int.Parse(tokens[1]);
                        secondIndex = int.Parse(tokens[2]);

                        Multiply(numbers, firstIndex, secondIndex);
                        break;
                    case "decrease":
                        Decrease(numbers);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        static void Decrease(List<long> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= 1;
            }
        }

        static void Multiply(List<long> numbers, int firstIndex, int secondIndex)
        {
            long firstNum = numbers[firstIndex];
            long secondNum = numbers[secondIndex];

            firstNum *= secondNum;

            numbers.RemoveAt(firstIndex);
            numbers.Insert(firstIndex, firstNum);
        }

        static void Swap(List<long> numbers, int firstIndex, int secondIndex)
        {
            long firstNum = numbers[firstIndex];
            long secondNum = numbers[secondIndex];

            numbers.RemoveAt(firstIndex);
            numbers.Insert(firstIndex, secondNum);
            numbers.RemoveAt(secondIndex);
            numbers.Insert(secondIndex, firstNum);
        }
    }
}
