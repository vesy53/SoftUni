namespace p13._04.TriFunction
{
    using System;
    using System.Linq;

    class TriFunction
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] inputNames = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Action<string> print = p => Console.WriteLine(p);

            Func<string, int, bool> isEqualSum = (name, totalSum) => name.Sum(x => x) >= totalSum;

            Func<string[], Func<string, int, bool>, string> firstNameFunc = (names, isEqualSumOfAscii) =>
                                                            names.FirstOrDefault(x => isEqualSum(x, number));

            string result = firstNameFunc(inputNames, isEqualSum);

            print(result);
        }
    }
}
