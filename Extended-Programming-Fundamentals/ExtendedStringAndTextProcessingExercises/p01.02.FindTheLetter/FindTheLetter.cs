namespace p01._02.FindTheLetter
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

            int index = -1;

            for (int i = 0; i < searchIndex; i++)
            {
                if (index > text.Length)
                {
                    break;
                }

                index++;

                index = text.IndexOf(searchLetter, index);
            }

            if (index == -1)
            {
                Console.WriteLine("Find the letter yourself!");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
