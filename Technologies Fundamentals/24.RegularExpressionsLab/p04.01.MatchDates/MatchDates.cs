namespace p04._01.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    class MatchDates
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"\b(?<day>\d{2})(?<separator>[-\/\.])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b"
            );

            string datesStr = Console.ReadLine();

            MatchCollection matchDates = pattern.Matches(datesStr);

            foreach (Match date in matchDates)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine(
                    $"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
