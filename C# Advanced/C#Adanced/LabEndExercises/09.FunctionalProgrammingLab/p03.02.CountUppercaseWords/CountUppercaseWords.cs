namespace p03._02.CountUppercaseWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))
                .ToList();

            words
                .ForEach(w => Console.WriteLine(w));
        }
    }
}
