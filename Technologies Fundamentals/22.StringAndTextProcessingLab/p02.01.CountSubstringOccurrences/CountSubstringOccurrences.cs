namespace p02._01.CountSubstringOccurrences
{
    using System;

    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()
                .ToLower();
            string searchText = Console.ReadLine()
                .ToLower();

            int index = text.IndexOf(searchText);
            int count = 0;

            while (index != -1)
            {
                count++;
                index = text.IndexOf(searchText, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
