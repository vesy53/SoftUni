using System;

namespace p01X
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int height = num;
            int space = num - 2;

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("{0}x{1}x{0}",
                    new string(' ', i),
                    new string(' ', space));

                space -= 2;
            }

            Console.WriteLine("{0}x", 
                new string(' ', num / 2));

            space = 1;
            for (int i = num / 2 - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}x{1}x{0}",
                   new string(' ', i),
                   new string(' ', space));

                space += 2;
            }
        }
    }
}
