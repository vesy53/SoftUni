namespace p03._02.WordCount
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;

    class WordCount2
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

            string[] inputText = File
                .ReadAllText("input.txt")
                .ToLower()
                .Split(new char[] { ' ', '.', '-', ',', '?', '!', '\r', '\n' },
                    StringSplitOptions
                    .RemoveEmptyEntries);
            string[] findWords = File
                .ReadAllText("words.txt")
                .ToLower()
                .Split();

            var wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < findWords.Length; i++)
            {
                string currentWord = findWords[i];

                wordsCount[currentWord] = 0;
            }

            for (int i = 0; i < inputText.Length; i++)
            {
                string currentWord = inputText[i];

                if (wordsCount.ContainsKey(currentWord))
                {
                    wordsCount[currentWord]++;
                }
            }

            wordsCount = wordsCount
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var wordCount in wordsCount)
            {
                string word = wordCount.Key;
                int count = wordCount.Value;

                File.AppendAllText(
                    "wordCount.txt",
                    $"{word} - {count}" + Environment.NewLine);
            }
        }
    }
}
