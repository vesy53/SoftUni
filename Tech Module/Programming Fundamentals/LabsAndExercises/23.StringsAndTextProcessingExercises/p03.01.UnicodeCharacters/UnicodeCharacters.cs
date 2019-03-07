namespace p03._01.UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            IEnumerable<string> chars = input
                .Select(c => (int)c)
                .Select(c => $@"\u{c:x4}");

            string result = string.Concat(chars);

            Console.WriteLine(result);
        }
    }
}
