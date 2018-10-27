using System;
using System.Collections.Generic;
using System.Linq;

class TakeSkipRope2
{
    static void Main(string[] args)
    {
        List<char> input = Console.ReadLine()
           .ToList();

        List<int> extractedDigits = new List<int>();
        List<char> extractedLetters = new List<char>();

        List<int> takeList = new List<int>();
        List<int> skipList = new List<int>();

        for (int i = 0; i < input.Count; i++)
        {
            if (input[i].ToString().All(char.IsDigit))
            {
                extractedDigits.Add(int.Parse(input[i].ToString()));
            }
            else
            {
                extractedLetters.Add(input[i]);
            }
        }

        for (int i = 0; i < extractedDigits.Count; i++)
        {
            if (i % 2 == 0)
            {
                takeList.Add(extractedDigits[i]);
            }
            else
            {
                skipList.Add(extractedDigits[i]);
            }
        }

        int total = 0;

        for (int i = 0; i < takeList.Count; i++)
        {
            List<char> result = extractedLetters
                .Skip(total)
                .Take(takeList[i])
                .ToList();

            Console.Write(string.Join("", result));

            total += skipList[i] + takeList[i];
        }

        Console.WriteLine();
    }
}

