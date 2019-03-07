namespace p05._01.MagicExchangeableWords
{
    using System;
    using System.Linq;

    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {           
            string[] text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string word1 = text[0];
            string word2 = text[1];

            int wordInt1 = word1
                .ToCharArray()
                .Distinct()
                .Count();
            int wordInt2 = word2
                .ToCharArray()
                .Distinct()
                .Count();

            if (wordInt1 == wordInt2)
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
