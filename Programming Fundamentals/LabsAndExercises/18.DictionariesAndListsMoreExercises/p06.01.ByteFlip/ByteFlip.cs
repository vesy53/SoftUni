using System;
using System.Collections.Generic;
using System.Linq;

class ByteFlip
{
    static void Main(string[] args)
    {
        List<string> symbols = Console.ReadLine()
            .Split()
            .Reverse()
            .ToList();

        for (int i = 0; i < symbols.Count; i++)
        {
            if (symbols[i].Length != 2)
            {
                symbols.RemoveAt(i);
                i--;
            }          
        }

        for (int i = 0; i < symbols.Count; i++)
        {
            string reversedNum = new string(symbols[i]
                .ToCharArray()
                .Reverse()
                .ToArray());
            symbols[i] = reversedNum;
        }

        foreach (string hex in symbols)
        {
            int value = Convert.ToInt32(hex, 16);

            Console.Write((char)value);
        }

        Console.WriteLine();
    }
}

