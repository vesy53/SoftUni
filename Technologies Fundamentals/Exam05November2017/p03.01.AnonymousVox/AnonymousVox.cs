namespace p03._01.AnonymousVox
{
    using System;
    using System.Text.RegularExpressions;

    class AnonymousVox
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            string[] placeholders = Console.ReadLine()
                .Split(new char[] { '{', '}' },
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Regex pattern = new Regex(@"([a-zA-Z]+)(.+)(\1)");

            MatchCollection matches = pattern.Matches(encodedText);

            int index = 0;

            foreach (Match item in matches)
            {
                if (index < placeholders.Length)
                {
                    string currentValue = placeholders[index];
                    Regex regex = new Regex(Regex.Escape(item.Groups[2].Value));
                    encodedText = regex.Replace(encodedText, placeholders[index], 1);
                }

                index++;
            }

            Console.WriteLine(encodedText);
        }
    }
}
