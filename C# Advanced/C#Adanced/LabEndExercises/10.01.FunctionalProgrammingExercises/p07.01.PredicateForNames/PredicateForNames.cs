namespace p07._01.PredicateForNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();

            Predicate<string> namesLength = n => n.Length <= length;

            Func<List<string>, List<string>> takeNames = (name) =>
            {
                name = name
                    .Where(n => namesLength(n) == true)
                    .ToList();
                return name;
            };

            Console.WriteLine(
                string.Join(Environment.NewLine, takeNames(names)));
        }
    }
}
