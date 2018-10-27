namespace p03._03.PostOffice
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class PostOffice3
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string firstPattern = @"(?<symbol>[$#%*&])(?<letters>[A-Z]+)\k<symbol>";
            string lengthsPattern = @"(?<num>6[5-9]|[78][0-9]|90):(?<length>\d{2})";

            char[] capitalsLetters = Regex.Match(firstPart, firstPattern).Groups["letters"].Value.ToCharArray();
            MatchCollection lengths = Regex.Matches(secondPart, lengthsPattern);

            string[] words = thirdPart
                .Split();

            foreach (char capitalLetter in capitalsLetters)
            {
                int length = int.Parse(lengths
                    .FirstOrDefault(x => (char)int.Parse(x.Groups["num"].Value) == capitalLetter)
                    .Groups["length"].Value);

                string wordPattern = $@"^{capitalLetter}\S{{{length}}}$";

                foreach (string word in words)
                {
                    if (Regex.IsMatch(word, wordPattern))
                    {
                        Console.WriteLine(word);
                        break;
                    }
                }
            }
        }
    }
}
