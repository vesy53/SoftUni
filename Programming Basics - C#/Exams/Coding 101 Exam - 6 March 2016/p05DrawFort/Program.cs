using System;

namespace p05DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = 2 * num;
            int height = num;
            int col = num / 2;
            int dash = width - 2 * col - 4;

            Console.WriteLine("/{0}\\{1}/{0}\\",
                new string('^', num / 2),
                new string('_', dash));

            for (int i = 1; i <=num - 3; i++)
            {
                Console.WriteLine("|{0}|",
                    new string(' ', num * 2 - 2));
            }

            Console.WriteLine("|{0}{1}{0}|",
                new string(' ', col + 1),
                new string('_', dash));

            Console.WriteLine("\\{0}/{1}\\{0}/ ",
                new string('_', num / 2),
                new string(' ', dash));
        }
    }
}
