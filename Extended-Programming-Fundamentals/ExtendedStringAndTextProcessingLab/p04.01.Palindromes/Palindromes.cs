namespace p04._01.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();

            for (int i = 0; i < text.Length; i++)
            {
                string leftPart = text[i]
                    .Substring(0, text[i].Length / 2);

                int startIndex = text[i].Length % 2 == 0 ? 
                    text[i].Length / 2 : 
                    text[i].Length / 2 + 1;

                string rightPart = string.Join
                (
                    string.Empty, 
                    text[i]
                        .Substring(startIndex)
                        .ToCharArray()
                        .Reverse()
                 );

                if (leftPart.Equals(rightPart))
                {
                    palindromes.Add(text[i]);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
