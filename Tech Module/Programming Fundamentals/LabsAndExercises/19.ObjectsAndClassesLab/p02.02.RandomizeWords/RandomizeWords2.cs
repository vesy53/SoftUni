using System;
using System.Collections.Generic;
using System.Linq;

class RandomizeWords2
{
    static void Main(string[] args)
    {
        List<string> text = Console.ReadLine()
            .Split()
            .ToList();

        Random rnd = new Random();

        for (int i = 0; i < text.Count; i++)
        {
            int index = rnd.Next(0, text.Count);

            string temp = text[i];
            text[i] = text[index];
            text[index] = temp;
        }

        Console.WriteLine(
            string.Join(Environment.NewLine, text));
    }
}