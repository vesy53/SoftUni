namespace p03._02.CameraView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class CameraView2
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(?<=\|<)\w+");

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int skip = numbers[0];
            int take = numbers[1];

            string input = Console.ReadLine();

            MatchCollection matchCamera = pattern.Matches(input);

            List<string> result = new List<string>();

            foreach (Match match in matchCamera)
            {
                string camera = match.Value;

                char[] @chars = camera
                    .Skip(skip)
                    .Take(take)
                    .ToArray();

                string charResult = string.Join("", chars);
                
                result.Add(charResult);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
