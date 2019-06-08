namespace p05._02.AppliedArithmetics
{
    using System;
    using System.Linq;

    class AppliedArithmetics
    {
        public delegate int[] BinaryOperator(int[] numbers);

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            while (command.Equals("end") == false)
            {
                switch (command)
                {
                    case "add":
                        CalculateNums(numbers, Add);
                        break;
                    case "subtract":
                        CalculateNums(numbers, Subtract);
                        break;
                    case "multiply":
                        CalculateNums(numbers, Multiply);
                        break;
                    case "print":
                        PrintResult(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static void PrintResult(int[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }

        static int[] CalculateNums(int[] numbers, BinaryOperator operations)
        {
            return operations(numbers);
        }

        static int[] Add(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]++;
            }

            return numbers;
        }

        static int[] Subtract(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]--;
            }

            return numbers;
        }

        static int[] Multiply(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }

            return numbers;
        }
    }
}