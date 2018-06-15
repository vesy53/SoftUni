using System;

namespace p08Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', n * 2),
                new string(' ', n));

            for (int i = 0; i < n - 2; i++)
            {
                if (n % 2 == 0)
                {
                    if (i == ((n - 2) / 2) - 1)
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2),
                        new string('|', n));
                    }
                    else
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2),
                       new string(' ', n));
                    }
                }
                else
                {
                    if (i == ((n - 2) / 2))
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2),
                        new string('|', n));
                    }
                    else
                    {
                        Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2),
                       new string(' ', n));
                    }
                }             
            }

            Console.WriteLine("{0}{1}{0}", new string('*', n * 2),
                new string(' ', n));
        }
    }
}
