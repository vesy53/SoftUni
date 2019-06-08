namespace p09._01.ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());
            int[] deviders = Console.ReadLine()
                .Split(" ", 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= endRange; i++)
            {
                if (DevidersInfo(i, deviders))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool DevidersInfo(int i, int[] deviders)
        {
            bool isTrue = true;

            foreach (int divaider in deviders)
            {
                if (i % divaider != 0)
                {
                    isTrue = false;
                    break;
                }
            }

            return isTrue;
        }
    }
}
