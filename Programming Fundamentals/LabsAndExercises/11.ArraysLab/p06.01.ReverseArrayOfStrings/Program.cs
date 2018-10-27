using System;

namespace p06ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine()
                .Split(' ');

            for (int i = 0; i < symbols.Length / 2 ; i++)
            {
                ReverseStringsArray(symbols, i, symbols.Length - 1 - i);       
            }

            Console.WriteLine(string.Join(" ", symbols));
        }

        static void ReverseStringsArray(string[] symbols, int i, int j)
        {       
            string temp = symbols[i];
            symbols[i] = symbols[j];
            symbols[j] = temp;
        }
    }
}
