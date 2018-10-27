namespace p03._02.Regexmon
{
    using System;
    using System.Text.RegularExpressions;

    class Regexmon2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex didimon = new Regex(@"[^a-zA-Z\-]+");
            Regex bojomon = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");

            while (true)
            {
                Match matchDidimon = didimon.Match(input);

                if (!matchDidimon.Success)
                {
                    break;
                }
                else
                {
                    int didiIndex = matchDidimon.Index;
                    int length = matchDidimon.Length;

                    input = input.Substring(didiIndex + length);

                    Console.WriteLine(matchDidimon);
                }

                Match matchBojomon = bojomon.Match(input);

                if (!matchBojomon.Success)
                {
                    break;
                }
                else
                {
                    int bojoIndex = matchBojomon.Index;
                    int length = matchBojomon.Length;

                    input = input.Substring(bojoIndex + length);

                    Console.WriteLine(matchBojomon);
                }
            }
        }
    }
}
