namespace p03._02.BoomingCannon
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class BoomingCannon2
    {
        static int[] parameters;
        static int startIndex;
        static int count;

        static bool isFirst = true;
        static string targetsShotedDown = string.Empty;

        static void Main(string[] args)
        {
            parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            startIndex = parameters[0];
            count = parameters[1];

            string target = Console.ReadLine();
            MatchAndShootOf(target);

            Console.WriteLine(targetsShotedDown);
        }

        static void MatchAndShootOf(string target)
        {
            string pattern = @"((?<=\\<<<)(?<target>.+?))(?=\\<<<|$)";
            //https://regex101.com/r/zUONtp/1/
            if (Regex.IsMatch(target, pattern))
            {
                MatchCollection currentTargets = Regex.Matches(target, pattern);

                foreach (Match match in currentTargets)
                {
                    ShootOf(match.Groups["target"].Value);
                }
            }
            else return;
        }

        static void ShootOf(string currentTarget)
        {
            string down = string.Empty;

            if (startIndex >= 0 && startIndex < currentTarget.Length)
            {
                down = SubstringFrom(currentTarget.Replace("\\<<<", string.Empty));
                AddToResult(down);
            }
            else return;
        }

        static void AddToResult(string down)
        {
            if (isFirst)
            {
                targetsShotedDown += down;
                isFirst = false;
                return;
            }

            targetsShotedDown += $"/\\{down}";
        }

        static string SubstringFrom(string currentTarget)
        {
            if (count >= 0 && startIndex + count < currentTarget.Length)
            {
                return currentTarget.Substring(startIndex, count);
            }
            else if (count >= 0 && startIndex + count >= currentTarget.Length)
            {
                return currentTarget.Substring(startIndex);
            }
            return string.Empty;
        }
    }
}
