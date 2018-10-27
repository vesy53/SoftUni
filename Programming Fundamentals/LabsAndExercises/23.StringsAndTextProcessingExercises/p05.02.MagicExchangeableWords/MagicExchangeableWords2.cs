namespace p05._02.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MagicExchangeableWords2
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ');

            List<char> firstArr = text[0]
                .ToCharArray()
                .Distinct()
                .ToList();
            List<char> secondArr = text[1]
                .ToCharArray()
                .Distinct()
                .ToList();

            bool exchengable = firstArr.Count == secondArr.Count;

            Console.WriteLine(exchengable.ToString().ToLower());
        }
    }
}
