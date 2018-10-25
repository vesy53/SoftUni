namespace p08._01.Mines
{
    using System;
    using System.Text.RegularExpressions;

    class Mines
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(<(?<firstChar>.)(?<secChar>.)>)";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match item in matches)
            {
                string firstChar = item.Groups["firstChar"].Value;
                string secondChar = item.Groups["secChar"].Value;

                int sum = Math.Abs(firstChar[0] - secondChar[0]);

                pattern = MinesPattern(sum, firstChar, secondChar);

                string match = Regex.Match(input, pattern).Value;
                input = input.Replace(match, new string('_', match.Length));
            }

            Console.WriteLine(input);
        }

        static string MinesPattern(int sum, string firstChar, string secondChar)
        {
            string specialChars = @"/.*+?|(,)[]{}\";

            firstChar = specialChars.Contains(firstChar) ? @"\" + firstChar : firstChar;
            secondChar = specialChars.Contains(secondChar) ? @"\" + secondChar : secondChar;

            return $".{{0,{sum}}}<(?<first>{firstChar})(?<second>{secondChar})>.{{0,{sum}}}";
        }
    }
}
