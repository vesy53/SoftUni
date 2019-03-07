namespace p06._01.SentenceSplit
{
    using System;

    class SentenceSplit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string delimeter = Console.ReadLine();

            string[] inputTokens = input
                .Split(new string[] { delimeter },
                    StringSplitOptions
                    .None);

           Console.WriteLine("[" + string.Join(", ", inputTokens) + "]");
        }
    }
}
