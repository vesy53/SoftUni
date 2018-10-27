namespace P04._01.PunctuationFinder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class PunctuationFinder
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("sample_text.txt");

            var result = text
                .ToCharArray()
                .Where(x => new char[] { '.', ',', '!', '?', ':' }
                    .Contains(x))
                .ToList();
            
            Console.WriteLine(string.Join(", ", result));

            //Output -> copy=>paste=>submit=>judge.softuni.bg
            /*,, ,, ., ,, ., ., ,, !, ,, ,, :, ,, ., ,, ,, ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ,, ,, ,, ,, ., ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ., ,, ,, ,, ., ., ,, ., ,, ,, ,, :, ., ., ,, ,, ., ., :, ,, .
             */
        }
    }
}
