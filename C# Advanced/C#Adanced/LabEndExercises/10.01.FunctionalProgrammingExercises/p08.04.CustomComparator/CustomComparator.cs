namespace p08._04.CustomComparator
{
    using System;
    using System.Linq;

    class CustomComparator
    {
        static void Main(string[] args)
        {
            Action<int[]> print = p =>
                Console.WriteLine(string.Join(" ", p));

            Func<int, int, int> sortFunc = (a, b) =>
                                (a % 2 == 0 && b % 2 != 0) ? -1 :  //if its true => return -1
                                (a % 2 != 0 && b % 2 == 0) ? 1 :   // if its false we're doing another check => if its another check is true => return 1
                                a.CompareTo(b);                    // if second check is false => return a.CompareTo(b)

            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, new Comparison<int>(sortFunc));

            print(numbers);
        }
    }
}
