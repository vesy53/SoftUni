namespace p03._03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //create first file
            //string text = "-I was quick to judge him, but it wasn't his fault." + Environment.NewLine
            //    + "-Is this some kind of joke?!Is it ?" + Environment.NewLine
            //    + "-Quick, hide here…It is safer.";
            //
            //File.WriteAllText("input.txt", text);

            //create a file of words we are looking for
            //string findWords = "quick is fault";
            //
            //File.WriteAllText("words.txt", findWords);

            var words = File
                .ReadAllText("words.txt")
                .ToLower()
                .Split()
                .Distinct();
            string[] text = File
                .ReadAllText("input.txt")
                .ToLower()
                .Split(new char[] { ' ', '.', '-', ',', '?', '!', '\r', '\n' }, 
                    StringSplitOptions
                    .RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();

            int count = 0;

            foreach (var currentWourd in words)
            {
                foreach (var word in text)
                {
                    if (currentWourd == word)
                    {
                        count++;
                    }
                }

                wordsCount.Add(currentWourd, 0);
                wordsCount[currentWourd] += count;
                count = 0;
            }

            wordsCount = wordsCount
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var wordCount in wordsCount)
            {
                string word = wordCount.Key;
                int counter = wordCount.Value;

                File.AppendAllText
                (
                    "output.txt",
                    $"{word} - {counter}{Environment.NewLine}"
                );
            }
        }
    }
}
