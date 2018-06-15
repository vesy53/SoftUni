using System;

namespace p05Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 2 + 3;
            int innerDashes = width - 4;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('*', i),
                    new string('-', innerDashes));

                innerDashes -= 2;
            }

            int dashes = num / 2;
            innerDashes = num;

            for (int i = 1; i <= num / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|",
                    new string('*', dashes),
                    new string('*', innerDashes));

                dashes++;
                innerDashes -= 2;
            }

            int innerStars = width - 4;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('-', i),
                    new string('*', innerStars));

                innerStars -= 2;
            }
        }
    }
}
