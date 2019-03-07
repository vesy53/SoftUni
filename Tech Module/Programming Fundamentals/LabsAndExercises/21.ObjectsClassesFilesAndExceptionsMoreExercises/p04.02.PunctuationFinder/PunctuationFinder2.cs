namespace p04._02.PunctuationFinder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class PunctuationFinder2
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines(@"../../../sample_text.txt");

            char[] punctuatuinsToTake = new char[] { '.', ',', '!', '?', ':' };

            List<char> punctuations = new List<char>();

            foreach (string line in allLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctuatuinsToTake.Contains(line[i]))
                    {
                        punctuations.Add(line[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", punctuations));

            //Output -> copy=>paste=>submit=>judge.softuni.bg
            /*,, ,, ., ,, ., ., ,, !, ,, ,, :, ,, ., ,, ,, ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ,, ,, ,, ,, ., ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ., ,, ,, ,, ., ., ,, ., ,, ,, ,, :, ., ., ,, ,, ., ., :, ,, .
             */
        }
    }
}
