namespace p06._01.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] {' ', '\\', '/', '(', ')'},
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Regex pattern = new Regex(@"^([a-zA-Z]\w{2,24})$");

            List<string> validUsername = new List<string>();

            foreach (var user in input)
            {
                Match match = pattern.Match(user);

                if (match.Success)
                {
                    validUsername.Add(user);
                }
            }

            int maxLength = 0;
            int bestIndex = 0;

            for (int i = 0; i < validUsername.Count - 1; i++)
            {
                int firstWord = validUsername[i].Length;
                int secondWord = validUsername[i + 1].Length;

                if (firstWord + secondWord > maxLength)
                {
                    maxLength = firstWord + secondWord;
                    bestIndex = i;
                }           
            }

            Console.WriteLine(validUsername[bestIndex]);
            Console.WriteLine(validUsername[bestIndex + 1]);
        }
    }
}
