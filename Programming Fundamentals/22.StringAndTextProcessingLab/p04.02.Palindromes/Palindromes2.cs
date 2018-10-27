namespace p04._02.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Palindromes2
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            foreach (string word in text)
            {
                if (word.SequenceEqual(word.Reverse()) && 
                    !palindromes.Contains(word))
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
