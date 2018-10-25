namespace p03._01.CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class CameraView
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int skip = numbers[0];
            int take = numbers[1];

            string input = Console.ReadLine();

            Regex pattern = new Regex(@"\|<(?<text>\w+)");

            MatchCollection matchCamera = pattern.Matches(input);

            List<string> finalResult = new List<string>();

            foreach (Match match in matchCamera)
            {
                string text = match.Groups["text"].Value;

                char[] @chars = text
                    .Skip(skip)
                    .Take(take)
                    .ToArray();
               
                string result = string.Join("", @chars);

                finalResult.Add(result);
            }

            Console.WriteLine(string.Join(", ", finalResult));
        }
    }
}
