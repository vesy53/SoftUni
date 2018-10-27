using System;

namespace p01HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            GetName(name);
        }

        static void GetName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
