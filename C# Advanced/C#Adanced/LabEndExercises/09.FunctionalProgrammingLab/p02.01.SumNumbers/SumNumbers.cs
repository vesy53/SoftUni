namespace p02._01.SumNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(", ",
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<List<int>, int> countFunc = (List<int> nums) => nums.Count; 
            Func<List<int>, int> sumFunc = (List<int> nums) => nums.Sum();

            Console.WriteLine(countFunc(numbers));
            Console.WriteLine(sumFunc(numbers));

            //or
            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(numbers.Sum());
        }
    }
}
