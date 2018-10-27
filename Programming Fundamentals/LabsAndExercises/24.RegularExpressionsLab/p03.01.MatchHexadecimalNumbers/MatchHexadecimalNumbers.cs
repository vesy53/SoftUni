namespace p03._01.MatchHexadecimalNumbers
{
    using System;
    using System.Text.RegularExpressions;

    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(0x)?[0-9A-F]+\b");

            string hexadecimalNums = Console.ReadLine();

            MatchCollection matchHexadecimalNums = pattern.Matches(hexadecimalNums);

            foreach (Match hexadecimalNum in matchHexadecimalNums)
            {
                Console.Write(hexadecimalNum + " ");
            }

            Console.WriteLine();
        }
    }
}
