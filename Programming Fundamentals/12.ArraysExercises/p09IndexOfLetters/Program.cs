using System;

namespace p09IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();

            char[] lettersArr = new char[letters.Length];

            for (int i = 0; i < lettersArr.Length; i++)
            {
                lettersArr[i] = letters[i];
                int result = lettersArr[i] - 97;
            
                Console.WriteLine($"{lettersArr[i]} -> {result}");
            }

            /* second method
              
            foreach (var letter in letters)
            {
                Console.WriteLine($"{letters} -> {letters - 97}");
            } */
        }
    }
}
