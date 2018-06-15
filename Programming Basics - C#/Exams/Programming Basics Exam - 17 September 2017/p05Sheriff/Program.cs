using System;

namespace p05Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 3;
            int height = num * 2 + 8;

            Console.WriteLine("{0}x{0}",
                new string('.', width / 2));

            Console.WriteLine("{0}/x\\{0}",
                new string('.', width / 2 - 1));

            Console.WriteLine("{0}x|x{0}",
                new string('.', width / 2 - 1));

            int dots = width / 2 - num;
            int hix = num;

            for (int i = 0; i < num / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dots),
                    new string('x', hix));

                dots--;
                hix++;
            }

            hix = width / 2 - 1;

            for (int i = 1; i <= num / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', i),
                    new string('x', hix));

                hix--;
            }

            Console.WriteLine("{0}/x\\{0}",
               new string('.', width / 2 - 1));

            Console.WriteLine("{0}\\x/{0}",
               new string('.', width / 2 - 1));

             dots = width / 2 - num;
             hix = num;

            for (int i = 0; i < num / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', dots),
                    new string('x', hix));

                dots--;
                hix++;
            }

            hix = width / 2 - 1;

            for (int i = 1; i <= num / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}",
                    new string('.', i),
                    new string('x', hix));

                hix--;
            }

            Console.WriteLine("{0}x|x{0}",
           new string('.', width / 2 - 1));

            Console.WriteLine("{0}\\x/{0}",
                new string('.', width / 2 - 1));

            Console.WriteLine("{0}x{0}",
                new string('.', width / 2));
        }
    }
}
