namespace p03._01.TextFilter
{
    using System;

    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                if (text.Contains(bannedWords[i]))
                {
                    text = text
                        .Replace(
                            bannedWords[i],
                            new string('*', bannedWords[i].Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
