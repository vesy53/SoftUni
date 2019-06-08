namespace p06._03.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int divisionNum = int.Parse(Console.ReadLine());

            Action<List<int>> reverseFunc = nums => nums.Reverse();
            Func<List<int>, List<int>> removeNumsFunc = numbers =>
                    numbers.Where(n => n % divisionNum != 0)
                           .ToList();

            Action<List<int>> print = p => Console.WriteLine(string.Join(" ", p));

            reverseFunc(inputNums);
            inputNums = removeNumsFunc(inputNums);
            print(inputNums);
        }
    }
}
