namespace P03._03.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TextFilter3
    {
        static void Main(string[] args)
        {
            List<string> bannedWords = Console.ReadLine()
                .Split(new char[] { ' ', ',' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                int startIndex = text.IndexOf(word);
                int wordLenght = word.Length;

                string newValue = new string('*', word.Length);
                string oldValue = text.Substring(startIndex, wordLenght);

                text = text.Replace(oldValue, newValue);
            }

            Console.WriteLine(text);
        }
    }
}
