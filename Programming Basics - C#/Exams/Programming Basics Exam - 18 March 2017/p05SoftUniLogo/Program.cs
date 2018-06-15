using System;

namespace p05SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int height = num * 4 - 2;
            int width = num * 12 - 5;
            int dots = width / 2;
            int dies = 1;

            for (int i = 1; i <= num * 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", 
                    new string('.', dots),
                    new string('#', dies));

                dots -= 3;
                dies += 6;
            }

            dots = 2;
            dies = width - 6;
            int rightDots = 3;

            for (int i = 0; i < num - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", 
                    new string('.', dots),
                    new string('#', dies),
                    new string('.', rightDots));

                dots += 3;
                dies -= 6;
                rightDots += 3;
            }

            for (int i = 0; i < num - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}",
                    new string('.', num * 3 - 4),
                    new string('#', num * 6 + 1),
                    new string('.', num * 3 - 3));
            }

            Console.WriteLine("@{0}{1}{2}",
                    new string('.', num * 3 - 4),
                    new string('#', num * 6 + 1),
                    new string('.', num * 3 - 3));
        }
    }
}
