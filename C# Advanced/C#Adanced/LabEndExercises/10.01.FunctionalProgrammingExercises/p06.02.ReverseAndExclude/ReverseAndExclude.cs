namespace p06._02.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int divisionNum = int.Parse(Console.ReadLine());

            Func<int, bool> function = n => n % divisionNum != 0;

            Stack<int> stackNums = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (function(numbers[i]))
                {
                    stackNums.Push(numbers[i]);
                }
            }

            while (stackNums.Count != 0)
            {
                Console.Write(stackNums.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}