namespace p05._02.MatchNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class MatchNumbers2
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"(^|(?<=\s))-?(\d)+(\.)?(\d+)?($|(?=\s))"
            );

            string numbers = Console.ReadLine();

            MatchCollection matchNumbers = pattern.Matches(numbers);

            string[] numsMatches = matchNumbers
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();
            //or
            //List<string> numsMatches = matchNumbers
            //    .Cast<Match>()
            //    .Select(x => x.Value)
            //    .ToList();
            //or
            //var numsMatches = matchNumbers
            //    .Cast<Match>()
            //    .ToList();

            Console.WriteLine(string.Join(" ", numsMatches));
        }
    }
}
