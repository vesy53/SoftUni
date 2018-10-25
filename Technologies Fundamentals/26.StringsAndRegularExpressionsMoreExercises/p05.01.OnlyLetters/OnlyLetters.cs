namespace p05._01.OnlyLetters
{
    using System;
    using System.Text.RegularExpressions;

    class OnlyLetters
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            Regex pattern = new Regex(@"(?<num>[0-9]+)(?<letter>[a-zA-Z])");

            MatchCollection matchNum = pattern.Matches(message);
            
            foreach (Match item in matchNum)
            {
                string num = item.Groups["num"].Value;
                string letter = item.Groups["letter"].Value;
                
                message = message.Replace(num, letter);
            }

            Console.WriteLine(message);
        }
    }
}
