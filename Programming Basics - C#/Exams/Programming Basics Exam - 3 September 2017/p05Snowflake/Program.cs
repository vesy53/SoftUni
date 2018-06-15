using System;

namespace p05Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int height = num * 2 + 1;
            int width = num * 2 + 3;
            int dots = num;

            for (int i = 0; i < num - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', i),
                    new string('.', dots));

                dots--;
            }

            Console.WriteLine("{0}*****{0}",
                new string('.', num - 1));

            Console.WriteLine(new string('*', width));

            Console.WriteLine("{0}*****{0}",
                new string('.', num - 1));

            dots = num - 2;

            for (int i = 2; i <= num; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.', dots),
                    new string('.', i));

                dots--;
            }
        }
    }
}
