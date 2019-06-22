namespace p03._01.CoordinatesFinder
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class CoordinatesFinder
    {  
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(
                @"^(?<peakname>[A-Za-z0-9!?@$#]*)=(?<length>\d*)<<(?<code>[A-Za-z\d!?@$#]*)$");

            StringBuilder builder = new StringBuilder();

            while (input.Equals("Last note") == false)
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string totalPeakname = match.Groups["peakname"].Value;
                    int length = int.Parse(match.Groups["length"].Value);
                    string code = match.Groups["code"].Value;

                    if (length != code.Length)
                    {
                        builder.AppendLine("Nothing found!");

                        input = Console.ReadLine();
                        continue;
                    }

                    Regex peaknameRegex = new Regex(@"[A-Za-z0-9]*");

                    MatchCollection peeknameArray = peaknameRegex
                        .Matches(totalPeakname);

                    string peekname = string.Empty;

                    foreach (object element in peeknameArray)
                    {
                        peekname += element;
                    }

                    builder.AppendLine(
                        $"Coordinates found! {peekname} -> {code}");
                }
                else
                {
                    builder.AppendLine("Nothing found!");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(builder.ToString().TrimEnd());
        }
    }
}
