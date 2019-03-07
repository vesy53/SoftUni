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
            for (int j = 0; j < text.Length - 1; j++)
            {
                int result = text[j].CompareTo(text[j + 1]);

                if (result > 0)
                {
                    string temp = text[j];
                    text[j] = text[j + 1];
                    text[j + 1] = temp;
                }
                
            }         
        }

        Console.WriteLine(string.Join(" ", text));
    }
}

