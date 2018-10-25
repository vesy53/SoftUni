namespace p02._01.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();

            string[] text = Console.ReadLine()
                .Split(".!?".ToCharArray(),
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string pattern = $@"(\b{searchWord}\b)";

            foreach (var sentence in text)
            {
                Match matchSentence = Regex.Match(sentence, pattern);

                if (matchSentence.Success)
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
