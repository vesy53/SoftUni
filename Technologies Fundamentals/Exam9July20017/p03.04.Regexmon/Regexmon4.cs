using System;
using System.Text;
using System.Text.RegularExpressions;

namespace p03._04.Regexmon
{
    class Regexmon4
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string didimon = @"[^a-zA-Z-]+";
            string bojomon = @"[a-zA-Z]+-[a-zA-Z]+";

            StringBuilder builder = new StringBuilder();
            builder.Append(input);

            Regex regexDidi = new Regex(didimon);
            Regex regexBojo = new Regex(bojomon);

            int round = 1;

            while (builder.Length > 0)
            {
                bool isFound = false;

                if (round % 2 != 0)
                {
                    isFound = regexDidi.IsMatch(builder.ToString());
                }
                else
                {
                    isFound = regexBojo.IsMatch(builder.ToString());
                }

                if (isFound)
                {
                    if (round % 2 != 0)
                    {
                        Match match = regexDidi.Match(builder.ToString());
                        int index = builder.ToString().IndexOf(match.Groups[0].ToString(), 0);
                        builder.Remove(0, match.Groups[0].ToString().Length + index);

                        Console.WriteLine(match.Groups[0]);
                    }
                    else
                    {
                        Match match = regexBojo.Match(builder.ToString());
                        int index = builder.ToString().IndexOf(match.Groups[0].ToString(), 0);
                        builder.Remove(0, match.Groups[0].ToString().Length + index);

                        Console.WriteLine(match.Groups[0]);
                    }
                }
                else
                {
                    return;
                }

                round++;
            }
        }
    }
}
