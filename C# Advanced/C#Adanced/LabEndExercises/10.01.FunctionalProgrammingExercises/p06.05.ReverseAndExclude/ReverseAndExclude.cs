namespace p06._05.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseAndExclude6
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int divisionNum = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = nums => nums % divisionNum == 0;

            Func<List<int>, int, List<int>> reverseAndExclude = (nums, x) =>
            {
                nums.Reverse();
                nums = nums
                    .Where(n => (isDivisible(n) == false))
                    .ToList();
                return nums;
            };

            Console.WriteLine(
                string.Join(" ", reverseAndExclude(numbers, divisionNum)));
        }
    }
}
