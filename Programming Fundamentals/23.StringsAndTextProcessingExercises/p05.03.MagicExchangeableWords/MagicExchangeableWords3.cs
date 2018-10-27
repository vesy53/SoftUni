namespace p05._03.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MagicExchangeableWords3
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split()
                .ToList();

            string firstWord = text[0];
            string secondWord = text[1];

            int minLength = Math.Min(firstWord.Length, secondWord.Length);
            bool areExchangeable = true;

            var charachters = new Dictionary<char, char>();

            for (int i = 0; i < minLength; i++)
            {
                char firstChar = firstWord[i];
                char secondChar = secondWord[i];

                if (!charachters.ContainsKey(firstChar) && !charachters.ContainsValue(secondChar))
                {
                    charachters.Add(firstChar, secondChar);
                }
                else if (charachters.ContainsKey(firstChar) && charachters[firstChar] == secondChar)
                {
                    continue;
                }
                else if (charachters.ContainsKey(firstChar) && charachters[firstChar] != secondChar)
                {
                    areExchangeable = false;
                    break;
                }
                else if (!charachters.ContainsKey(firstChar) && charachters.ContainsValue(secondChar))
                {
                    areExchangeable = false;
                    break;
                }
            }

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = secondWord.Length; i < firstWord.Length; i++)
                {
                    char currentChar = firstWord[i];

                    if (!charachters.ContainsKey(currentChar))
                    {
                        areExchangeable = false;
                        break;
                    }
                }
            }
            else if (firstWord.Length < secondWord.Length)
            {
                for (int i = firstWord.Length; i < secondWord.Length; i++)
                {
                    char currentChar = secondWord[i];

                    if (!charachters.ContainsValue(currentChar))
                    {
                        areExchangeable = false;
                        break;
                    }
                }
            }

            if (areExchangeable)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
