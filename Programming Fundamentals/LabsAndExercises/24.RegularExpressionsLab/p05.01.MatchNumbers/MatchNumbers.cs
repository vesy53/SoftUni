namespace p05._01.MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;

    class MatchNumbers
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"(^|(?<=\s))-?(\d)+(\.)?(\d+)?($|(?=\s))"
            );

            string numbers = Console.ReadLine();

            MatchCollection matchNumbers = pattern.Matches(numbers);

            foreach (Match num in matchNumbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
