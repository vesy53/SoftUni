using System;
using System.Collections.Generic;

namespace p11StringConcatenation1
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            string evenOdd = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            List<string> allWords = new List<string>();

            for (int i = 1; i <= num; i++)
            {
                string word = Console.ReadLine();

                if (evenOdd == "even" && i % 2 == 0)
                {
                    allWords.Add(word);
                }
                else if (evenOdd == "odd" && i % 2 == 1)
                {
                    allWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(delimiter, allWords));
        }
    }
}
