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

            StringBuilder builder = new StringBuilder();

            Regex regex = new Regex(
                @"^(?<peakname>[A-Za-z!?@$#]*)=(?<length>\d*)<<(?<code>[A-Za-z\d!?@$#]*)$");
            
            
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

                    Regex letterRegex = new Regex(@"[A-Za-z]*");

                    MatchCollection peeknameArr = letterRegex.Matches(totalPeakname);

                    string peekname = string.Empty;

                    foreach (object letters in peeknameArr)
                    {
                        peekname += letters;
                    }

                    builder.AppendLine($"Coordinates found! {peekname} -> {code}");
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
