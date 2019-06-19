namespace p04._02.TreasureMap
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class TreasureMap
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Regex pattern = new Regex(
                @"((?<start>#)|!)[^!#]*?(?<!\w)(?<strName>[A-Za-z]{4})(?!\w)[^!#]*(?<!\d)(?<strNum>\d{3})-(?<password>\d{4}|\d{6})(?!\d)[^!#]*?(?(start)!|#)");

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                MatchCollection matches = pattern.Matches(input);

                int takeIndex = matches.Count / 2;
                Match match = matches[takeIndex];

                string streetName = match.Groups["strName"].Value;
                string streetNumber = match.Groups["strNum"].Value;
                string password = match.Groups["password"].Value;

                builder.AppendLine(
                    $"Go to str. {streetName} {streetNumber}. Secret pass: {password}.");
            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}