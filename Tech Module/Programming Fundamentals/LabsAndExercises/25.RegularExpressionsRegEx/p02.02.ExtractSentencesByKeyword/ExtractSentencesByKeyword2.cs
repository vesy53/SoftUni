namespace p02._02.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractSentencesByKeyword2
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();
            string input = Console.ReadLine();

            string[] sentences = input
                .Split(new char[] { '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            string pattern = $@"\b{searchWord}\b";

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
