namespace P02._02.CountSubstringOccurrences
{
    using System;
    using System.Linq;

    class CountSubstringOccurrences2
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()
                .ToLower();
            string searchText = Console.ReadLine()
                .ToLower();

            int count = text
                .Select((c, i) => text.Substring(i))
                .Count(sub => sub.StartsWith(searchText));

            Console.WriteLine(count);
        }
    }
}
