using System;
using System.Linq;

class AverageCharacterDelimiter1
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine()
            .Split()
            .ToArray();

        char[] charArr = string
            .Join(string.Empty, text)
            .ToCharArray();

        int sum = 0;

        foreach (var letter in charArr)
        {
            sum += letter;
        }

        int length = charArr.Length;
        char convertCharAverage = (char)(sum / length);

        char delimeter = char.ToUpper(convertCharAverage);

        Console.WriteLine(string.Join($"{delimeter}", text));
    }
}

