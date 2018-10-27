namespace p02._02.WordEncounter
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class WordEncounter2 
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();

            char letter = filter[0];
            int digit = filter[1] - '0';

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            while (input.Equals("end") == false)
            {
                Regex pattern = new Regex(@"^[A-Z].*[\.!\?]$");

                if (pattern.IsMatch(input))
                {
                    Regex wordsPattern = new Regex(@"\b\w+\b");

                    MatchCollection matchWord = wordsPattern.Matches(input);            

                    foreach (Match m in matchWord)
                    {
                        string word = m.Value;

                        if (IsValidWord(word, letter, digit))
                        {
                            result.Add(word);
                        }                        
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }

        static bool IsValidWord(string word, char letter, int digit)
        {
            List<string> result = new List<string>();

            int index = word.IndexOf(letter);
            int count = 0;

            while (index != -1)
            {
                index = word.IndexOf(letter, index + 1);
                count++;
            }

            return (count >= digit);
        }
    }
}
