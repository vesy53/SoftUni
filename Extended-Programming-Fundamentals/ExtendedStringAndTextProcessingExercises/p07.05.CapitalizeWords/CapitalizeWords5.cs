namespace p07._05.CapitalizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CapitalizeWords5
    {
        static void Main(string[] args)
        {
            char[] symbols = new char[] 
            {
                ' ', '.', ',', ':', ';', '?', '!', '-'
            };

            List<string> text = Console.ReadLine()
                .ToLower()
                .Split(symbols,
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .ToList();

            while (text[0].Equals("end") == false)
            {
                List<string> result = new List<string>();

                foreach (var word in text)
                {
                    string newWord = string.Empty;

                    for (int i = 0; i < word.Length; i++)
                    {
                        string currentLetter = word[i].ToString();

                        if (i == 0)
                        {
                            currentLetter = word[i]
                                .ToString()
                                .ToUpper();
                        }

                        newWord += currentLetter;
                    }

                    result.Add(newWord);
                }

                Console.WriteLine(string.Join(", ", result));

                text = Console.ReadLine()
                .ToLower()
                .Split(symbols,
                    StringSplitOptions
                    .RemoveEmptyEntries)
                 .ToList();
            }
        }
    }
}
