using System;
using System.Linq;

class ByteFlip2
{
    static void Main(string[] args)
    {
        string[] symbols = Console.ReadLine()
            .Split()
            .Where(x => x.Length == 2)
            .Reverse()
            .ToArray();

        for (int i = 0; i < symbols.Length; i++)
        {
            char[] charArray = symbols[i].ToCharArray();
            Array.Reverse(charArray);
            Console.Write(System
                .Convert
                .ToChar(System
                    .Convert
                    .ToUInt32(new string(charArray), 16)));

        }

        //for (int i = symbols.Length - 1; i >= 0; i--)
        //{
        //    char[] charArray = symbols[i].ToCharArray();
        //    Array.Reverse(charArray);
        //    Console.Write(System.Convert.ToChar(System.Convert.ToUInt32(new string(charArray), 16)));
        //}

        Console.WriteLine();
    }
}

