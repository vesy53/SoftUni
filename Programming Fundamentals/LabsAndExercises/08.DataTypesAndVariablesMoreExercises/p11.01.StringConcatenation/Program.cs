using System;

namespace p11StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            string findWords = "";

            for (int i = 1; i <= num; i++)
            {
                string word = Console.ReadLine();

                if (evenOdd == "even" && i % 2 == 0)
                {
                    findWords += word + delimiter;
                }
                else if (evenOdd == "odd" && i % 2 == 1)
                {
                    findWords += word + delimiter;
                }
            }

            Console.WriteLine(findWords.Remove(findWords.Length - 1));
        }
    }
}
