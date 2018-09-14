namespace p08._01.UseYourChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"<p>(.*?)<\/p>");

            string input = Console.ReadLine();
            MatchCollection matches = pattern.Matches(input);

            List<string> decrypt = new List<string>();

            foreach (Match match in matches)
            {
                Regex regex = new Regex(@"[^a-z0-9]+");

                string replacement = " ";

                string resultWithSpaces = regex
                    .Replace(match.Groups[1].Value.ToString(), replacement);

                decrypt.Add(resultWithSpaces);
            }

            StringBuilder builder = new StringBuilder();

            foreach (var match in decrypt)
            {
                string symbols = match;
                int count = 0;

                foreach (var chars in symbols)
                {
                    char currentChar = chars;
                    int index = 0;

                    if (char.IsLetter(currentChar))
                    {
                        if (currentChar >= 'a' && currentChar <= 'm')
                        {
                            index = currentChar + 13;
                            currentChar = (char)index;
                        }
                        else if (currentChar >= 'n' && currentChar <= 'z')
                        {
                            index = currentChar - 13;
                            currentChar = (char)index;
                        }

                        builder.Append(currentChar);
                    }
                    else if (char.IsDigit(currentChar))
                    {
                        builder.Append(currentChar);
                    }
                    else if (char.IsSeparator(currentChar))
                    {
                        builder.Append(currentChar);
                    }
                }
            }

            Console.WriteLine(builder);
        }
    }
}
