namespace p02._02.MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class MatchPhoneNumber2
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");

            string phoneNumbers = Console.ReadLine();

            MatchCollection phoneMatches = pattern.Matches(phoneNumbers);

            var matchPhoneNums = phoneMatches
                .Cast<Match>()
                .ToList();

            Console.WriteLine(string.Join(", ", matchPhoneNums));
        }
    }
}
