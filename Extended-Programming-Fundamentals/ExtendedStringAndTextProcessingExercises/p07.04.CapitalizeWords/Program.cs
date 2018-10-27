namespace p07._04.CapitalizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] words = input
                    .Split(".?!, -:;"
                        .ToCharArray(),
                        StringSplitOptions
                        .RemoveEmptyEntries);

                List<string> result = new List<string>();

                foreach (var word in words)
                {
                    string currentWord = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
                    //string currentWord = word.Substring(0, 1).ToUpper() + (new string(word.Skip(1).ToArray())).ToLower();

                    result.Add(currentWord);
                }

                Console.WriteLine(string.Join(", ", result));

                input = Console.ReadLine();
            }
        }
    }
}
