namespace p03._01.Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    class Regexmon
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex didimon = new Regex(@"([^a-zA-Z\-]+)");
            Regex bojomon = new Regex(@"([a-zA-Z]+)\-([a-zA-Z]+)");
            int round = 1;

            while (true)
            {
                if (round % 2 != 0)
                {
                    Match matchDidimon = didimon.Match(input);

                    if (matchDidimon.Success)
                    {
                        int firstMatchDidi = matchDidimon.Index;

                        input = input.Substring(firstMatchDidi + matchDidimon.Length);

                        Console.WriteLine(matchDidimon.ToString());
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Match matchBojomon = bojomon.Match(input);

                    if (matchBojomon.Success)
                    {
                        int firstMatchBojo = matchBojomon.Index;

                        input = input.Substring(firstMatchBojo + matchBojomon.Length);

                        Console.WriteLine(matchBojomon.ToString());
                    }
                    else
                    {
                        return;
                    }
                }

                round++;
            }           
        }
    }
}
