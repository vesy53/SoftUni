namespace p03._01.WordCount
{
    using System;

    class WordCount
    {
        static void Main(string[] args)
        {
            var wordsData = new Dictionary<string, int>();

            string wordsPath = "../../files/words.txt";
            string textPath = "../../files/text.txt";
            string resultPath = "../../files/output.txt";

            using (StreamReader reader = new StreamReader(wordsPath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();

                    if (!wordsData.ContainsKey(line))
                    {
                        wordsData.Add(line, 0);
                    }

                    line = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(textPath))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();

                    Regex regex = new Regex("[A-Za-z]+");
                    //Regex pattern = new Regex(@"(?<word>[A-Za-z]+)");
                    //MatchCollection matchPattern = pattern.Matches(line);
                    //foreach (Match match in matchPattern)
                    //{
                    //    string word = match.Groups["word"].Value;
                    //
                    //    if (dataWords.ContainsKey(word))
                    //    {
                    //        dataWords[word]++;
                    //    }
                    //}
                    foreach (Match currWord in regex.Matches(line))
                    {
                        if (wordsData.ContainsKey(currWord.Value))
                        {
                            wordsData[currWord.Value]++;
                        }
                    }

                    //var words = line
                    //  .Split(new char[] { ' ', ',', '?', ';', '-', '.' }, 
                    //       StringSplitOptions
                    //       .RemoveEmptyEntries);
                    //
                    //foreach (var word in words)
                    //{
                    //    if (listOfWords.ContainsKey(word.ToLower()))
                    //    {
                    //        listOfWords[word.ToLower()]++;
                    //    }
                    //}

                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                foreach (var word in wordsData
                    .OrderByDescending(x => x.Value))
                {
                    string currWord = word.Key;
                    int count = word.Value;

                    writer.WriteLine($"{currWord} - {count}");
                }
            }
        }
    }
}
