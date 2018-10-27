namespace p01._01.ReverseString
{
    using System;

    class ReverseString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string reversed = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
