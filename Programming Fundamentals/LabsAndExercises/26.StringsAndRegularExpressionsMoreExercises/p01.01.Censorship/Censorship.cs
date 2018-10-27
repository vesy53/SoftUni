namespace p01._01.Censorship
{
    using System;
    using System.Text.RegularExpressions;

    class Censorship
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = Regex
               .Replace(sentence, word, new string('*', word.Length));

            //sentence = sentence
            //   .Replace(word, new string('*', word.Length));

            Console.WriteLine(sentence);
        }
    }
}
