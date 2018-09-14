namespace p05._02.KeyReplacer
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class KeyReplacer
    {
        static void Main(string[] args)
        {
            string keysStr = Console.ReadLine();
            string text = Console.ReadLine();

            Regex pattern = new Regex
            (
                @"(?<start>\w+)[\\<\|]\w+[\\<\|](?<end>\w+)"
            );

            Match matchKey = pattern.Match(keysStr);
            string start = matchKey.Groups["start"].Value;
            string end = matchKey.Groups["end"].Value;

            Regex patternText = new Regex($@"{start}(?<word>.*?){end}");

            MatchCollection matchText = patternText.Matches(text);

            StringBuilder result = new StringBuilder();


            foreach (Match match in matchText)
            {
                result.Append(match.Groups["word"].Value);
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }
}
