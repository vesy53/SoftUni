namespace p01._01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    class MatchFullName
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection matchNames = pattern.Matches(names);

            foreach (Match name in matchNames)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();
        }
    }
}
