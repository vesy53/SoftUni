using System;
using System.Text;
using System.Text.RegularExpressions;

namespace p04._04.CubicMessages
{
    class CubicMessages4
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"^\d+([a-zA-Z]+)[^a-zA-Z]*$");

            string input = Console.ReadLine().Trim();

            while (input != "Over!")
            {
                int length = int.Parse(Console.ReadLine());

                if (pattern.IsMatch(input))
                {
                    string message = pattern.Match(input).Groups[1].ToString();

                    if (message.Length == length)
                    {
                        MatchCollection digits = Regex.Matches(input.Trim(), @"\d");

                        string result = string.Empty;

                        foreach (Match digitMatch in digits)
                        {
                            int index = int.Parse(digitMatch.Value);

                            if (index > message.Length - 1)
                            {
                                result += " ";
                            }
                            else
                            {
                                result += message[index];
                            }
                        }

                        Console.WriteLine($"{message} == {result}");
                    }
                }

                input = Console.ReadLine().Trim();
            }
        }
    }
}
