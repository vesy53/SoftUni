using System;

namespace p03._02.TextFilter
{
    class TextFilter2
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions
                    .None);
            string text = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                if (text.Contains(banWord))
                {
                    text = text
                        .Replace(
                            banWord,
                            new string('*', banWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
