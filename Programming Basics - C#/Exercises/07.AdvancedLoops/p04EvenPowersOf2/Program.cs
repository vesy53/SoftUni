using System;

namespace p04EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);

            for (int i = 1; i <= n / 2; i++)
            {
                num *= 4;
                Console.WriteLine(num);
            }
        }
    }
}
