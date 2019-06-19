namespace p01._01.Regeh
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Regeh
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(
                @"\[[^[\] ]+?<(?<firstNum>\d+)REGEH(?<secNum>\d+)>[^[\] ]+\]");

            MatchCollection matches = pattern.Matches(input);

            Queue<int> indices = new Queue<int>();

            foreach (Match match in matches)
            {
                int firstNum = int.Parse(match.Groups["firstNum"].Value);
                int secondNum = int.Parse(match.Groups["secNum"].Value);
                indices.Enqueue(firstNum);
                indices.Enqueue(secondNum);
            }

            int index = 0;
            string result = string.Empty;

            while (indices.Count > 0)
            {
                index += indices.Dequeue();
                index = index % (input.Length - 1);
                result += input[index];
            }

            Console.WriteLine(result);
        }
    }
}