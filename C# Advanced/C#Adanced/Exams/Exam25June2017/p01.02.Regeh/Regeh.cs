namespace p01._02.Regeh
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Regeh
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex
                (@"\[[a-zA-Z]+<(?<firstNum>\d+)REGEH(?<secNum>\d+)>[a-zA-Z]+\]");

            MatchCollection matches = pattern.Matches(input);

            List<int> indices = new List<int>();

            foreach (Match match in matches)
            {
                int firstNum = int.Parse(match.Groups["firstNum"].Value);
                int secondNum = int.Parse(match.Groups["secNum"].Value);

                indices.Add(firstNum);
                indices.Add(secondNum);
            }

            int currIndex = 0;
            string result = string.Empty;

            foreach (int index in indices)
            {
                currIndex += index;
                currIndex = currIndex % (input.Length - 1);

                result += input[currIndex];
            }

            Console.WriteLine(result);
        }
    }
}