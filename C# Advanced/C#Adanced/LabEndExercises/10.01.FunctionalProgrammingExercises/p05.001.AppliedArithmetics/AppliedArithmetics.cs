namespace p05._01.AppliedArithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            Func<int, int> addFunc = a => a + 1;
            Func<int, int> multiplyFunc = a => a * 2;
            Func<int, int> subtractFunc = a => a - 1;
            Action<List<int>> printResult = 
                p => Console.WriteLine(string.Join(" ", p));

            while (command.Equals("end") == false)
            {
                switch (command)
                {
                    case "add":
                        ChageValue(numbers, addFunc);
                        break;
                    case "multiply":
                        ChageValue(numbers, multiplyFunc);
                        break;
                    case "subtract":
                        ChageValue(numbers, subtractFunc);
                        break;
                    case "print":
                        printResult(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }

        private static void ChageValue(
            List<int> numbers, 
            Func<int, int> function)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = function(numbers[i]);
            }
        }
    }
}
