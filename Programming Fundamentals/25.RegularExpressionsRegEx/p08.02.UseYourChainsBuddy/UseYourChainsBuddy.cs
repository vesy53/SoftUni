namespace p08._02.UseYourChainsBuddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"<p>(.+?)<\/p>");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            string currentMatch = string.Empty;

            foreach (Match match in matches)
            {
                currentMatch += match.Groups[1].Value;
            }

            currentMatch = Regex.Replace(currentMatch, @"[^a-z0-9]", " ");
            currentMatch = Regex.Replace(currentMatch, @"\s+", " ");

            StringBuilder decryptedText = new StringBuilder();

            foreach (char @char in currentMatch)
            {
                char resultChar = @char;

                if (@char >= 'a' && @char <= 'm')
                {
                    resultChar = (char)(@char + 13);
                }
                else if (@char >= 'n' && @char <= 'z')
                {
                    resultChar = (char)(@char - 13);
                }
                else if (char.IsDigit(@char))
                {
                    resultChar += @char;
                }

                decryptedText.Append(resultChar);
            }

            Console.WriteLine(decryptedText);
        }
    }
}
