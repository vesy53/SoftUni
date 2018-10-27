using System;

namespace p03StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string repeatedString = RepeatString(text, count);

            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string text, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += text;
            }

            return repeatedString;
        }
    }
}
