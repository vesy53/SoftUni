namespace p01._01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"(?<=\s)[a-z0-9]+[\w+\.\-]+@[a-z]+([\.\-][a-z]+)([\.\-]*[a-z]+)+"
            );
            //@"(?<=\s)[a-z0-9]+[a-z0-9\.\-_]+@[a-z]+([\.\-][a-z]+)([\.\-]*[a-z]+)+";
            //@"(?<=\s)[a-z0-9]+([-\.]\w*)*@[a-z]+([-\.]\w+)+";

            string text = Console.ReadLine();

            MatchCollection emailMatch = pattern.Matches(text);

            foreach (Match email in emailMatch)
            {
                Console.WriteLine(email);
            }
        }
    }
}
