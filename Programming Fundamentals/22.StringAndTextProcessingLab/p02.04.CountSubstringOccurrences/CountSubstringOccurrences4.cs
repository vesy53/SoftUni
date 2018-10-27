namespace p02._04.CountSubstringOccurrences
{
    using System;

    class CountSubstringOccurrences4
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()
                .ToLower();
            string searcStr = Console.ReadLine()
                .ToLower();

            int count = 0;
            int lastIndex = -1;

            while (true)
            {
                int index = text.IndexOf(searcStr, lastIndex + 1);

                if (index != -1)
                {
                    count++;
                    lastIndex = index;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
