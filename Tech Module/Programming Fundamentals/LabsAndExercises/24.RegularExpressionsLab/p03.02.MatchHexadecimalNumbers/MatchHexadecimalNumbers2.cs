namespace p03._02.MatchHexadecimalNumbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class MatchHexadecimalNumbers2
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b(?:0x)?[0-9A-F]+\b");

            string hexadecimalNums = Console.ReadLine();

            MatchCollection matchHexadecimalNums = pattern.Matches(hexadecimalNums);

            string[] matchesNumbers = matchHexadecimalNums
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", matchesNumbers));
        }
    }
}
