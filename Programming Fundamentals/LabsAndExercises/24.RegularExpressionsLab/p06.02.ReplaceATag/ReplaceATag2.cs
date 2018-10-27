namespace p06._02.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceATag2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"<a.*href.*?=(.*)>(.*?)<\/a>";
            string substituent = @"[URL href=$1]$2[/URL]";

            while (input.Equals("end") == false)
            {
                string replacement = Regex
                    .Replace(input, pattern, substituent);

                Console.WriteLine(replacement);

                input = Console.ReadLine();
            }
        }
    }
}
