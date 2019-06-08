namespace p03._03.CustomMinFunction
{
    using System;
    using System.Linq;

    class CustomMinFunction
    {
        public delegate int MinNumberDel(int[] numbers);

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            MinNumberDel minNumDel = TakeMinNum;

            int minNum = minNumDel(numbers);

            Console.WriteLine(minNum);
        }

        static int TakeMinNum(int[] numbers)
        {
            int minNum = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < minNum)
                {
                    minNum = num;
                }
            }

            return minNum;
        }
    }
}