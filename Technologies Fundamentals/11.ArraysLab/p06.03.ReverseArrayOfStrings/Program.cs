using System;
using System.Linq;

namespace p06ReverseArrayOfStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine()
                .Split(' ')
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(" ", symbols));
        }
    }
}
