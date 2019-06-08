namespace p04._04.FindEvensOrOdds
{
    using System;
    using System.Linq;

    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string condition = Console.ReadLine();

            int startNum = range[0];
            int endNum = range[1];

            int count = endNum - startNum + 1;

            var numbers = Enumerable.Range(startNum, count);

            //method with Predicate
            Predicate<int> isEven = n => n % 2 == 0;

            if (condition == "odd")
            {
                Console.WriteLine(
                    string.Join(" ", numbers.Where(n => isEven(n) == false)));
            }
            else
            {
                Console.WriteLine(
                    string.Join(" ", numbers.Where(n => isEven(n) == true)));
            }

            //method with Func
            //Func<int, bool> evenOdd = EvenOrOdd(condition);

            // Console.WriteLine(string.Join(" ", numbers.Where(evenOdd)));
        }

        //static Func<int, bool> EvenOrOdd(string condition)
        //{
        //    if (condition == "even")
        //    {
        //        return n => n % 2 == 0;
        //    }
        //    else
        //    {
        //        return n => n % 2 != 0;
        //    }
        //}
    }
}