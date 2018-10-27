namespace p02._03.CountSubstringOccurrences
{
    using System;

    class CountSubstringOccurrences3
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()
                .ToLower();
            string searchText = Console.ReadLine()
                .ToLower();

            int index = text.IndexOf(searchText);
            int count = 0;

            while (index >= 0)
            {
                count++;
                index = text.IndexOf(searchText, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
