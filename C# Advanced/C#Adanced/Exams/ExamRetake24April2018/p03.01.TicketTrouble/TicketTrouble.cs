namespace p03._01.TicketTrouble
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class TicketTrouble
    {
        static void Main(string[] args)
        {
            string location = Console.ReadLine();
            string input = Console.ReadLine();

            List<string> seatsNums = new List<string>();

            Regex patternSquare = new Regex(
                @"\[[^\]]*\{(?<location>[A-Z]{3} [A-Z]{2})\}.*?\{(?<place>[A-Z]\d{1,2})\}[^\[]*\]");
            Regex patternCurly = new Regex(
                @"\{[^\}]*\[(?<location>[A-Z]{3} [A-Z]{2})\].*?\[(?<place>[A-Z]\d{1,2})\][^{]*\}");

            MatchCollection squareMatches = patternSquare.Matches(input);
            MatchCollection curlyMatches = patternCurly.Matches(input);

            ExtractTickets(location, seatsNums, squareMatches);
            ExtractTickets(location, seatsNums, curlyMatches);

            if (seatsNums.Count == 2)
            {
                Console.WriteLine(
                    $"You are traveling to {location}" +
                    $" on seats {seatsNums[0]} and {seatsNums[1]}.");
            }
            else
            {
                for (int i = 0; i < seatsNums.Count; i++)
                {
                    for (int j = i + 1; j < seatsNums.Count; j++)
                    {
                        string firstRow = seatsNums[i].Substring(1);
                        string secondRow = seatsNums[j].Substring(1);

                        if (firstRow == secondRow)
                        {
                            Console.WriteLine(
                                $"You are traveling to {location} on " +
                                $"seats {seatsNums[i]} and {seatsNums[j]}.");
                            return;
                        }
                    }
                }
            }
        }

        static void ExtractTickets(
            string location,
            List<string> seatsNums,
            MatchCollection matches)
        {
            foreach (Match match in matches)
            {
                string currLocation = match.Groups["location"].Value;

                if (currLocation == location)
                {
                    string currPlase = match.Groups["place"].Value;

                    seatsNums.Add(currPlase);
                }
            }
        }
    }
}
