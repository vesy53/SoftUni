using System;

namespace p05ChristmasSock
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int height = num * 3 + 3;

            Console.WriteLine("|{0}|",
                new string('-', num * 2));

            Console.WriteLine("|{0}|",
                new string('*', num * 2));

            Console.WriteLine("|{0}|",
                new string('-', num * 2));

            int dashes = num - 1;
            int symbol = 2;

            for (int i = 1; i <= num - 1; i++)
            {
                Console.WriteLine("|{0}{1}{0}|",
                    new string('-', dashes),
                    new string('~', symbol));

                dashes--;
                symbol += 2;
            }

            dashes = 2;
            symbol = num * 2 - 4;

            for (int i = 0; i < num - 2; i++)
            {
                Console.WriteLine("|{0}{1}{0}|",
                    new string('-', dashes),
                    new string('~', symbol));

                dashes++;
                symbol -= 2; 
            }

            for (int i = 0; i < num + 2; i++)
            {
                if (i == num / 2)
                {
                    Console.WriteLine("{0}\\{1}MERRY{1}\\",
                    new string('-', i),
                    new string('.', num - 2));
                }
                else if (i == num / 2 + 2)
                {
                    Console.WriteLine("{0}\\{1}X-MAS{1}\\",
                    new string('-', i),
                    new string('.', num - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\{1}\\",
                    new string('-', i),
                    new string('.', num * 2 + 1));
                }
            }

            Console.WriteLine("{0}\\{1})",
                new string('-', num + 2),
                new string('_', num * 2 + 1));
        }
    }
}
