using System;

namespace p05Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = 2 * num - 1;
            int height = 2 * (num - 2) + 1;

            for (int i = 1; i <= num - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("{0}\\ /{0}",
                        new string('*', num - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}",
                        new string('-', num - 2));
                }
            }

            Console.WriteLine("{0}@{0}",
                new string(' ',num - 1));

            for (int i = 1; i <= num - 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("{0}/ \\{0}",
                        new string('*', num - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}",
                        new string('-', num - 2));
                }
            }
        }
    }
}
