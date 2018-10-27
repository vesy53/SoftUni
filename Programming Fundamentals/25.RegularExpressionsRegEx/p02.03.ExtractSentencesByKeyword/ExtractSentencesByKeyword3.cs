namespace p02._03.ExtractSentencesByKeyword
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractSentencesByKeyword3
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .Select(x => x.Trim())
                 .ToArray();

            string pattern = $@"\b{searchWord}\b";

            Regex regex = new Regex(pattern);

            for (int i = 0; i < text.Length; i++)
            {
                if (regex.IsMatch(text[i]))
                {
                    Console.WriteLine(text[i]);
                }
            }

            //another method per print
            //foreach (var sentence in text)
            //{
            //    if (regex.IsMatch(sentence))
            //    {
            //        Console.WriteLine(sentence.Trim());
            //    }
            //}
        }
    }
}
