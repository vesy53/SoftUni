namespace p03._02.PostOffice
{
    using System;
    using System.Text.RegularExpressions;

    class PostOffice2
    {
        static void Main(string[] args)
        {
            string[] message = Console.ReadLine()
                .Split('|');

            string firstPart = message[0];
            string secondPart = message[1];
            string thirdPart = message[2];

            Regex firstPattern = new Regex(@"(?<symbols>[#$%\*&])(?<letters>[A-Z]+)\k<symbols>");
            Regex lengthPattern = new Regex(@"(?<index>6[5-9]|[78][0-9]|90):(?<length>\d{2})");

            char[] letters = firstPattern.Match(firstPart).Groups["letters"].Value.ToCharArray();
            MatchCollection matchLengths = lengthPattern.Matches(secondPart);

            string[] words = thirdPart
                .Split();

            foreach (char letter in letters)
            {
                char currLetter = letter;

                foreach (Match match in matchLengths)
                {
                    if (match.Success)
                    {
                        char firstLetter = (char)int.Parse(match.Groups["index"].Value);

                        if (firstLetter == currLetter)
                        {
                            int length = int.Parse(match.Groups["length"].Value);

                            string thirdPattern = $@"^(?<word>{currLetter}\S{{{length}}})$";

                            foreach (string word in words)
                            {
                                if (Regex.IsMatch(word, thirdPattern))
                                {
                                    Console.WriteLine(word);
                                    break;
                                }
                            }

                            break;
                        }
                    }
                }              
            }
        }
    }
}
