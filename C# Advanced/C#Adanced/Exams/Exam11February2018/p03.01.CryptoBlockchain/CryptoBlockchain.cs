namespace p03._01.CryptoBlockchain
{
    using System;
    using System.Text.RegularExpressions;

    class CryptoBlockchain
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string text = string.Empty;

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                text += input;
            }

            Regex pattern = new Regex(
                @"{[^[\]{}]*?(?<nums>\d{3,})[^[\]{}]*?}|\[[^{}\[]*?(?<nums>\d{3,})[^{}\[\]]*?]");

            MatchCollection matches = pattern.Matches(text);

            string decryptedText = string.Empty;

            foreach (Match match in matches)
            {
                string nums = match.Groups["nums"].Value;
                int length = match.Length;

                Regex threeNumsPattern = new Regex(@"\d{3}");

                MatchCollection threeNumsMatches = threeNumsPattern.Matches(nums);

                foreach (var threeMatch in threeNumsMatches)
                {
                    int digits = int.Parse(threeMatch.ToString());

                    digits -= length;
                    decryptedText += (char)digits;
                }
            }

            Console.WriteLine(decryptedText);
        }
    }
}