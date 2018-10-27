namespace p03._02.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class RageQuit2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(?<symbols>[^\d]+)(?<nums>\d+)");

            MatchCollection matches = pattern.Matches(input);

            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                string symbols = match.Groups["symbols"].Value.ToUpper();
                int countRepeat = int.Parse(match.Groups["nums"].Value);

                //Repeat(builder, symbols, countRepeat);
                for (int i = 0; i < countRepeat; i++)
                {
                    builder.Append(symbols);
                }
            }

            int count = builder.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(builder);
        }

       /* static void Repeat(
            StringBuilder builder,
            string symbols,
            int countRepeat)
        {
            for (int i = 0; i < countRepeat; i++)
            {
                builder.Append(symbols);
            }
        }*/
    }
}
