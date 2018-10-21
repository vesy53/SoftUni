namespace p04._01.CubicMessages
{
    using System;
    using System.Text.RegularExpressions;

    class CubicMessages2
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("Over!") == false)
            {
                int length = int.Parse(Console.ReadLine());

                Regex pattern = new Regex
                (
                    $@"^(?<nums>\d+)(?<text>[A-Za-z]{{{length}}})(?<final>[^A-Za-z]*)$"
                );

                Match matchMessage = pattern.Match(input);

                if (matchMessage.Success)
                {
                    string number = matchMessage.Groups["nums"].Value;
                    string text = matchMessage.Groups["text"].Value;
                    string final = matchMessage.Groups["final"].Value;

                    string firstPart = EncryptedMessage(number, text);
                    string secondPart = EncryptedMessage(final, text);

                    string result = firstPart + secondPart;

                    Console.WriteLine($"{text} == {result}");
                }

                input = Console.ReadLine();
            }
        }

        static string EncryptedMessage(string number, string text)
        {
            string result = string.Empty;

            foreach (var num in number)
            {
                if (char.IsDigit(num))
                {
                    int index = int.Parse(num.ToString());

                    if (index < text.Length)
                    {
                        result += text[index];
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
