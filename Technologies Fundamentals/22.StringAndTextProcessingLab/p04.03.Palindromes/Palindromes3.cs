namespace p04._03.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Palindromes3
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                StringBuilder builder = new StringBuilder();

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    builder.Append(word[i]);
                }

                if (word == builder.ToString())
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
