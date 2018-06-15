using System;

namespace p05Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 3;
            int dots = width / 2 - 1;
            int spase = 0;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', dots),
                    new string(' ', spase));

                dots--;
                spase += 2;
            }

            Console.WriteLine("{0}{1}{0}",
                new string('.', num / 2),
                new string('*', num * 2));

            for (int i = 0; i < num * 2; i++)
            {
                Console.WriteLine("{0}|{1}|{0}",
                    new string('.', num / 2),
                    new string('\\', num * 2 - 2));
            }

            dots = num / 2;
            int stars = num * 2 - 2;

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}",
                    new string('.', dots),
                    new string('*', stars));

                dots--;
                stars += 2;
            }
        }
    }
}
