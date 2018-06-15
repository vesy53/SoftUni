using System;

namespace p05InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (!(num == 0 || num >= 100 && num <= 200))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
