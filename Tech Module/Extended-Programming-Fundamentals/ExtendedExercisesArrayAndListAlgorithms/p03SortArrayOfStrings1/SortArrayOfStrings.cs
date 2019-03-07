using System;
using System.Linq;

class SortArrayOfStrings
{
    static void Main(string[] args)
    {
        string[] text = Console.ReadLine()
            .Split()
            .ToArray();

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = i + 1; j < text.Length; j++)
            {
                string firstElement = text[i];
                string secondElement = text[j];

                bool firstIsSmaller = firstElement
                    .CompareTo(secondElement) == -1 ?
                    true :
                    false;

                if (!firstIsSmaller)
                {
                    text[i] = secondElement;
                    text[j] = firstElement;
                }
            }
        }  

        Console.WriteLine(string.Join(" ", text));
    }
}

