using System;

namespace p05Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 5;
            int dots = num;
            int dies = num * 3;

            for (int i = 0; i < num / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', dots),
                    new string('#', dies));

                dots++;
                dies -= 2;
            }

            dots = num + num / 2;
            int innerDots = num * 2 - 2;

            for (int i = 0; i < num / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', dots),
                    new string('.', innerDots));

                dots++;
                innerDots -= 2;
            }

            Console.WriteLine("{0}{1}{0}",
                new string('.', num * 2),
                new string('#', num));

            for (int i = 0; i < num + 2; i++)
            {
                if (i == num / 2)
                {
                    Console.WriteLine("{0}D^A^N^C^E^{0}",             
                        new string('.', (width - 10) / 2));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', num * 2 - 2),
                        new string('#', num + 4));
                }               
            }
        }
    }
}
