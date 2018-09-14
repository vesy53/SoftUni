namespace p04._04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Palindromes4
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
               .Split(new char[] { ' ', ',', '.', '?', '!' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (var word in text
                .OrderBy(x => x))
            {
                string reversedWord = new string
                (
                    word
                    .Reverse()
                    .ToArray()
                 );

                if (word == reversedWord && 
                    !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
