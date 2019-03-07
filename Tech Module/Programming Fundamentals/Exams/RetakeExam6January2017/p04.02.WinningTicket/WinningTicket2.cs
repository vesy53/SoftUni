namespace p04._02.WinningTicket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class WinningTicket2
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine()
                .Split(new[] { ' ', ',' }, 
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .Select(x => x.Trim())
                 .ToList();

            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            Regex regex = new Regex(pattern);

            StringBuilder result = new StringBuilder();

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    result.Append($"invalid ticket{Environment.NewLine}");
                }
                else
                {
                    Match leftMatch = regex.Match(ticket.Substring(0, 10));
                    Match rightMatch = regex.Match(ticket.Substring(10));
                    int minLen = Math.Min(leftMatch.Length, rightMatch.Length);

                    if (!leftMatch.Success || !rightMatch.Success)
                    {
                        result.Append($"ticket \"{ ticket}\" - no match{Environment.NewLine}");
                    }
                    else
                    {
                        string leftPart = leftMatch.Value.Substring(0, minLen);
                        string rightPart = rightMatch.Value.Substring(0, minLen);

                        if (leftPart.Equals(rightPart))
                        {
                            if (leftPart.Length == 10)
                            {
                                result.Append(
                                    $"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)} Jackpot!{Environment.NewLine}");
                            }
                            else
                            {
                                result.Append(
                                    $"ticket \"{ ticket}\" - {minLen}{leftPart.Substring(0, 1)}{Environment.NewLine}");
                            }
                        }
                        else
                        {
                            result.Append($"ticket \"{ ticket}\" - no match{Environment.NewLine}");
                        }
                    }
                }
            }

            Console.Write(result.ToString());
        }
    }
}
