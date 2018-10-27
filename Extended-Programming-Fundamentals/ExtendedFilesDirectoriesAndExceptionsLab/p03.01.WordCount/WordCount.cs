namespace p03._01.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class WordCount
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
            string[] lookingWords = File
                .ReadAllText("words.txt")
                .ToLower()
                .Split();

            var wordsCount = new Dictionary<string, int>();

            foreach (var word in lookingWords)
            {
                wordsCount[word] = 0;
                //or
                //if (!wordsCount.ContainsKey(word))
                //{
                //    wordsCount.Add(word, 0);
                //}
            }

            foreach (var inputWord in inputText)
            {
                if (wordsCount.ContainsKey(inputWord))
                {
                    wordsCount[inputWord]++;
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
