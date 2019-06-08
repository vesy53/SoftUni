namespace p06._01.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();
            int divisibleNum = int.Parse(Console.ReadLine());

            //Predicate<int> predicate = delegate (int a)
            //{
            //    return a % divisibleNum == 0;
            //};

            Predicate<int> isDivisible = n => n % divisibleNum != 0;

            Action<List<int>> print = p =>
                Console.WriteLine(string.Join(" ", p));

            for (int i = 0; i < numbers.Count; i++)
            {
                //if (predicate(numbers[i]))
                if (!isDivisible(numbers[i]))
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            print(numbers);
        }
    }
}
