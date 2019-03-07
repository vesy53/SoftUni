namespace p07._01.CapitalizeWords
{
    using System;

    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] inputTokens = input
                    .ToLower()
                    .Split(TakePunctuationArray(),
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string[] words = CapitalLetters(inputTokens);

                Console.WriteLine(string.Join(", ", words));

                input = Console.ReadLine();
            }
        }

        static char[] TakePunctuationArray()
        {
            return new char[] { ' ', ',', '.', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', ';', ':' };
        }

        static string[] CapitalLetters(string[] inputTokens)
        {
            string letters = string.Empty;
            string[] newWords = new string[inputTokens.Length];

            for (int i = 0; i < inputTokens.Length; i++)
            {
                int counter = 0;

                foreach (var word in inputTokens[i])
                {
                    char currentLetter = word;

                    if (counter == 0)
                    {
                        letters = currentLetter
                            .ToString()
                            .ToUpper();
                    }
                    else
                    {
                        letters += currentLetter;
                    }

                    counter++;
                }

                newWords[i] = letters;
            }

            return newWords;
        }
    }
}
