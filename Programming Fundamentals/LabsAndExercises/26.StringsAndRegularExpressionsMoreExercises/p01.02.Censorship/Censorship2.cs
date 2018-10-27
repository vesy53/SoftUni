namespace p01._02.Censorship
{
    using System;
    using System.Text.RegularExpressions;

    class Censorship2
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentence = Console.ReadLine()
                .Split();

            for (int i = 0; i < sentence.Length; i++)
            {
                string currentWord = sentence[i].ToString();

                if (currentWord == word)
                {
                    sentence[i] = sentence[i]
                        .Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(string.Join(" ", sentence));
        }
    }
}
