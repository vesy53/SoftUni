using System;
using System.Linq;

class ByteFlip3
{
    static void Main(string[] args)
    {
        var symbols = Console.ReadLine()
            .Split(' ')
            .Where(x => x.Length == 2)
            .Select(x => new string(x.Reverse().ToArray()))
            .Select(x => Convert.ToChar(Convert.ToInt32(x, 16)))
            .Reverse()
            .ToList();

        Console.WriteLine(string.Join("", symbols));
       
        //second method per print
        //Console.WriteLine(string.Join(null, symbols));
    }
}

