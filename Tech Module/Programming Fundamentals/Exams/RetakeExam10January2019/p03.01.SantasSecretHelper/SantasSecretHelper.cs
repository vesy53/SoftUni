namespace p03._01.SantasSecretHelper
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class SantasSecretHelper
    {
        static void Main(string[] args)
        {
            int numKey = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Regex pattern = new Regex(
                $"@(?<name>[A-Za-z]*)[^@\\-!:>]*!(?<behaviour>[G|N])!");

            StringBuilder builder = new StringBuilder();

            while (input.Equals("end") == false)
            {
                string message = DecodingMessage(numKey, input);

                Match match = pattern.Match(message);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string behaviour = match.Groups["behaviour"].Value;

                    if (behaviour == "G")
                    {
                        builder.AppendLine($"{name}");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(builder.ToString().Trim());
        }

        private static string DecodingMessage(int numKey, string input)
        {
            string message = string.Empty;

            foreach (char @char in input)
            {
                int sum = @char - numKey;
                message += Convert.ToChar(sum);
            }

            return message;
        }
    }
}
