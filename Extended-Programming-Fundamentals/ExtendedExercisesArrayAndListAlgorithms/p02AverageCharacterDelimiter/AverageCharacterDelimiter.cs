using System;
using System.Linq;

class AverageCharacterDelimiter
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine()
            .Split()
            .ToArray();

        int sum = 0;
        int counter = 0;

        foreach (var word in text)
        {
            foreach (var w in word)
            {
                sum += w;
                counter++;
            }
        }

        int average = sum / counter;

        char symbol = (char)average;

        if (symbol >= 'a' && symbol <= 'z')
        {
           symbol =  Char.ToUpper(symbol);
        }
     
        Console.WriteLine(string.Join($"{symbol}", text));
    }
}

