namespace p03._01.CountUppercaseWords
{
    using System;
    using System.Collections.Generic;

    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            string[] textArr = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Func<char, bool> isUpperLetter = s => char.IsUpper(s);

            List<string> firstUpperLetter = 
                TakeWordsWihtFirstUpperLetter(textArr, isUpperLetter);

            Console.WriteLine(
                string.Join(Environment.NewLine, firstUpperLetter));
        }

        private static List<string> TakeWordsWihtFirstUpperLetter(
            string[] textArr, 
            Func<char, bool> isUpperLetter)
        {
            List<string> firstUpperLetter = new List<string>();

            foreach (string word in textArr)
            {
                if (isUpperLetter(word[0]))
                {
                    firstUpperLetter.Add(word);
                }
            }

            return firstUpperLetter;
        }
    }
}
