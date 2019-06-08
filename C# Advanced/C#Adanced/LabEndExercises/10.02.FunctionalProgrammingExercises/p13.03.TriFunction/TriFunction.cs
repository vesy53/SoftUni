namespace p13._03.TriFunction
{
    using System;
    using System.Linq;

    class TriFunction
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Action<string> print = p => Console.WriteLine(p);

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray()
                                                                    .Select(ch => (int)ch).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr
                                                                .FirstOrDefault(str => func(str, num));

            string result = firstValidName(names, size, isValidWord);

            print(result);
        }
    }
}
