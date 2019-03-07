namespace p03._02.UnicodeCharacters
{
    using System;

    class UnicodeCharacters2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var symbol in input)
            {
                Console.Write($"\\u{(int)symbol:x4}");
            }

            Console.WriteLine();
        }
    }
}
