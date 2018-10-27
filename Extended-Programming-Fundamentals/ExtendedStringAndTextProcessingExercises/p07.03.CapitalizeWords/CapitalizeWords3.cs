namespace p07._03.CapitalizeWords
{
    using System;

    class CapitalizeWords3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] elements = input
                    .ToLower()
                    .Split(new[] { ' ', '.', ',', ':', ';', '?', '!', '-' },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string currentWord = elements[i];

                    string firstLetter = currentWord[0]
                        .ToString()
                        .ToUpper();

                    elements[i] = firstLetter + currentWord.Substring(1);
                }

                Console.WriteLine(string.Join(", ", elements));

                input = Console.ReadLine();
            }
        }
    }
}
