using System;

namespace p05WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string endWord = "";

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                endWord = word + "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("s") 
                || word.EndsWith("x") || word.EndsWith("z")
                || word.EndsWith("ch") || word.EndsWith("sh"))
            {             
                endWord = word + "es";
            }          
            else
            {
                endWord = word + "s";
            }

            Console.WriteLine(endWord);
        }
    }
}
