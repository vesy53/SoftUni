namespace p03._03.CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class CameraView3
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)             
                .ToArray();
            int skip = numbers[0];
            int take = numbers[1];

            string input = Console.ReadLine();

            string pattern = $@"(\|<)\w{{{skip}}}(?<foundMatch>\w{{1,{take}}})";
            //string pattern = @"\|<([\w]{" + skip + @"})([\w]{0," + take + @"})";
            //($@"(\|<)[\w\s]{skipElements}([\w\s]{takeElements})");

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.Groups["foundMatch"].Value);
                //result.Add(match.Groups[2].Value);                
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
