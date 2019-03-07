namespace p04._01.CubicMessages
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class CubicMessages
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input.Equals("Over!") == false)
            {
                int length = int.Parse(Console.ReadLine());

                Regex pattern = new Regex
                (
                    $@"^(?<start>\d+)(?<message>[A-Za-z]{{{length}}})(?<final>[^A-Za-z]*)$"
                );

                Match match = pattern.Match(input);

                if (match.Success)
                {
                    string firstDigits = match.Groups["start"].Value;
                    string message = match.Groups["message"].Value;
                    string finalPart = match.Groups["final"].Value;

                    List<int> numbers = new List<int>();

                    for (int i = 0; i < firstDigits.Length; i++)
                    {
                        int currDigit = int.Parse(firstDigits[i].ToString());

                        numbers.Add(currDigit);
                    }

                    for (int i = 0; i < finalPart.Length; i++)
                    {
                        char currSymbol = finalPart[i];

                        if (char.IsDigit(currSymbol))
                        {
                            int currDigit = int.Parse(currSymbol.ToString());

                            numbers.Add(currDigit);
                        }
                    }

                    string encryptedMessage = string.Empty;

                    encryptedMessage = message + " == ";

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currNum = numbers[i];

                        if (currNum > message.Length - 1)
                        {
                            encryptedMessage += " ";
                        }
                        else
                        {
                            for (int j = currNum - 1; j < message.Length; j++)
                            {
                                if (currNum == j)
                                {
                                    encryptedMessage += message[j];
                                    break;
                                }
                            }
                        }
                    }

                    Console.WriteLine(encryptedMessage);
                }

                input = Console.ReadLine();
            }
        }
    }
}
