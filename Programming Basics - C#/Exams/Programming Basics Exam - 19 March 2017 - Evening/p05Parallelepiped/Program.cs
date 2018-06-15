using System;

namespace p05Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int height = num * 4 + 4;
            int width = num * 3 + 1;

            Console.WriteLine("+{0}+{1}",
                new string('~', num - 2),
                new string('.', num * 2 + 1));

            int dots = num * 2;

            for (int i = 0; i < num * 2 + 1; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",
                    new string('.', i),
                    new string('~', num - 2),
                    new string('.', dots));

                dots--;
            }

            dots = num * 2;

            for (int i = 0; i < num * 2 + 1; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|",
                    new string('.', i),
                    new string('.', dots),
                    new string('~', num - 2));

                dots--;
            }

            Console.WriteLine("{0}+{1}+",
                new string('.', num * 2 + 1),
                new string('~', num - 2));
        }
    }
}
