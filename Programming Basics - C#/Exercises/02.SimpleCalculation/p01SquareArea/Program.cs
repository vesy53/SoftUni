using System;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());

            var area = a * a;

            Console.WriteLine("Square = {0}", area);
        }
    }
}
