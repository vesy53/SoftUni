namespace p03._01.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class RageQuit
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();

            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(?<symbols>[^\d]+)(?<nums>\d+)");

            MatchCollection matches = pattern.Matches(input);

            foreach(Match match in matches)
            {
                string symbols = match.Groups["symbols"].Value.ToUpper();
                int digit = int.Parse(match.Groups["nums"].Value);

                string replacer = string
                    .Concat(Enumerable.Repeat(symbols, digit));

                builder.Append(replacer);
            }

            int count = builder.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(builder);
        }
    }
}
