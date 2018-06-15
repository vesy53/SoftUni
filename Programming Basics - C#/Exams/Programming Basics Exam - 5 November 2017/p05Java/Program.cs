using System;

namespace p05Java
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = num * 3 + 6;
            int height = num * 3 + 1;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}~ ~ ~",
                new string(' ', num));
            }

            Console.WriteLine(new string('=', width - 1));

            for (int i = 1; i <= num - 2; i++)
            {
                if (i == num / 2)
                {
                    Console.WriteLine("|{0}JAVA{0}|{1}|",
                        new string('~', num),
                        new string(' ', num - 1));
                }
                else
                {
                    Console.WriteLine("|{0}|{1}|",
                        new string('~', num * 2 + 4),
                        new string(' ', num - 1));
                }
            }

            Console.WriteLine(new string('=', width - 1));

            int aMonky = num * 2 + 4;
            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}\\{1}/",
                    new string(' ', i),
                    new string('@', aMonky));

                aMonky -= 2;
            }

            Console.WriteLine(new string('=', num * 2 + 6));
        }
    }
}
