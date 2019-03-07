namespace P02._01.WordEncounter
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class WordEncounter
    {
        static void Main(string[] args)
        {//80/100
            string filter = Console.ReadLine();

            char letter = filter[0];
            int digit = int.Parse(filter[1].ToString());

            string input = Console.ReadLine();

            List<string> result = new List<string>();

            while (input.Equals("end") == false)
            {
                Regex pattern = new Regex(@"^[A-Z].*[\.\?!]$");
                
                if (pattern.IsMatch(input))
                {
                    Regex regex = new Regex(@"\b\w+\b");

                    MatchCollection validWords = regex.Matches(input);                  

                    foreach (Match word in validWords)
                    {
                        string currentWord = word.Value;
                        int count = 0;

                        for (int i = 0; i < currentWord.Length; i++)
                        {
                            char currentLetter = currentWord[i];

                            if (currentLetter == letter)
                            {
                                count++;

                                if (count == digit)
                                {
                                    result.Add(currentWord);
                                    break;
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
