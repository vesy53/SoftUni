namespace p06._04.ReverseAndExclude
{
    using System;
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

            Func<int, bool> filterFunc = n => n % divisionNum != 0;

            int[] remainingNums = numbers
                .Reverse()
                .Where(filterFunc)
                .ToArray();

            Console.WriteLine(string.Join(" ", remainingNums));
        }
    }
}
