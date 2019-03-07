using System;
using System.Collections.Generic;
using System.Linq;

class DecodeRadioFrequencies
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', '.' },           
                   StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        List<char> symbolsEven = new List<char>();
        List<char> symbolsOdd = new List<char>();
        int length = numbers.Length;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNum = (int)numbers[i];

            if (currentNum == 0)
            {
                continue;
            }
            else
            {
                char numberChar = Convert.ToChar(currentNum);

                if (i % 2 != 0)
                {
                    symbolsOdd.Add(numberChar);
                }
                else
                {
                    symbolsEven.Add(numberChar);
                }
            }
        }

        for (int i = symbolsOdd.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(symbolsOdd[i]);
        }
       
        int lengthSymbolsEven = symbolsEven.Count;
        symbolsEven.InsertRange(lengthSymbolsEven, symbolsOdd);

        Console.WriteLine(string.Join("", symbolsEven));
    }
}

