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
            var data = new Dictionary<string, int>();

            string wordsPath = "../../words.txt";
            string textPath = "../../text.txt";
            string actualResultPath = "../../actualResult.txt";
            string expectedResultPath = "../../expectedResult.txt";

            using (StreamReader reader = new StreamReader(wordsPath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();

                    if (!data.ContainsKey(line))
                    {
                        data.Add(line, 0);
                    }

                    line = reader.ReadLine();
                }   
            }

            using (StreamReader reader = new StreamReader(textPath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] text = line
                        .ToLower()
                        .Split(new char[] { '-', ',', '.', '\'', '?', '!', ' ' },
                            StringSplitOptions
                            .RemoveEmptyEntries);

                    foreach (string word in text)
                    {
                        if (data.ContainsKey(word))
                        {
                            data[word]++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(actualResultPath))
            {
                foreach (var itemData in data
                    .OrderByDescending(i => i.Value))
                {
                    string word = itemData.Key;
                    int count = itemData.Value;

                    writer.WriteLine($"{word} - {count}");
                }
            }

            using (StreamReader actualReader = new StreamReader(actualResultPath))
            {
                using (StreamReader expectedReader = new StreamReader(expectedResultPath))
                {
                    string actualFileLine = actualReader.ReadLine();
                    string expectedFileLine = expectedReader.ReadLine();

                    while (actualFileLine != null && 
                           expectedFileLine != null)
                    {
                        if (actualFileLine != expectedFileLine)
                        {
                            Console.WriteLine("Files aren't the same.");
                            return;
                        }

                        actualFileLine = actualReader.ReadLine();
                        expectedFileLine = expectedReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("Files are the same.");
        }
    }
}
