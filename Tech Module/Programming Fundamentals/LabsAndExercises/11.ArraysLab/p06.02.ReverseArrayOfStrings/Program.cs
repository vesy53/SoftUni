using System;

namespace p06ReverseArrayOfStrings1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine()
                .Split(' ');

            Array.Reverse(symbols);

            foreach (var s in symbols)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine();
        }
    }
}
