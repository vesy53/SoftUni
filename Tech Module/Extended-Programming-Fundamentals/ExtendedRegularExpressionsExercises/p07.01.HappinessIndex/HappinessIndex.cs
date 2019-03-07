namespace p07._01.HappinessIndex
{
    using System;
    using System.Text.RegularExpressions;

    class HappinessIndex
    {
        static void Main(string[] args)
        {
            Regex happyPattern = new Regex(@":\)|:D|;\)|:\*|:]|;]|:\}|;\}|\(:|\*:|c:|\[:|\[;");
            Regex sadPattern = new Regex(@":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|\];");

            string inputEmoticons = Console.ReadLine();

            MatchCollection happinesMatch = happyPattern.Matches(inputEmoticons);
            MatchCollection sadMatch = sadPattern.Matches(inputEmoticons);

            double happyEmoticonCount = happinesMatch.Count;
            int sadEmoticonsCount = sadMatch.Count;

            double index = happyEmoticonCount / sadEmoticonsCount;

            string status = string.Empty;

            if (index >= 2)
            {
                status =  ":D";
            }
            else if (index > 1)
            {
                status = ":)";
            }
            else if (index == 1)
            {
                status = ":|";
            }
            else if (index < 1)
            {
                status = ":(";
            }

            Console.WriteLine($"Happiness index: {index:F2} {status}");
            Console.WriteLine(
                $"[Happy count: {happyEmoticonCount}, Sad count: {sadEmoticonsCount}]");
        }
    }
}
