namespace p07._01.Hideout
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Hideout
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();

            bool isFound = false;

            while (!isFound)
            {
                var specialChars = @"/.*+?|(,)[]{}\";

                var @char = Console.ReadLine().Split();
                var clueChar = @char.First();
                clueChar = specialChars.Contains(clueChar) ?
                    @"\" + clueChar :
                    clueChar;
                int minCount = int.Parse(@char.Last());

                Match match = Regex.Match(map, $"[{clueChar}]{{{minCount},}}");
                isFound = match.Success;

                if (isFound)
                {
                    var index = match.Index;
                    var length = match.Value.Length;

                    Console.WriteLine(
                        $"Hideout found at index {index} and it is with size {length}!");
                }
            }
        }
    }
}
