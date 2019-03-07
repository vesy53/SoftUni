namespace p01._01.FindTheLetter
{
    using System;

    class FindTheLetter
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] symbols = Console.ReadLine()
                .Split();

            char searchLetter = char.Parse(symbols[0]);
            int searchIndex = int.Parse(symbols[1]);

            int counter = 0;
            int index = 0;
            bool isSearch = false;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                if (currentLetter.Equals(searchLetter))
                {
                    counter++;

                    if (counter.Equals(searchIndex))
                    {
                        isSearch = true;
                        index = i;

                        break;
                    }
                }
            }

            string result = isSearch ?
                index.ToString() :
                "Find the letter yourself!";

            Console.WriteLine(result);
        }
    }
}
