using System;

namespace p09MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string word = "";

            for (int i = 0; i < num; i++)
            {
                char letters = char.Parse(Console.ReadLine());

                word += letters;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
