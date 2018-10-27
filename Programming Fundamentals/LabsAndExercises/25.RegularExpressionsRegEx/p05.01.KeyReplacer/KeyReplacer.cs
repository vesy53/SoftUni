namespace p05._01.KeyReplacer
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
                @"(?<start>[A-Za-z]+)[\\<\|][0-9a-zA-Z]+[\\<\|](?<end>[a-zA-Z]+)"
            );
            
            Match keyMatch = pattern.Match(keysStr);

            if (keyMatch.Success)
            {
                string start = keyMatch.Groups["start"].Value;
                string end = keyMatch.Groups["end"].Value;

                string textPattern = $@"{start}(?<word>.*?){end}";

                MatchCollection matchText = Regex.Matches(text, textPattern);

                StringBuilder result = new StringBuilder();
               
                foreach (Match match in matchText)
                {
                    if (match.Success)
                    {
                        string word = match.Groups["word"].Value;

                        result.Append(word);
                    }
                }

                if (result.Length == 0)
                {
                    Console.WriteLine("Empty result");

                }
                else
                {
                    Console.WriteLine(result.ToString());
                }
            }
        }
    }
}
