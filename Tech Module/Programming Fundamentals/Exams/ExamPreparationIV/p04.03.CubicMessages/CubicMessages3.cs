namespace p04._03.CubicMessages
{
    using System;
    using System.Text.RegularExpressions;

    class CubicMessages3
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^\d+(?<message>[a-zA-Z]+)[^a-zA-Z]*$");

            string input = Console.ReadLine();

            while (input != "Over!")
            {
                int length = int.Parse(Console.ReadLine());

                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);

                    string message = match.Groups["message"].Value;

                    if (message.Length == length)
                    {
                        string decryptedMsg = ExtractIndices(input, message);

                        Console.WriteLine($"{message} == {decryptedMsg}");
                    }
                }

                input = Console.ReadLine();
            }
        }

        static string ExtractIndices(string input, string message)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int index = input[i] - '0';

                    if (index < message.Length)
                    {
                        result += message[index];
                    }
                    else
                    {
                        result += " ";
                    }
                }
            }

            return result;
        }
    }
}
