namespace p04._01.MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    class MatchDates2
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"\b(?P<day>\d{2})(?P<separator>[-\/\.])(?P<month>[A-Z][a-z]{2})\2(?P<year>\d{4})\b"
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
