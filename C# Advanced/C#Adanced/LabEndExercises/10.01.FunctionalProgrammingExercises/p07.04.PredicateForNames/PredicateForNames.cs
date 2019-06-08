namespace p07._04.PredicateForNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            Predicate<string> isValid = n => n.Length <= length;

            Action<List<string>> print = p =>
                Console.WriteLine(
                    string.Join(Environment.NewLine, p));

            List<string> names = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Where(n => isValid(n))
                .ToList();

            print(names);
        }
    }
}
