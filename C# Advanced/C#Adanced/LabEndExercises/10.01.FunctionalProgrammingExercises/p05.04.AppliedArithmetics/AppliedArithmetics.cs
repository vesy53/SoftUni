namespace p05._03.AppliedArithmetics
{
    using System;
    using System.Linq;

    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            Func<int, int> manipulateNums = x => x + 1;
            Action<int[]> print = p =>
                Console.WriteLine(string.Join(" ", p));


            while (command.Equals("end") == false)
            {
                if (command == "print")
                {
                    print(numbers);

                    command = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "add":
                        manipulateNums = x => x + 1;
                        break;
                    case "subtract":
                        manipulateNums = x => x - 1;
                        break;
                    case "multiply":
                        manipulateNums = x => x * 2;
                        break;
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = manipulateNums(numbers[i]);
                }

                command = Console.ReadLine();
            }
        }

    }
}