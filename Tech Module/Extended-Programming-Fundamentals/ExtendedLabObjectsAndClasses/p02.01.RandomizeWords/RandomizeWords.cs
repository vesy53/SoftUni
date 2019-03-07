using System;
using System.Linq;

class RandomizeWords
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine()
            .Split();

        Random rnd = new Random();

        for (int i = 0; i < text.Length; i++)
        {
            int index = rnd.Next(text.Length);

            string temp = text[i];
            text[i] = text[index];
            text[index] = temp;
        }

        text.ToList().ForEach(Console.WriteLine);
    }
}

