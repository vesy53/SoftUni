using System;

namespace p05Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 2 + 1;
            int height = width;

            Console.WriteLine(new string('*', width));

            Console.WriteLine(".*{0}*.",
                new string(' ', width - 4));

            int et = num * 2 - 5;

            for (int i = 2; i <=num - 1; i ++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', i),
                    new string('@', et));

                et -= 2;
            }

            Console.WriteLine("{0}*{0}",
                new string('.', width / 2));

            int dots = num - 1;

            for (int i = 0; i < num - 2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}",
                    new string('.', dots),
                    new string(' ', i));

                dots--;
            }

            Console.WriteLine(".*{0}*.",
                new string('@', width - 4));

            Console.WriteLine(new string('*', width));
        }
    }
}
