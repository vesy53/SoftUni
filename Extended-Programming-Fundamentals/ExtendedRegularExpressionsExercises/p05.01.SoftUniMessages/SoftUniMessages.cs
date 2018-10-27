namespace p05._01.SoftUniMessages
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class SoftUniMessages 
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex
            (
                @"^\d+[A-Za-z]+[^A-Za-z]*(\d+)$"
            );

            string input = Console.ReadLine();

            while (input.Equals("Decrypt!") == false)
            {
                int length = int.Parse(Console.ReadLine());

                if (pattern.IsMatch(input))
                {
                    List<char> letters = new List<char>();
                    List<int> numbers = new List<int>();
                    StringBuilder builder = new StringBuilder();

                    foreach (var symbol in input)
                    {
                        if (char.IsDigit(symbol))
                        {
                            numbers.Add(symbol - 48);
                        }
                        else if (char.IsLetter(symbol))
                        {
                            letters.Add(symbol);
                        }
                    }

                    if (length == letters.Count)
                    {
                        foreach(var num in numbers)
                        {
                            if (num < letters.Count)
                            {
                                char currentLetter = letters[num];
                                builder.Append(currentLetter);
                            }
                        }

                        Console.WriteLine(
                            $"{string.Join("", letters)} = {builder}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
