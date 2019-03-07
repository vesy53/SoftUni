namespace p04._03.CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class CubicMessages3
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            while (input.Equals("Over!") == false)
            {
                int length = int.Parse(Console.ReadLine());

                Regex pattern = new Regex
                (
                    $@"^\d+(?<message>[A-Za-z]{{{length}}})[^A-Za-z]*$"
                );

                Match match = pattern.Match(input);

                if (match.Success)
                {
                    char[] indexes = input.Where(x => char.IsDigit(x)).ToArray();
                    string message = match.Groups["message"].Value;

                    string encryptedMessage = string.Empty;

                    for (int i = 0; i < indexes.Count(); i++)
                    {
                        int currIndex = int.Parse(indexes[i].ToString());

                        if (currIndex > message.Length - 1)
                        {
                            encryptedMessage += " ";
                        }
                        else
                        {
                            encryptedMessage += message[currIndex];
                        }
                    }

                    result.AppendLine($"{message} == {encryptedMessage}");
                }

                input = Console.ReadLine();
            }

            Console.Write(result);
        }
    }
}
