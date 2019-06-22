namespace p03._02.CoordinatesFinder
{
    using System;
    using System.Text.RegularExpressions;

    class CoordinatesFinder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(
                @"^(?<peakname>[A-Za-z!?@$#]*)=(?<length>[0-9]*)<<(?<code>\w*)$");
           //Regex regex = new Regex(
           //    @"^(?<peakname>[A-Za-z!?@$#]*)=(?<length>\d*)<<(?<code>[A-Za-z\d!?@$#]*)$");
            string cordinit = string.Empty;
            string name = string.Empty;
            string lenghts = string.Empty;
            string newName = string.Empty;
            int newlenght = 0;

            while (input.Equals("Last note") == false)
            {
                MatchCollection matches = pattern.Matches(input);

                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        name = match.Groups[2].ToString();
                        lenghts = match.Groups[3].ToString();
                        cordinit = match.Groups[1].ToString();

                        //string totalPeakname = match.Groups["peakname"].Value;
                        //int length = int.Parse(match.Groups["length"].Value);
                        //string code = match.Groups["code"].Value;

                        for (int i = 0; i < name.Length; i++)
                        {
                            char currentChar = name[i];
                            if (char.IsLetterOrDigit(currentChar))
                            {
                                newName += currentChar;
                            }
                        }
                    }
                    newlenght = int.Parse(lenghts);
                    if (newlenght != cordinit.Length)
                    {
                        Console.WriteLine("Nothing found!");
                    }
                    else
                    {
                        Console.WriteLine($"Coordinates found! {newName} -> {cordinit}");
                    }

                }
                else
                {
                    Console.WriteLine("Nothing found!");

                }

                newlenght = 0;
                newName = string.Empty;

                input = Console.ReadLine();
            }
        }
    }
}