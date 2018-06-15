using System;

namespace p05Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 5;
            int rightDashes = num * 2 - 2;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', num * 3),
                    new string('-', i),
                    new string('-', rightDashes));

                rightDashes--;
            }

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("{0}{1}*{1}",
                    new string('*', num * 3 + 1),
                    new string('-', num - 1));
            }

            int leftDashes = num * 3;
            int innerDashes = num - 1;
            rightDashes = num - 1;

            for (int i = 0; i < num / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('-', innerDashes),
                    new string('-', rightDashes));

                leftDashes--;
                innerDashes += 2;
                rightDashes--;
            }

            if (num % 2 == 0)
            {
                Console.WriteLine("{0}{1}{2}",
                                new string('-', (width - (num * 2 - 1) - (num / 2))),
                                new string('*', num * 2 - 1),
                                new string('-', num / 2));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}",
                    new string('-', (width - (num * 2 - 2) - (num / 2 + 1))),
                    new string('*', num * 2 - 2),
                    new string('-', num / 2 + 1));
            }
        }
    }
}
