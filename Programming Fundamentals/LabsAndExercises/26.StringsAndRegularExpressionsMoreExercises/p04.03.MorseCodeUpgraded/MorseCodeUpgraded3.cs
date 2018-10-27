namespace p04._03.MorseCodeUpgraded
{
    using System;
    using System.Text.RegularExpressions;

    class MorseCodeUpgraded3
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|');

            string result = string.Empty;

            foreach (var morse in input)
            {
                int sum = 0;

                int zeroesCount = Regex.Matches(Regex.Escape(morse), "0").Count;
                int onesCount = Regex.Matches(Regex.Escape(morse), "1").Count;

                sum = onesCount * 5 + zeroesCount * 3;

                Regex sequences = new Regex(@"0{2,}|1{2,}");

                var matchedSequences = sequences.Matches(morse);

                foreach (Match sequence in matchedSequences)
                {
                    sum += sequence.Length;
                }

                result += (char)sum;
            }

            Console.WriteLine(result);
        }
    }
}
