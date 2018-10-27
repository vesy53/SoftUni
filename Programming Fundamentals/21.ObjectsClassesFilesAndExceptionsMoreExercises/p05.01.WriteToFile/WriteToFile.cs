namespace p05._01.WriteToFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class WriteToFile
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"../../../sample_text.txt");

            List<char> result = text
                .ToCharArray()
                .Where(x => !(new char[] { '.', ',', '!', '?', ':' }
                    .Contains(x)))
            .ToList();

            Console.WriteLine(string.Join("", result));
        }
    }
}
