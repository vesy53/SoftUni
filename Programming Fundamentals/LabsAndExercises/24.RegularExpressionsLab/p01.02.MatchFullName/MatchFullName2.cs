namespace p01._02.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    class MatchFullName2
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b";

            string names = Console.ReadLine();

            MatchCollection matchNames = Regex.Matches(names, pattern);

            foreach (Match name in matchNames)
            {
                Console.Write(name.Value + " ");
                //second method per print (equals)
                //Console.Write(name.Groups[0] + " ");
            }

            Console.WriteLine();
        }
    }
}
