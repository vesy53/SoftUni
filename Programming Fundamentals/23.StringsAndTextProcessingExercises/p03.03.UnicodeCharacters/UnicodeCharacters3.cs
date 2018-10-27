namespace p03._03.UnicodeCharacters
{
    using System;

    class UnicodeCharacters3
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                int currentSymbol = (int)text[i];

                Console.Write($"\\u{currentSymbol:x4}");
            }

            Console.WriteLine();
        }
    }
}
