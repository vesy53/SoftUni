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

            Func<int[], int[]> addFunc = nums => nums
                    .Select(n => n + 1)
                    .ToArray();
            Func<int[], int[]> multiplyFunc = nums => nums
                   .Select(n => n * 2)
                   .ToArray();
            Func<int[], int[]> subtractFunc = nums => nums
                    .Select(n => n - 1)
                    .ToArray();
            Action<int[]> print = p =>
                Console.WriteLine(string.Join(" ", p));

            while (command.Equals("end") == false)
            {
                switch (command)
                {
                    case "add":
                        numbers = addFunc(numbers);
                        break;
                    case "multiply":
                        numbers = multiplyFunc(numbers);
                        break;
                    case "subtract":
                        numbers = subtractFunc(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}