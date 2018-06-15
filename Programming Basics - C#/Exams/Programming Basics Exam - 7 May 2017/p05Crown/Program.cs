using System;

namespace p05Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = (2 * num) - 1;
            int height = (num / 2) + 4;

            Console.WriteLine("@{0}@{0}@",
                new string(' ', num - 2));

            Console.WriteLine("**{0}*{0}**",
                new string(' ', num - 3));

            int spase = num - 5;
            int innerDash = 1;

            for (int i = 1; i <= num / 2 - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                    new string('.', i),
                    new string(' ', spase),
                    new string('.', innerDash));

                innerDash += 2;
                spase -= 2;
            }

            Console.WriteLine("*{0}*{1}*{0}*",
                new string('.', num / 2 - 1),
                new string('.', num - 3));

            Console.WriteLine("*{0}{1}.{1}{0}*",
                new string('.', num / 2),
                new string('*', num / 2 - 2));

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(new string('*',width));
            }
        }
    }
}
