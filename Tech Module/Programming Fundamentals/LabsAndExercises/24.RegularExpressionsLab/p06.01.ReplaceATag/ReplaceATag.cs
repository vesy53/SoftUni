namespace P06._01.ReplaceATag
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ReplaceATag
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"<a.*?href.*?=(.*)>(.*?)<\/a>");
            string substituent = @"[URL href=$1]$2[/URL]";

            StringBuilder builder = new StringBuilder();

            while (input.Equals("end") == false)
            {
                string replacement = pattern.Replace(input, substituent);

                builder.Append(replacement + Environment.NewLine);

                input = Console.ReadLine();
            }

            Console.WriteLine(builder);
        }
    }
}
